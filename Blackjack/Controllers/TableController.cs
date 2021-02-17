using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Blackjack.Models;
using Blackjack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Blackjack.Controllers
{
  [Route("[controller]")]
  [ApiController]
  
  public class TableController : ControllerBase
  {
    private readonly ILogger<TableController> _logger;
    private readonly JsonTableService _tableService;

    public TableController(ILogger<TableController> logger, JsonTableService tableService)
    {
      _logger = logger;
      _tableService = tableService;
    }

    [HttpGet] // get all
    public ActionResult<string> Get()
    {
      Table table = new Table(4, 12);
      var card = new Card("10", 'S');
      return JsonSerializer.Serialize(table);
    }


    // [HttpGet] // get one


    [HttpPost]
    public ActionResult<Table> Create(int numOfDecks, decimal minBet)
    {
      Table table = new Table(1, 12);
      // _tableService.InsertInDb(table);
      // return CreatedAtRoute("GetTask", new { id = table.tableId.ToString() }, table);
      return table;
    }
  }
}