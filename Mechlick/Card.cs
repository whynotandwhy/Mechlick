using System;
using System.Collections.Generic;
using System.Text;

namespace Mechlick
{
    public class Card
    {
        public string Lang { get; set; }
        public string Name { get; set; }
        public short Cost { get; set; }
        public string Text { get; set; }
        private readonly List<Trigger> _Triggers = new List<Trigger>();
        public List<Trigger> Triggers { get { return _Triggers; } }
    }
}
