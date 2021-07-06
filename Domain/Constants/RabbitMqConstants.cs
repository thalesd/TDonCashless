namespace TDonCashless.Domain.Core.Constants
{
    public class RabbitMqConstants
    {
        public const string RabbitMqUri = "http://localhost:15672/";
        public const string UserName = "guest";
        public const string password = "guest";
        public const string RegisterOrderCommandQueue = "register.order.command";
    }

}