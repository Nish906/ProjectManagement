using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsEmail
    {
        //Private member for the EmailID property
        private Int32 emailID;
        //Private data member for field
        private string field;
        //Private data member for subject
        private string subject;
        //Private data member for address
        private string address;
        //Private data member for date
        private DateTime date;

        //Public property for the email subject
        public string EmailSubject
        {
            get
            {
                //Return the private data
                return subject;
            }
            set
            {
                //set private data
                subject = value;
            }
        }

        //Public property for the email id
        public int EmailID
        {
            get
            {
                //Return the private data
                return emailID;
            }
            set
            {
                //Set the value of the private data member
                emailID = value;
            }
        }

        //Public property for the email field
        public string EmailField
        {
            get
            {
                //Retrun the private data
                return field;
            }
            set
            {
                //Set the private data
                field = value;
            }
        }

        //Public property for the email address
        public string EmailAddress
        {
            get
            {
                //Return the private data
                return address;
            }
            set
            {
                //Set private data
                address = value;
            }
        }

        public DateTime EmailDate
        {
            get
            {
                //Return the private data
                return date;
            }
            set
            {
                //Set private data
                date = value;
            }
        }

        public bool Valid(string Subject)
        {
            //Boolean flag to indicate that all is OK
            Boolean Ok = true;
            //If the subject is not blank
            if (Subject == "")
            {
                //Flag an error
                Ok = false;
            }
            //If the subject is more than 80 characters
            if (Subject.Length > 80)
            {
                //Flag an error
                Ok = false;
            }
            return Ok;
        }

        public bool ValidField(string Field)
        {
            //Boolean flag to indicate that all is OK
            Boolean Ok = true;
            //If the subject is not blank
            if (Field == "")
            {
                //Flag an error
                Ok = false;
            }
            //If the subject is more than 80 characters
            if (Field.Length > 2000)
            {
                //Flag an error
                Ok = false;
            }
            return Ok;
        }


        public bool ValidAddress(string Address)
        {
            //Boolean flag to indicate that all is OK
            Boolean Ok = true;
            //If the subject is not blank
            if (Address == "ab")
            {
                //Flag an error
                Ok = false;
            }
            //If the subject is more than 80 characters
            if (Address.Length > 40)
            {
                //Flag an error
                Ok = false;
            }
            return Ok;
        }

        public bool ValidDate(string Date)
        {
            //Boolean flag to indicate that all is OK
            Boolean Ok = true;
            //Create a temp variable to store date values
            DateTime DateTemp;
            //Copy the Date value to the DateTemp variable
            DateTemp = Convert.ToDateTime(Date);
            //Check to see if the date is less than today's date
            if (DateTemp < DateTime.Now.Date)
            {
                //Flag error
                Ok = false;
            }
            //Check to see if the date is greater than today's date
            if (DateTemp > DateTime.Now.Date)
            {
                //Flag error
                Ok = false;
            }
            //Return the value OK
            return Ok;
        }

        public bool ValidID(int ID)
        {
            //Boolean flag to indicate that all is OK
            Boolean Ok = true;
            //If the id is not blank
            if (ID == 0)
            {
                //Flag an error
                Ok = false;
            }
            //If the subject is more than 80 characters
            if (ID > 5)
            {
                //Flag an error
                Ok = false;
            }
            return Ok;
        }

        public bool Find(int EmailID)
        {
            //Create an instance of the data connection class
            clsDataConnection DB = new clsDataConnection();
            //Add parameter for the email id to search for
            DB.AddParameter("@EmailID", EmailID);
            //Execute the stored procedure
            DB.Execute("sproc_tblEmails_FilterByEmailID");
            //If one record is found
            if (DB.Count == 1)
            {
                //Copy the data from the database to the private data memebers
                emailID = Convert.ToInt32(DB.DataTable.Rows[0]["EmailID"]);
                field = Convert.ToString(DB.DataTable.Rows[0]["EmailField"]);
                subject = Convert.ToString(DB.DataTable.Rows[0]["EmailSubject"]);
                address = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                date = Convert.ToDateTime(DB.DataTable.Rows[0]["EmailDate"]);
                //Return that everything worked OK
                return true;
            }
            //If no record was found
            else
            {
                //Return false indicating a problem
                return false;
            }
        }
    }
}

