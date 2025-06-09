namespace Tomato.Models
{
    public class MenuItem
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public MenuItem(string code, string name, int price)
        {
            Code = code;
            Name = name;
            Price = price;
        }
    }
}
