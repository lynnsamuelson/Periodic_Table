using System;

namespace ElementApi.Models
{
    public class AtomicElement
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string AtomicSymbol{ get; set; }
        public decimal AtomicWeight { get; set; }

        internal static object FindElement()
        {
            throw new NotImplementedException();
        }
    }
}


