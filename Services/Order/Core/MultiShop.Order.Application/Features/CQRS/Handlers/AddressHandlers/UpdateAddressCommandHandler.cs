using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class UpdateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;

        public UpdateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAddressCommand command)
        {
            var address = await _repository.GetByIdAsync(command.AddressId);
            address.UserId = command.UserId;
            address.District = command.District;
            address.City = command.City;
            address.Detail = command.Detail;

            await _repository.UpdateAsync(address);
        }
    }
}
