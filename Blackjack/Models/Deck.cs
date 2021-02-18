using System.Collections.Generic;
using System.Linq;

namespace Blackjack.Models
{
  public class Deck
  {
    private string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
    private char[] suits = { 'C', 'D', 'H', 'S' };

    public List<Card> deckOfCards { get; set; }

    public Deck()
    {
      deckOfCards = new List<Card>();
      var pairs = from r in ranks
                  from s in suits
                  select (r, s);
      foreach (var pair in pairs)
      {
        deckOfCards.Add(new Card(pair.r, pair.s));
      }
    }
  }
}