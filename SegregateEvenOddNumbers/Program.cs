

//var numbers = new List<int> { 2, 3, 4 };
//var res = numbers.Where(it => it % 2 == 0);

//for (int i = 0; i < numbers.Count; i++)
//{
//    if (numbers[i] % 2 == 0)
//    {
//        Console.Write(numbers[i] + " ");
//    }
//}
//numbers.Remove(6);
//numbers.RemoveAt(2);
//var avg = numbers.Contains(2);
//numbers.RemoveRange(0,1);
//char c = 'M';
//if(char.IsDigit(c))
//{

//}

//string num = c.ToString();
//Console.WriteLine(num);

//numbers.Reverse();
//var index = numbers.IndexOf(7);
//Console.WriteLine($"index of 7 is {index}");

//var evenNums = numbers.Where(it => it % 2 == 0);
//numbers.Add(9);
//Console.Write(string.Join(", ", evenNums));

//evenNums.ToList().ForEach(it =>
//  Console.Write(it + " ")
//);

var customers = new List<Customer>{
new Customer{Id= 1, Name= "Alic"},
new Customer{Id= 2, Name = "Jack"},
new Customer{Id= 3, Name ="Bob"}
};
var orders = new List<Order>
{
    new Order{ CustomerId =1, Product = "Mouse", Amount = 10},
    new Order{ CustomerId =1, Product  ="Keyboard", Amount = 15},
    new Order{ CustomerId =2, Product = "Headphone", Amount = 12},
    new Order{ CustomerId =3, Product = "Mobile", Amount=1500}
};
var query = (from customer in customers join order in orders on customer.Id equals order.CustomerId into customerOrders
            from customerOrder in customerOrders.DefaultIfEmpty()
            select new
            {
               CustomerName = customer.Name,
               ProductName =  customerOrder.Product,
               Amount = customerOrder.Amount,
            }).ToList();

Console.ReadKey();


class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Order
{
    public int CustomerId { get; set; }
    public string Product { get; set; }
    public decimal Amount { get; set; }
}