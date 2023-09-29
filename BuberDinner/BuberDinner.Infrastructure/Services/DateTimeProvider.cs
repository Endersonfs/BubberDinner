using BuberDinner.Application.Common.Interface.Service;

namespace BuberDinner.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        DateTime IDateTimeProvider.UtcNow => DateTime.UtcNow;
    }
}