using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Commands.CreateOrder
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(createOrderCommand =>
            createOrderCommand.OrderId).NotEqual(Guid.Empty);
            RuleFor(createOrderCommand =>
            createOrderCommand.OrderGetDate).NotEmpty();
            RuleFor(createOrderCommand =>
            createOrderCommand.OrderSetDate).NotEmpty();
            RuleFor(createOrderCommand =>
            createOrderCommand.OrderStatus).NotEmpty();
        }
    }
}
