






var obj = new PersonalComputer("model","d");

Console.Write(obj.GetComputerModel());
Console.ReadKey();
public abstract class Computer
{

    private string type;
    private string model;
    private string cpu;
    private bool isTrunedOn = false;
    public Computer(string _tpye, string _model, string _cpu)
    {
        this.type = _tpye;
        this.model = _model;
        this.cpu = _cpu;
    }
    public string GetComputerModel()
    {
        return model;
    }
    public string GetComputerCpu()
    {
        return model;
    }
    public bool GetComputerStatus()
    {
        return isTrunedOn;
    }
}
class PersonalComputer : Computer
{

    public PersonalComputer(string model, string cpu) : base("", model, cpu)
    {

    }
}
class Notebook : Computer
{

    public Notebook(string model, string cpu) : base("", model, cpu)
    {

    }
}