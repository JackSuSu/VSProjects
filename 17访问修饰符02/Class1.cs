using System;
using System.Collections.Generic;
using System.Text;

namespace _17访问修饰符02
{
    public class Person
    {
        protected string _name=string.Empty;

        protected internal int _prtinternaldata;

        internal int internaldata;

        public int intergerdata;


        private Nullable<int> nulldata;

        public Nullable<int> NullData
        {
            get { return nulldata; }
            set { nulldata = value; }
        }


    }

    public class Student : Person
    {
        
        
     
    }
}
