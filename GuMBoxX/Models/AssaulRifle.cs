using System;
using System.Collections.Generic;
using System.Text;

namespace GuMBoxX.Models
{
    public class AssaulRifle : Gun
    {
        public int CurrentBulletType;
        public Pistol BulletType;

        public AssaulRifle(string name, int capacity) : base(name, capacity)
        {


        }

        public override string GetFullInfo()
        {
            throw new NotImplementedException();
        }
    }
}
