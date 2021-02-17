using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Blackjack.Models;
using Microsoft.AspNetCore.Hosting;

namespace Blackjack.Services
{
  public class JsonTableService
  {
    public void InsertInDb(Table newTable)
    {
      File.WriteAllText("./Data/tables.json", JsonSerializer.Serialize("data: test"));
      File.WriteAllText("./Data/tables.json", JsonSerializer.Serialize(newTable));
    }

    public List<Table> GetListDb()
    {
      using (var jsonFileReader = File.OpenText("./Data/tables.json"))
      {
        return JsonSerializer.Deserialize<List<Table>>(jsonFileReader.ReadToEnd(),
            new JsonSerializerOptions
            {
              PropertyNameCaseInsensitive = true
            });
      }
    }

  }
}