using Aspose.Cells.Drawing.Texts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuMBoxX.Models
{
    public abstract class Gun : Base
    {
        private int _capacity;
        private int _currentBulletType;


        public int CurrentBulletType;
        public Bullet BulletType;

        public abstract string GetFullInfo();

        public int Capacity
        {
          get { return _capacity; }
          set
          {
              if (value < 1)
              {
              
              }
                _capacity = value;

          }    


        }
        public Gun(string name, int capacity) : base(name)
        {
            Capacity = capacity;

        }
    }
}
