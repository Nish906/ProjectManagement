using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsCustomer
    {
        //auto generated property
        public int Address { get; set; }
        //auto generated property
        public string Street { get; set; }


        //Testing method
        public bool ValidIntNoData(int AddressNo)
        {
            if (AddressNo <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidInt(int AddressNo)
        {
            if (AddressNo <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //testing method
        public bool Validstring(string InvalidAddressNo)
        {
            Int32 test;
            try
            {
                test = Convert.ToInt32(InvalidAddressNo);
                return false;
            }
            catch
            {
                return true;
            }
        }

        public bool ValidIntInvalidData(string InvalidAddressNo)
        {
            Int32 test;
            try
            {
                test = Convert.ToInt32(InvalidAddressNo);
                return false;
            }
            catch
            {
                return true;
            }
        }


        public bool ValidStringInvalidData(string InvalidFirstName)
        {
            if (InvalidFirstName.Length >= 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Find(int CustomerNo)
        {
            //always return true
            return true;
        }

        public bool Valid(string HouseNo, string Street, string Town, string PostCode, string DateAdded)
        {
            //always return true
            return false;
        }

        public bool ValidConvert(string HouseNo, string Street, string Town, string PostCode, string DateAdded)
        {
            //always return true
            return true;
        }

     


        public bool Valid(string Address, string City, string PostCode, string DateAdded)
        {
            //Create a Boolean Variable to flag the error
            Boolean OK = true;
            //Create a temprary variable to store the date values
            DateTime DateTemp;
            //if the HouseNo is blank
            if (Address.Length == 0)
            {
                //set tbe flag OK to false
                OK = false;
            }
            //if the house no is greater than 6 characters
            if (Address.Length > 6)
            {
                //set the flag OK to false
                OK = false;
            }
            //Copy date Added value to the DateTemp variable
            DateTemp = Convert.ToDateTime(DateAdded);
            //check to see if the date is less than today's date
            if (DateTemp < DateTime.Now.Date)
            {
                //Set the flag OK to false
                OK = false;
            }
            //return tthe value OK
            return OK;
        }

        public int CustomerNo { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public string EmailAddress { get; set; }

        public string PostCode { get; set; }
    }
    }

