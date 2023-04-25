using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp9.NewFolder
{
    internal class User
    {
        private int Id {set;get;}   
        private string Name
        {
            get; //{ return Name; }//
            set;
            //{
            //    if (value.Length > 3)
            //    {
            //        Name = value;
            //    }
            //}
        }
        private string Surname { get;/*{ return Surname; }*/ set;/* { Surname = value; }*/ }
        private static int Age
        {
            get; /*{ return Age; }*/
            set;
            //{
            //    if (value > 0)
            //    {
            //        Age = value;
            //    }
            //}
        }

        public void GetFullName()
        {
            Console.WriteLine(Name + " " + Surname);

        }
        public static void ChangeAge(int age)
        {
            Age = age;
            Console.WriteLine(Age);
        }

    }
}
