using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using gamedev.Users.Lib;

namespace gamedev.Database;

public class CsvDataBase : IDatabase
{
    private const string DatabasePath = "/home/redha/share/games/gamedev/database/example.csv";
    public bool IsAccessible { get; set; }
    public void Populate()
    {
    }

    public void Send(Session session)
    {
        var records = new List<UserData>
        {
            new UserData()
            {
                FirstName = session.User?.Data.FirstName,
                LastName = session.User?.Data.LastName,
                Age = session.User?.Data.Age,
            },
        };
        
        var config = new CsvConfiguration(CultureInfo.CurrentCulture)
        {
            HasHeaderRecord = false,
        };
        using var stream = File.Open(DatabasePath, FileMode.Append);
        using var writer = new StreamWriter(stream);
        using var csvWriter = new CsvWriter(writer, config);
        csvWriter.WriteRecords(records);
    }

    public void Retrieve()
    {
        using var reader = new StreamReader(DatabasePath, System.Text.Encoding.UTF8);
        using var csv = new CsvReader(reader, CultureInfo.CurrentCulture);
        csv.Read();
        csv.ReadHeader();
        var records = csv.GetRecords<UserData>();
        foreach (var record in records)
        {
            Console.WriteLine("{0} {1} : {2} years old",record.FirstName, record.LastName, record.Age);
        }
    }
}