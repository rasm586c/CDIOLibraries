﻿/*
===============================
 AUTHOR: Rasmus Søborg (S185119)
 CREATE DATE: 06/06/2020
 PURPOSE: This mdoel represents a simple playing card in the solitaire game
 SPECIAL NOTES:
 MODIFIED BY: Nicklas Beyer Lydersen (S185105)
 LAST MODIFIED DATE: 19/06/2020
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

        public Point MinWorldPoint { get; set; }
        public Point MaxWorldPoint { get; set; }

        public bool Uncovered { get; set; } = true;

        public CardModel() { }

        public CardModel(string ModelType)
        {
            Type = (CardType)Enum.Parse(typeof(CardType), ModelType);
        }

        public override bool Equals(object obj)
        {
            return obj is CardModel model &&
                   Type == model.Type;
        }

        public override int GetHashCode()
        {
            return 2049151605 + Type.GetHashCode();
        }
    }
}
