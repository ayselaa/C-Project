using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GuMBoxX.Models
{
    public class Pistol : Gun
    {
        private Dictionary<int, Pistol> _dictionary = new Dictionary<int, Pistol>();
        public Pistol(string name, int capacity) : base(name, capacity)
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
