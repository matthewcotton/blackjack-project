using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Blackjack.Models
{
  public class Table
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("shoe")]
    public Shoe shoe { get; }

    [BsonElement("minBet")]
    public decimal minBet { get; }

    public Table(int numOfDecks, decimal minBetIn = 10)
    {
      shoe = new Shoe(numOfDecks);
      minBet = Math.Round(minBetIn, 2);
    }
  }
}