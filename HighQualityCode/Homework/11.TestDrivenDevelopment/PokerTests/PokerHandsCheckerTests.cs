using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace PokerTests
{
     [TestClass]
    class PokerHandsCheckerTests
    {
         [TestMethod]
         public void TestIsValidHand()
         {
             Hand hand = new Hand(new List<ICard>
            {
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades) 
            });
             PokerHandsChecker checker = new PokerHandsChecker();

             Assert.IsTrue(checker.IsValidHand(hand));
         }
    }
}
