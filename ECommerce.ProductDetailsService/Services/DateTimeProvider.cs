using ECommerce.Common.Services;

namespace ECommerce.ProductDetailsService.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}