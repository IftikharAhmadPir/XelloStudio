using System;
using System.Collections.Generic;
using System.Text;
using Xello.DataLayer.Models;

namespace Xello.BusinessLayer
{
    public class UserCredentialsFunctions
    {
        public void createUser()
        {
            using(var context = new XelloContext())
            {
                var cred = new UserCredential()
                {
                    UserName = "Ifah",
                    Password = "test123",
                    FirstName = "Iftikhar",
                    LastName = "Ahmad",
                    Email = "iftikharahmad.pir@gmail.com"
                };
                context.UserCredentials.Add(cred);
                context.SaveChanges();
            }
        }
    }
}
