using GuMBoxX.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuMBoxX.Models
{
    public class AssaulRifle : Gun, IAutoShot, IBurstShot
    {
        public AssaulRifle(string name, int capacity) : base(name, capacity)
        {
        }

        //  private Dictionary<int, AssaulRifle> _dictionary = new Dictionary<int, AssaulRifle>();

        //public AssaulRifle(string name, int capacity) : base(name, capacity)
        //{
        //    _dictionary.Add(Id, this);
        //}

        public void burstshot()
        {
            throw new NotImplementedException();
        }

        public override string GetFullInfo()
        {
            return $"name {Name},capacity {Capacity}";
        }
        public void ShowMethod(AssaulRifle AssaulRifle, AssaulRifle assaulRifle)
        {
            Console.WriteLine(AssaulRifle);
        }
        
        void IAutoShot.autoshot()
        {
            throw new NotImplementedException();
        }
       

        internal void ShowMethod(AssaulRifle assaul)
        {
          

        }

        
    }
}
