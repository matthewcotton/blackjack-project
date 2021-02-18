using System;

namespace Blackjack.Models
{
  public class TableSetupData
  {
    public int numOfDecks { get; set; }

    public decimal minBet { get; set; }

    // public TableSetupData(int decksIn, decimal betIn)
    // {
    //     numOfDecks = decksIn;
    //     minBet = betIn;
    // }
  }
}
