﻿using System;
using System.Collections.Generic;
using System.Text;

namespace zCzosnkowym.DataAccess.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string BankAccount { get; set; }
        public string LastName { get; set; }
    }
}
