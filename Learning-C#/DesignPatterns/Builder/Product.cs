using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Product
    {
        private List<string> _parts = new();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            return $"Product parts: {string.Join(", ", _parts)}\n";
        }
    }
}