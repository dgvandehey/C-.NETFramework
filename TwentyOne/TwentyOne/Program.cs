﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

         

            Deck deck = new Deck();
            deck.Shuffle();

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.face + " of " + card.suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        
        
    }
}
