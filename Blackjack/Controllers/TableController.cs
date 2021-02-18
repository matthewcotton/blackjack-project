using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Blackjack.Models;
using Blackjack.Services;


namespace Blackjack.Controllers
{
  [ApiController]
  [Route("[controller]")]

  public class TableController : ControllerBase
  {
    private readonly ILogger<TableController> _logger;
    private IMongoCollection<Table> _tableCollection;

    public TableController(ILogger<TableController> logger, IMongoClient client)
    {
      _logger = logger;
      var database = client.GetDatabase("blackjack");
      _tableCollection = database.GetCollection<Table>("tables");
    }

    [HttpGet]
    public ActionResult<List<Table>> GetAll()
    {
      return _tableCollection.Find(table => true).ToList();
    }

    [HttpGet("{id:length(24)}")]
    public ActionResult<Table> GetOne(string id)
    {
      var table = _tableCollection.Find<Table>(table => table.Id == id).FirstOrDefault();
      return table == null ? NotFound() : table;
    }

    [HttpPost]
    public Table Create([FromBody] TableSetupData setupData)
    {
      Table table = new Table(setupData.numOfDecks, setupData.minBet);
      _tableCollection.InsertOne(table);
      return table;
    }
  }
}