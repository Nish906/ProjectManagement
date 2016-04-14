using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsEmailCollection
    {
        //Private data member for the list
        List<clsEmail> emailList = new List<clsEmail>();

        //Public property for the email list
        public List<clsEmail> EmailList
        {
            get
            {
                //Return the private data
                return emailList;
            }
            set
            {
                //Set the private data
                emailList = value;
            }
        }

        //Public property for count
        public int Count
        {
            get
            {
                //Return the count of the list
                return emailList.Count;
            }
            set
            {
                //
            }
        }

        public clsEmail ThisEmail { get; set; }
    }
}
