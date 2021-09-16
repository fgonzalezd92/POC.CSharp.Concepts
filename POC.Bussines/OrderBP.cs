using POC.Core.Entities;
using POC.Core.Interfaces.BP;
using POC.Core.Interfaces.Repositories;
using POC.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace POC.Bussines
{
    public class OrderBP : IOrderBP
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly ISendEmailService _sendEmailService;
        public OrderBP(IOrderRepository orderRepository, ICustomerRepository customerRepository, ISendEmailService sendEmailService)
        {
            _orderRepository = orderRepository;
            _customerRepository = customerRepository;
            _sendEmailService = sendEmailService;
        }
        public async Task<bool> Insert(Order order)
        {
            var result = _orderRepository.Insert(order);

            if(result) //Si la orden es creada correctamente este debe enviar un correo.
            {
                await InitializeAndSendCreateOrderEmail(order);
            }

            return result;
        }

        private async Task InitializeAndSendCreateOrderEmail(Order order)
        {
            var customer = _customerRepository.GetById(order.CustomerId);

            await _sendEmailService.SendEmail(customer.Email, "Orden creada", "La orden ha sido creada satisfactoriamente.", false);
        }
    }
}
