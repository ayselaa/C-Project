using System;
using System.Collections.Generic;
using System.Text;

namespace GuMBoxX.Models
{
    public class Bullet : Base
    {
        private string [] _BulletType;
        public string [] GetBulletType()
        {
            return _BulletType;
        }
        public int Length()
        {
            return  _BulletType.Length;
        }

    }
}
