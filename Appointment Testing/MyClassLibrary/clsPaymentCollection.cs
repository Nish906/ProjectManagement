using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{

    public class clsPaymentCollection
    {
        //private data memebr for the list
        List<clsPayment> paymentlist = new List<clsPayment>();
        //private data member thisPayment
        clsPayment thisPayment = new clsPayment();

        clsDataConnection dbConnection = new clsDataConnection();

        public Boolean DeletePayment()
        {
            ///This public function provides the functionality for the delete method

            try //try to delete the record
            {
                //create an instance of the data connection class called MyDatabase
                clsDataConnection MyDatabase = new clsDataConnection();
                //add the PaymentNo parameter passed to this function to the list of parameters to use in the database
                MyDatabase.AddParameter("@PayNo", thisPayment.PayNo);
                //execute the stored procedure in the database
                MyDatabase.Execute("sproc_tblPayment_Delete");
                //Set the return value for the function
                return true;
            }
            catch //do this only if the code above failed for some reason
            {
                //report back that there was an error
                return false;
            }
        }

        public List<clsPayment> paymentlist1
        {
            get
            {
                List<clsPayment> paymentlist = new List<clsPayment>(); //create an array list of clsAddressPage
                Int32 RecordCount;//var to store the count of records
                Int32 Index = 0; //vat to store the Index for the loop
                //clsDataConnection dBConnection = new clsDataConnection(); //create a connection to th database
                //dBConnection.AddParameter("@Town", ""); //send a Town filter to the query
                //dBConnection.Execute("sproc_tblshops_FilterByTown"); //execute the query
                RecordCount = dbConnection.Count; //get the count of records
                while (Index < RecordCount) //keep looping till all records are processed
                {
                    clsPayment BlankPage = new clsPayment(); //create a blank address page
                    //copy the data form the table to RAM
                    BlankPage.PayNo = Convert.ToInt32(dbConnection.DataTable.Rows[Index]["PayNo"]);
                    BlankPage.JobID = Convert.ToInt32(dbConnection.DataTable.Rows[Index]["JobID"]);
                    BlankPage.CurType = Convert.ToString(dbConnection.DataTable.Rows[Index]["CurType"]);
                    BlankPage.TotalCost = Convert.ToInt32(dbConnection.DataTable.Rows[Index]["TotalCost"]);
                    BlankPage.Compdate = Convert.ToDateTime(dbConnection.DataTable.Rows[Index]["Compdate"]);
                    BlankPage.Paydate = Convert.ToDateTime(dbConnection.DataTable.Rows[Index]["Paydate"]);
                    BlankPage.PayType = Convert.ToString(dbConnection.DataTable.Rows[Index]["PayType"]);
                    BlankPage.CardNo = Convert.ToInt32(dbConnection.DataTable.Rows[Index]["CardNo"]);
                    //add the blank page to the array list
                    paymentlist.Add(BlankPage);
                    //increase the index
                    Index++;
                }
                //return the list as the return value of the function
                return paymentlist;
            }
        }
        public Int32 Count
        //public read only propety for the count of records found
        {
            get
            {
                //return the count of records
                return dbConnection.Count;
            }
        }

        public void UpdatePayment()
        {
            clsDataConnection ExistingDBPayments = new clsDataConnection();
            //add the parameters
            ExistingDBPayments.AddParameter("@PayNo", thisPayment.PayNo);
            ExistingDBPayments.AddParameter("@JobID", thisPayment.JobID);
            ExistingDBPayments.AddParameter("@CurType", thisPayment.CurType);
            ExistingDBPayments.AddParameter("@TotalCost", thisPayment.TotalCost);
            ExistingDBPayments.AddParameter("@Compdate", thisPayment.Compdate);
            ExistingDBPayments.AddParameter("@Paydate", thisPayment.Paydate);
            ExistingDBPayments.AddParameter("@PayType", thisPayment.PayType);
            ExistingDBPayments.AddParameter("@CardNo", thisPayment.CardNo);
            //execute the query
            ExistingDBPayments.Execute("sproc_tblshops_Update");
        }

        public void Find(string PaymentCostFilter)
        {
            dbConnection.AddParameter("@TotalCost", PaymentCostFilter);//send a post code filter to the query
            dbConnection.Execute("sproc_tblpayments_FilterByTotalCost");//execute the query
        }



        public int InsertPayment()
        {
            //connect to the database
            clsDataConnection NewDBPayment = new clsDataConnection();
            //add the parameters
            NewDBPayment.AddParameter("@JobID", thisPayment.JobID);
            NewDBPayment.AddParameter("@CurType", thisPayment.CurType);
            NewDBPayment.AddParameter("@TotalCost", thisPayment.TotalCost);
            NewDBPayment.AddParameter("@Compdate", thisPayment.Compdate);
            NewDBPayment.AddParameter("@Paydate", thisPayment.Paydate);
            NewDBPayment.AddParameter("@PayType", thisPayment.PayType);
            NewDBPayment.AddParameter("@CardNo", thisPayment.CardNo);
            //execute the stored procedure returning the primary key value of the new record
            return NewDBPayment.Execute("sproc_tblpayments_Insert");
        }

        public clsPayment ThisPayment
        {
            get
            {
                //return the private data 
                return thisPayment;
            }
            set
            {
                //set the private data
                thisPayment = value;
            }

        }

    }
}
