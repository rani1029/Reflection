using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Reflection
{
    public class CustomerInfo
    {

        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public CustomerInfo(int id, String Name)
        {
            this.Id = id;
            this.Name = Name;
        }
        public CustomerInfo()
        {
            this.Id = 01;
            this.Name = String.Empty;
        }
        public void PrintId()
        {
            Console.WriteLine("{0} is : {0}", this.Name);
        }

        public void PrintName()
        {
            Console.WriteLine("{0} is : {0}", this.Name);
        }



    }
}
