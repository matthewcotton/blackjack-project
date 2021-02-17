// using Xunit;
// using Blackjack.Models;
// using Blackjack.Services;

// namespace BlackjackTests
// {
//   public class JsonTableServiceTests
//   // {
//   //   private readonly JsonTableService _tableService;

//   //   public JsonTableServiceTests(JsonTableService tableService)
//   //   {
//   //     _tableService = tableService;
//   //   }

//     [Fact]
//     public void CheckDbInculdesNewTable()
//     {
//       var _tableService = new JsonTableService;
//       Table newTable = new Table(4, 15);
//       _tableService.InsertInDb(newTable);
//       var tableDb = _tableService.GetListDb();
//       var result = tableDb.Find(table => table.tableId == newTable.tableId);
//       Assert.True(newTable == result);
//     }

//     [Fact]
//     public void Test()
//     {
//       Assert.True(true);
//     }

//   }
// }
