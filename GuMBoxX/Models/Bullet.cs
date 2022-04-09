using System;
using System.Collections.Generic;
using System.Text;

namespace GuMBoxX.Models
{
    public class Bullet<T> : Base
    {
        private T[] BulletType;
        public T[] GetBulletType()
        {
            return BulletType;
        }
        public int Length
        {
            get
            {
                return BulletType.Length;
            }
        }

    }
}
