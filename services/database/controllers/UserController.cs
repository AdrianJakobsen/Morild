using MorilDataServer.services.database.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MorilDataServer.services.database.controllers
{
    [RoutePrefix("_api/database/users")]
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("")]
        public List<User> GetAll()
        {
            var db = new UserModelDataContext();

            IEnumerable<User> queryResult;
            queryResult = db.Users.OrderBy(o => o.Id);

            return queryResult.ToList<User>();
        }

        [HttpGet]
        [Route("{key}")]
        public User Get(string key = null)
        {
            var db = new UserModelDataContext();
            IEnumerable<User> queryResult;
            queryResult = db.Users.Where(o => o.username == key);
            var User = queryResult.FirstOrDefault();
            return User;

        }

        [HttpPost]
        [Route("")]
        public void WriteOrderToDB([FromBody] User value)
        {
            var db = new UserModelDataContext();
            db.Users.InsertOnSubmit(value);
            db.SubmitChanges();
        }

        [HttpPut]
        [Route("{key}")]
        public void UpdateOrderInDB([FromBody] User value, string key)
        {
            var db = new UserModelDataContext();
            int keyValueAsInt = Int32.Parse(key);
            var query = from User in db.Users
                        where User.Id == keyValueAsInt
                        select User;

            var userInDB = query.First();

            #region changeDb
            if(userInDB.username != value.username)
            {
                userInDB.username = value.username;
            }
            if (userInDB.password != value.password)
            {
                userInDB.password = value.password;
            }
            if (userInDB.email != value.email)
            {
                userInDB.email = value.email;
            }
            if (userInDB.phone_number != value.phone_number)
            {
                userInDB.phone_number = value.phone_number;
            }
            #endregion

            db.SubmitChanges();
        }
    }
}