using MorilDataServer.services.database.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MorilDataServer.services.database.controllers
{
    [RoutePrefix("_api/database/orders")]
    public class OrdersController : ApiController
    {
        [HttpGet]
        [Route("")]
        public List<Order> GetAll()
        {
            var db = new OrderModelDataContext();

            IEnumerable<Order> queryResult;
            queryResult = db.Orders.OrderBy(o => o.PriorityNumber);

            return queryResult.ToList<Order>();
        }

        [HttpGet]
        [Route("{key}")]
        public Order Get(string key = null)
        {
            var db = new OrderModelDataContext();
            int keyValueAsInt = Int32.Parse(key);
            IEnumerable<Order> queryResult;
            queryResult = db.Orders.Where(o => o.OrderId == keyValueAsInt);
            var Order = queryResult.FirstOrDefault();
            return Order;

        }

        [HttpPost]
        [Route("")]
        public void WriteOrderToDB([FromBody] Order value)
        {
            var db = new OrderModelDataContext();
            value.DateCreated = DateTime.Today;
            db.Orders.InsertOnSubmit(value);
            db.SubmitChanges();
        }

        [HttpPut]
        [Route("{key}")]
        public void UpdateOrderInDB([FromBody] Order value, string key)
        {
            var db = new OrderModelDataContext();
            int keyValueAsInt = Int32.Parse(key);
            var query = from Order in db.Orders
                        where Order.OrderId == keyValueAsInt
                        select Order;

            var orderInDB = query.First();

            #region changeDb
            if(orderInDB.CompanyId != value.CompanyId)
            {
                orderInDB.CompanyId = value.CompanyId;
            }
            if (orderInDB.CompanyName != value.CompanyName)
            {
                orderInDB.CompanyName = value.CompanyName;
            }
            if (orderInDB.ContactPerson != value.ContactPerson)
            {
                orderInDB.ContactPerson = value.ContactPerson;
            }
            if (orderInDB.Deadline != value.Deadline)
            {
                orderInDB.Deadline = value.Deadline;
            }
            if (orderInDB.Description != value.Description)
            {
                orderInDB.Description = value.Description;
            }
            if (orderInDB.Person != value.Person)
            {
                orderInDB.Person = value.Person;
            }
            if (orderInDB.PriorityNumber != value.PriorityNumber)
            {
                orderInDB.PriorityNumber = value.PriorityNumber;
            }
            if (orderInDB.Headline != value.Headline)
            {
                orderInDB.Headline = value.Headline;
            }
            #endregion

            db.SubmitChanges();
        }
    }
}