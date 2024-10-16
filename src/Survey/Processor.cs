using System.Globalization;
using CsvHelper;

namespace gamedev.Survey;

public class Processor
{
    private const string _surveyPath = "/home/redha/share/games/gamedev/database/survey.csv";
    private IEnumerable<Data> lines { get; set; }

    private List<string> _questions = new List<string>();
    private List<string> _responses = new List<string>();
    public void Retrieve()
    {
        using var reader = new StreamReader(_surveyPath, System.Text.Encoding.UTF8);
        using var csv = new CsvReader(reader, CultureInfo.CurrentCulture);
        csv.Read();
        csv.ReadHeader();
        lines = csv.GetRecords<Data>();

        foreach (var line in lines)
        {
            _questions.Add(line.Question);
            _responses.Add(line.Responses);
        }
    }
    
    public void Display()
    {
        for (int i = 0; i < _questions.Count; i++)
        {
            Console.WriteLine("{0}", _questions[i]);
           // Console.WriteLine("{0}", _responses[i]);
        }
        FormatIntoItems(_responses);
    }

    private string[] _availableResponses;
    public void FormatIntoItems(List<string> responses)
    {
        foreach (var line in responses)
        {
            _availableResponses = line.Split(',', StringSplitOptions.None);
        } 
        Display(_availableResponses);
    }

    public void Display(string[] availableResponses)
    {
        foreach (var response in availableResponses)
        {
           Console.WriteLine(response); 
        }
    }
}