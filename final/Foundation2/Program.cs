using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Product legoSet = new Product("Lego Rocket Ship", "A3439", float.Parse("13.99"));
        Product beans = new Product("Can of Green Beans", "B3333", float.Parse("1.99"));
        Product mango = new Product("Mango", "M43423", float.Parse("2.99"));
        Product socks = new Product("16 Pairs of Black Socks", "S34243", float.Parse("5.99"));
        Product pants = new Product("size 34 pants", "P342423", float.Parse("24.99"));

        
        Address johnAddres = new Address("1234 Nowhere st", "Logan", "UT", "84321", "USA");
        Customer john = new Customer("John Johnson", johnAddres);
        Order johnOrder = new Order(john);
        orders.Add(johnOrder);

        johnOrder.AddToOrder(mango, 23);
        johnOrder.AddToOrder(legoSet, 2);
        johnOrder.AddToOrder(beans, 3);

        Address sarathAddress = new Address("1234 Somewhere Place", "Siem Reap", "Siem Reap", "23432", "Cambodia");
        Customer sarath = new Customer("Sok Sarath", sarathAddress);
        Order sarathOrder = new Order(sarath);
        orders.Add(sarathOrder);

        sarathOrder.AddToOrder(socks, 4);
        sarathOrder.AddToOrder(pants, 5);
        sarathOrder.AddToOrder(mango, 12);



        foreach(Order udder in orders){
            Console.WriteLine(udder.ShipAddressThing());
            Console.WriteLine(udder.PackingLabel());
            Console.WriteLine(udder.TotalCost());
        }     
    }
}