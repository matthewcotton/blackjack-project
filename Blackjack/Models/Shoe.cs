using System;
using System.Collections.Generic;
using System.Linq;

// ADD functionality to deal with a nearly empty Shoe

namespace Blackjack.Models
{
  public class Shoe
  {
    private Deck deck = new Deck();
    public List<Card> shoeOfCards { get; set; }

    public Shoe(int numOfDecks = 4)
    {
      shoeOfCards = new List<Card>();
      for (int i = 0; i < numOfDecks; i++)
      {
        shoeOfCards.AddRange(deck.deckOfCards);
      }
    }

    public int percentageDealt => (int)((100 / (double)shoeOfCards.Count()) * (double)shoeOfCards.Where(card => card.dealt).Count());

    private Random rand = new Random();

    public Card GetCard()
    {
      if (this.percentageDealt == 100)
      {
        return null;
      }
      else
      {
        Card card = shoeOfCards.Where(card => !card.dealt).ElementAt(rand.Next(0, shoeOfCards.Count()));
        card.dealt = true;
        return card;
      }

    }
  }
}