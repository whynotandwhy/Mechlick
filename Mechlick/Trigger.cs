using System;
using System.Collections.Generic;
using System.Text;

namespace Mechlick
{
    public class Trigger
    {
        public CardType Type { get; set; }
        public short Number { get; set; }
        private List<Effect> _Effects = new List<Effect>();
        public List<Effect> Effects { get { return _Effects; } }
    }
}
