using MediatR;
using System;


namespace Mc2.CrudTest.Application.Requests.AddCustomer
{
    public class AddCustomerRequest :IRequest
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string BankAccountNumber { get; set; }
    }
}
