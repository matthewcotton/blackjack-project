
using System;

namespace Blackjack.Models
{
  public class Table
  {
    public Shoe shoe { get; }

    public string tableId { get; }

    public decimal minBet { get; }

    public Table(int numOfDecks, decimal minBetIn = 10)
    {
      tableId = DateTime.Now.ToString().GetHashCode().ToString("x");;
      shoe = new Shoe(numOfDecks);
      minBet = Math.Round(minBetIn, 2);
    }
  }
}