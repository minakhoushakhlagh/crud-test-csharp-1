﻿using System;


namespace Mc2.CrudTest.Domain.Models
{
    public class Customer
    {
        public int Id { get; set; } 

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string BankAccountNumber { get; set; }
    }
}
