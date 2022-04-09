using GuMBoxX.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuMBoxX.Models
{
    public class SniperRifle : Gun, ISingleShot
    {

        private Dictionary<int, SniperRifle> _dictionary = new Dictionary<int, SniperRifle>();

        public SniperRifle(string name, int capacity) : base(name, capacity)
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

        public void single()
        {
            throw new NotImplementedException();
        }

        public void singleshot()
        {
            throw new NotImplementedException();
        }
    }
}
