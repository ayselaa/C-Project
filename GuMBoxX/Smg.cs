using System;
using System.Collections.Generic;
using System.Text;

namespace GuMBoxX
{
    internal class Smg
    {
        private Dictionary<int, Pistol> _dictionary = new Dictionary<int, Pistol>();
        public Smg(string v1, int v2)
        {
            V1 = v1;
            V2 = v2;
        }

        public string V1 { get; }
        public int V2 { get; }

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
