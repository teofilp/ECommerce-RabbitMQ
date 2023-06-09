using MassTransit;

namespace ECommerce.Contracts;

public record AddProductPrice : CorrelatedBy<Guid>
{
    public Guid ProductId { get; set; }
    public decimal Price { get; set; }

    public Guid CorrelationId => ProductId;
}