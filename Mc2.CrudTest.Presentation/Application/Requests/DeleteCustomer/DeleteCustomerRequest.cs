using MediatR;


namespace Mc2.CrudTest.Application.Requests.DeleteCustomer
{
    public class DeleteCustomerRequest : IRequest
    {
        public int Id { get; set; }
    }
}
