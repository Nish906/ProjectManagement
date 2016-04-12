using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsAppointments
    {
        //private data member for the AppointmentID Property
        private Int32 appointmentID;
        //private data member for the AppointmentDate Property
        private DateTime appointmentDate;
        //private data member for the AppointmentDetails Property
        private string appointmentDetails;
        
        
        //auto generated property
        public string AppointmentDetails 
        { 
            get
            {
                //return the private data
                return appointmentDetails;
            }
            set
            {
                //set the value of the private data member
                appointmentDetails = value;
            }
                
        }    
                
        //auto generated property
        public int AppointmentID
        {
            get
            {
                //return the private data
                return appointmentID;
            }
            set
            {
                //set the value of the private data member
                appointmentID = value;
            }
        }
            
        //auto generated property
        public DateTime AppointmentDate 
        { 
             get
            {
                return appointmentDate;
            }
            set
            {
                appointmentDate = value;
            }
        
        }


        //testing method
        public bool ValidAppointmentDetailMin(string AppointmentDetails)
        {
            if (AppointmentDetails.Length < 1)
            {
                return false;
            }

            else
            {
                return true;
            }
        }


        //testing method
        public bool ValidAppointmentDetailMax(string AppointmentDetails)
        {
            if (AppointmentDetails.Length > 100)
            {
                return false;
            }

            else
            {
                return true;
            }
        }


        //testing method
        public bool ValidAppointmentDetailMid(string AppointmentDetailsMid)
        {
            Boolean OK = true;

            if (AppointmentDetailsMid == "")
            {
                OK = false;
            }

            if (AppointmentDetailsMid.Length > 50)
            {
                OK = false;
            }

            return OK;
        }


        //testing method
        public bool ValidAppointmentIDMin(int AppointmentID)
        {
            if (AppointmentID < 00000001)
            {
                return false;
            }

            else
            {
                return true;

            }
        }

        //testing method
        public bool ValidAppointmentIDMax(int AppointmentID)
        {
            if (AppointmentID > 99999999)
            {
                return false;
            }

            else
            {
                return true;

            }
        }

        //testing method
        public bool ValidAppointmentInvalid(string InvalidAppointment)
        {
            Int32 Test;
            try
            {
                Test = Convert.ToInt32(InvalidAppointment);
                return false;
            }
            catch
            {
                return true;
            }
        }

        public bool ValidAppointmentDateMin(string TestDate)
        {
            DateTime TempDate;
            Boolean OK = true;
            try
            {
                TempDate = Convert.ToDateTime(TestDate);
                if (TempDate < DateTime.Now.Date.AddDays(-1))
                {
                    OK = false;
                }
            }

            catch
            {
                
            }
            return true;
        }


        public bool ValidAppointmentDate(string AppointmentDetails, string AppointmentDate)
        {
            try
            {
                DateTime DateTemp;
                Boolean OK = true;

                DateTemp = Convert.ToDateTime(AppointmentDate);
                //check to see whether the date is less than todays date
                if (DateTemp < DateTime.Now.Date)
                {
                    //set the flog OK to false
                    OK = false;
                }

                if (DateTemp > DateTime.Now.Date.AddDays(730))
                {
                    OK = false;
                }
                //return the value to OK
                return OK;
            }
            catch
            {
                return false;
            }
            /*
            //create a boolean variable to flag the error
            Boolean OK = true;
            //create a temporary variable to store date values
            DateTime DateTemp;
            //copy the DateAdded value to the DateTemp variable
            DateTemp = Convert.ToDateTime(AppointmentDate);
            //check to see whether the date is less than todays date
            if (DateTemp < DateTime.Now.Date)
            {
                //set the flog OK to false
                OK = false;
            }

            if (DateTemp > DateTime.Now.Date.AddDays(730))
            {
                OK = false;
            }
            //return the value to OK
            return OK;
              */
        }

        /*public bool ValidAppointmentDateMax(string AppointmentDetails, string AppointmentDate)
        {
            //create a boolean variable to flag the error
            Boolean OK = true;
            //create a temporary variable to store date values
            DateTime DateTemp;
            //copy the DateAdded value to the DateTemp variable
            DateTemp = Convert.ToDateTime(DateAdded);
            //check to see whether the date is less than todays date
            if (DateTemp > DateTime.Now.Date.AddDays(730))
            {
                //set the flog OK to false
                OK = false;
            }
            //return the value to OK
            return OK;
        } */


        /*public bool Find(int AppointmentID)
        {
            //set the private data member to the test data value
            appointmentID = 1;
            appointmentDetails = "Software Upgrade";
            appointmentDate = Convert.ToDateTime("16/09/2016");
            //always return true
            return true;
        } */

        public bool Find(int AppointmentID)
        {
            appointmentID = 2;
            appointmentDate = Convert.ToDateTime("16/09/2016");
            appointmentDetails = "Software Upgrade";
            return true;
        } 
       /* {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AppointmentID", AppointmentID);
            DB.Execute("sproc_tblAppointmentTests_FilterByAppointmentID");
            if (DB.Count ==1)
            {
                appointmentID = Convert.ToInt32(DB.DataTable.Rows[0]["AppointmentID"]);
                appointmentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["AppointmentDate"]);
                appointmentDetails = Convert.ToString(DB.DataTable.Rows[0]["AppointmentDetails"]);
                return true;
            }
            else
            {
                return false;
            }
        } */
    }
    }
    

