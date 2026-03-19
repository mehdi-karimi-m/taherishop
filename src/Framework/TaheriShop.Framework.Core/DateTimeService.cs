using TaheriShop.Framework.Core.Abstractions;

namespace TaheriShop.Framework.Core;

public class DateTimeService : IDateTimeService
{
    public DateTime GetCurrentDateTime()
    {
        return DateTime.Now;
    }
}