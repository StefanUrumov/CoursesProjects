using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTests
{
    [TestClass]
    public class CardToStringTest
    {
        [TestMethod]
        public void PokerTestToStringSevenDiamonds()
        {
            Card myCard = new Card(CardFace.Seven, CardSuit.Diamonds);
            string result = myCard.ToString();

            Assert.AreEqual("7♦", result);
        }

        [TestMethod]
        public void PokerTestToStringAceHearts()
        {
            Card myCard = new Card(CardFace.Ace, CardSuit.Hearts);
            string result = myCard.ToString();

            Assert.AreEqual("A♥", result);
        }

        [TestMethod]
        public void PokerTestToStringTwoClubs()
        {
            Card myCard = new Card(CardFace.Two, CardSuit.Clubs);
            string result = myCard.ToString();

            Assert.AreEqual("2♣", result);
        }

        [TestMethod]
        public void PokerTestToStringQueenSpades()
        {
            Card myCard = new Card(CardFace.Queen, CardSuit.Spades);
            string result = myCard.ToString();

            Assert.AreEqual("Q♠", result);
        }
    }
}
