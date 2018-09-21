using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObjectsforModelling.Models
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string NickName;
        public string Gender;
        public int DOB;
        public string Email;

        public Person(string FirstName, string LastName, string NickName, string Gender, int DOB, string Email)
        {
            this.FirstName = "Harsh";
            this.LastName = "Patel";
            this.NickName = "Harshi";

            this.Gender = "male";
            this.DOB = 16;
            this.Email = "h.patel405.hp@gmail.com";
        }
  
    }
}