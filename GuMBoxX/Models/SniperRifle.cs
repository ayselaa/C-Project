using GuMBoxX.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuMBoxX.Models
{
    public class SniperRifle : Gun, ISingleShot
    {
        public SniperRifle(string name, int capacity) : base(name, capacity)
        {
        }

        //private Dictionary<int, SniperRifle> _dictionary = new Dictionary<int, SniperRifle>();

        //public SniperRifle(string name, int capacity) : base(name, capacity)
        //{
        //    _dictionary.Add(Id, this);
        //}

        public override string GetFullInfo()
        {
            return $"name {Name},capacity {Capacity}";
        }



        public void ShowMethod(SniperRifle sniperRifle)
        {
            
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
