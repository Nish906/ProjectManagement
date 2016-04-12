using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsAppointmentCollection
    {
        //private data member for the allappointment list
        List<clsAppointments> appointmentsList = new List<clsAppointments>();


        //public property for allAppointments
        public List<clsAppointments> AppointmentsList
        {
            //getter sends data to requesting code
            get
            {
                //return the private data mamber
                return appointmentsList;
            }

            set
            {
                //assign the incoming value to the private data member
                appointmentsList = value;
            }
        }


        //public int Count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return appointmentsList.Count;
            }
            set
            {

                //???
            }
        }

        public clsAppointmentCollection()
        {
            //create an instance of dataconnction 
            clsDataConnection DB = new clsDataConnection();
            //excute the store procedure to get the list of data
            DB.Execute("sproc_tblBookedAppointments_SelectAll");
            //get the count of records 
            Int32 RecordCount = DB.Count;
            //set up the index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a nw instance of the appointment class
                clsAppointments AAppointment = new clsAppointments();
                //get the appointment details 
                AAppointment.AppointmentDetails = DB.DataTable.Rows[Index]["AppointmentDetails"].ToString();
                //get the primary key
                AAppointment.AppointmentID = Convert.ToInt32(DB.DataTable.Rows[Index]["AppointmentID"]);
                //increment the index
                Index++;
            }
        }
    }
}
