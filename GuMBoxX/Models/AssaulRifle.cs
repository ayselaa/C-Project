using System;
using System.Collections.Generic;
using System.Text;

namespace GuMBoxX.Models
{
    public class AssaulRifle : Gun
    {
        private Dictionary<int, AssaulRifle> _dictionary = new Dictionary<int, AssaulRifle>();

        public AssaulRifle(string name, int capacity) : base(name, capacity)
        {
            _dictionary.Add(Id, this);
        }

        public override string GetFullInfo()
        {
            throw new NotImplementedException();
        }
        public void ShowMethod()
        {
            foreach (var item in _dictionary)
            {
                Console.WriteLine(item.Value.Name);
            }
        }
    }
}
