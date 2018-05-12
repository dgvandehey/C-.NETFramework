using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        
        public suit suit { get; set; }
        public face face { get; set; }
    }
    public enum suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
