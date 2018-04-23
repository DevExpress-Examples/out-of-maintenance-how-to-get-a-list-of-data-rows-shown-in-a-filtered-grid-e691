using System;
using System.Collections.Generic;

namespace WindowsApplication1
{
    public class Customer
    {
        public Customer()
        {

        }

        // Fields...
        private int _ID;
        private string _B;
        private string _LastName;
        private string _FirstName;


        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                _FirstName = value;
            }
        }


        public string LastName
        {
            get { return _LastName; }
            set
            {
                _LastName = value;
            }
        }




        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
            }
        }
        
        
    }
}
