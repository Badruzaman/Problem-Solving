

//IService _service;
//_service = new Service();
//Console.WriteLine(_service.getServiceName());
//_service.GetValue = 10;
//Console.WriteLine(_service.GetValue);
//Console.ReadKey();
//public interface IService
//{
//    string getServiceName();
//    int GetValue { get; set; }
//}
//class Service : IService
//{
//    int _value;
//    public int GetValue
//    {
//        get
//        {
//           return _value;
//        }
//        set
//        {
//            _value = value;
//        }
//    }
//    public string getServiceName()
//    {
//        return "Self service";
//    }
//}

AppConfig appConfig = new AppConfig();

Glass glass = new Glass();
var result = glass.GetGlasses();
foreach (var item in result)
{
    Console.Write(item.Height + " " + item.Id);
}


Console.ReadKey();
public class AppConfig
{
    public static string DatabaseConnectionString { get; set; } = "";
}

public class Glass
{
    public int Id { get; set; }
    public decimal Height { get; set; }
    public decimal Width { get; set; }
    public List<Glass> GetGlasses()
    {
        var glasses = new List<Glass>
        { new Glass { Id = 1, Height = 2, Width = 2 }, new Glass { Id = 2, Height = 1, Width = 2 } };
        for (int i = 0; i < glasses.Count; i++)
        {
            for (int j = i + 1; j < glasses.Count; j++)
            {
                if (glasses[i].Height > glasses[j].Height)
                {
                    var temp = glasses[i];
                    glasses[i] = glasses[j];
                    glasses[j] = temp;
                }
            }
        }
        return glasses;
    }
}



