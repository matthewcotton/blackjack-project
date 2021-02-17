
namespace Blackjack.Models
{
  public class Card
  {
    public char suit { get; }

    public string rank { get; }

    public bool dealt { get; set; }

    public Card(string rankIn, char suitIn)
    {
      suit = suitIn;
      rank = rankIn;
      dealt = false;
    }

    public string name => rank + suit;
  }
}