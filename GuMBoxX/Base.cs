using System;
using System.Collections.Generic;
using System.Text;

namespace GuMBoxX
{
    public abstract class Base
    {
        private static int _idCounter;
        public int Id  { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpDatedDate { get; set; }


        static Base()
        {
          _idCounter = 0;
        }

        public Base()
        {
            ++_idCounter;
            CreateDate = DateTime.Now;
        }
        public Base(string name) : this()
        {
            Name = name;
        }

        
       	

     	
        
        
        
        
        
       
    }
}
