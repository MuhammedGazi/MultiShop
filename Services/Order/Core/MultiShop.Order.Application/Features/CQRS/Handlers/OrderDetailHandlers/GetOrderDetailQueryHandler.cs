using MultiShop.Order.Application.Features.CQRS.Results.OrderDetailResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailQueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public GetOrderDetailQueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetOrderDetailQueryResult>> Handle()
        {
            var orderDetail = await _repository.GetAllAsync();
            return orderDetail.Select(od => new GetOrderDetailQueryResult
            {
                OrderDetailId = od.OrderDetailId,
                ProductId = od.ProductId,
                ProductName = od.ProductName,
                ProductPrice = od.ProductPrice,
                ProductAmount = od.ProductAmount,
                ProductTotalPrice = od.ProductTotalPrice,
                OrderingId = od.OrderingId
            }).ToList();
        }
    }
}
