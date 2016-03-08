using MorilDataServer.services.database.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MorilDataServer.services.database.controllers
{
    [RoutePrefix("_api/database/customers")]
    public class CustomerController : ApiController
    {
        [HttpGet]
        [Route("")]
        public List<Customer> GetAll()
        {
            var db = new CustomerModelDataContext();

            IEnumerable<Customer> queryResult;
            queryResult = db.Customers.OrderBy(o => o.CompanyId);
            return queryResult.ToList<Customer>();
        }

        [HttpGet]
        [Route("{key}")]
        public Customer Get(string key = null)
        {
            var db = new CustomerModelDataContext();
            int keyValueAsInt = Int32.Parse(key);
            IEnumerable<Customer> queryResult;
            queryResult = db.Customers.Where(o => o.CompanyId == keyValueAsInt);
            var customer = queryResult.FirstOrDefault();
            return customer;

        }

        [HttpPost]
        [Route("")]
        public void WriteCustomerToDB([FromBody] Customer value)
        {
            var db = new CustomerModelDataContext();
            db.Customers.InsertOnSubmit(value);
            db.SubmitChanges();
        }

        [HttpPut]
        [Route("{key}")]
        public void UpdateOrderInDB([FromBody] Customer value, string key)
        {
            var db = new CustomerModelDataContext();
            int keyValueAsInt = Int32.Parse(key);
            var query = from Customer in db.Customers
                        where Customer.CompanyId == keyValueAsInt
                        select Customer;

            var orderInDB = query.First();

            #region changeDb
            if(orderInDB.CompanyName != value.CompanyName)
            {
                orderInDB.CompanyName = value.CompanyName;
            }
            if(orderInDB.ContactPerson != value.ContactPerson)
            {
                orderInDB.ContactPerson = value.ContactPerson;
            }
            if(orderInDB.Adress != value.Adress)
            {
                orderInDB.Adress = value.Adress;
            }
            if(orderInDB.Email != value.Email)
            {
                orderInDB.Email = value.Email;
            }
            if(orderInDB.PhoneNumber != value.PhoneNumber)
            {
                orderInDB.PhoneNumber = value.PhoneNumber;
            }

            #endregion

            db.SubmitChanges();
        }
    }
}