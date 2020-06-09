﻿/*
===============================
 AUTHOR: Rasmus Søborg (S185119)
 CREATE DATE: 06/06/2020
 PURPOSE: This mdoel represents a simple playing card in the solitaire game
 SPECIAL NOTES: 
===============================
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    public class CardModel
    {
        public CardType Type { get; set; }

        public Rectangle WorldLocation { get; set; }

        public CardModel() { }

        public CardModel(string ModelType)
        {
            Type = (CardType)Enum.Parse(typeof(CardType), ModelType.Substring(1, ModelType.Length - 1));
        }
    }
}