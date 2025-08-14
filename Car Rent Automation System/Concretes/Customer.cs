using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__3__Grup_calismasi___08._08_.Concretes
{
    public class Customer
    {
        //Fields
        private string _name;
        private string _surname;
        private string _email;


        //Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public override string ToString()
        {
            return $"Customer -> Name : {Name}, Surname : {Surname}, Email : {Email}";
        }
    }
}
