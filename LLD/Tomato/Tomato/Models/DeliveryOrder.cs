namespace Tomato.Models
{
    public class DeliveryOrder : Order
    {
        private string userAddress;

        public DeliveryOrder()
        {
            userAddress = string.Empty;
        }

        public override string GetTypeName()
        {
            return "Delivery";
        }

        public string UserAddress
        {
            get => userAddress;
            set => userAddress = value;
        }
    }
}
