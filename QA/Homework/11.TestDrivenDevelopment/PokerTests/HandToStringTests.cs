using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace PokerTests
{
    [TestClass]
    public class HandToStringTests
    {
        [TestMethod]
        public void PokerTestToStringWithNoCards()
        {
            Hand hand = new Hand(new List<ICard>());
            string result = hand.ToString();
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void PokerTestToStringWithOneCardTenSpades()
        {
            Card tenSpades = new Card(CardFace.Ten, CardSuit.Spades);
            Hand hand = new Hand(new List<ICard>{ tenSpades });
            string result = hand.ToString();
            Assert.AreEqual("10♠", result);
        }

        [TestMethod]
        public void PokerTestToStringWithFiveCards()
        {
            Hand hand = new Hand(new List<ICard>
            {
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades) 
            });
            string result = hand.ToString();
            Assert.AreEqual("7♦ A♥ 2♣ Q♠ 10♠", result);
        }

        [TestMethod]
        public void PokerTestToStringWithSameCards()
        {
            Hand hand = new Hand(new List<ICard>
            {
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades) 
            });
            string result = hand.ToString();
            Assert.AreEqual("10♠ 10♠", result);
        }
    }
}
