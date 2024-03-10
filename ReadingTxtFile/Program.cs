


string line = "2023-03-01 08:15:22 INFO User login successful";
string[] words = line.Split(' ');
var logFile = new LogFile
{
    DateTime = Convert.ToDateTime(words[0] + " " + words[1]),
    Status = words[2],
    Message = string.Join(" ", words.Skip(3))
};

class LogFile
{
    internal DateTime DateTime { get; set; }
    internal string Status { get; set; }
    internal string Message { get; set; }
}