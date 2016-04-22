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
        //private data member thisAppoitment
        clsAppointments thisAppointment = new clsAppointments();

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


        //public property for ThisAppointment
        public clsAppointments ThisAppointment
        {
            get
            {
                //return the private data
                return thisAppointment;
            }

            set
            {
                //set the private data
                thisAppointment = value;
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
        //constructor for the class
        public clsAppointmentCollection()
        {
            //set up the index for the loop
            Int32 Index = 0;
            Int32 RecordCount = 0;
            //create an instance of dataconnction 
            clsDataConnection DB = new clsDataConnection();
            //excute the store procedure to get the list of data
            DB.Execute("sproc_tblAppointment_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a nw instance of the appointment class
                clsAppointments AAppointment = new clsAppointments();
                //get the primary key
                AAppointment.AppointmentID = Convert.ToInt32(DB.DataTable.Rows[Index]["AppointmentID"]);
                //get the appointment details 
                //get the appointment date
                AAppointment.AppointmentDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["AppointmentDate"]);
                //add the record to the private data member
                appointmentsList.Add(AAppointment);
                //points at next record
                Index++;
            }
        }

        public int Add()
        {

            //adds a new record to the database based on the values of thisAppointment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the store proceudre 
            DB.AddParameter("@AppointmentDate", thisAppointment.AppointmentDate);
            //excute the querry returning the primary key value
            return DB.Execute("sproc_tblAppointment_Insert");
        }

        public void Delete()
        {
            //deletes the recor pointed to by thisAppointment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the store procedure
            DB.AddParameter("@AppointmentID", thisAppointment.AppointmentID);
            //Excute the store procedure
            DB.Execute("sproc_tblAppointment_Delete");
        }

        public int AddBooking()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", thisAppointment.FirstName);
            DB.AddParameter("@LastName", thisAppointment.LastName);
            DB.AddParameter("@EmailAddress", thisAppointment.EmailAddress);
            DB.AddParameter("@AppointmentDetails", thisAppointment.AppointmentDetails);
            DB.AddParameter("@AppointmentDate", thisAppointment.AppointmentDate);
            return DB.Execute("sproc_tblBookedAppointments_Insert");

        }

        
    }
}
