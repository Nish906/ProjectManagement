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
        //Private data memeber for this email
        clsEmail thisEmail = new clsEmail();

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

        public void Delete()
        {
            //Deletes the record pointed to by thisEmail
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameter for the stored procedure
            DB.AddParameter("@EmailID", thisEmail.EmailID);
            //Execute the stored procedure
            DB.Execute("sproc_tblEmail_Delete");
        }
    }
}
