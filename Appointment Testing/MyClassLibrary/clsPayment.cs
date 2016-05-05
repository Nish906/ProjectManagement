using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class clsPayment
    {
        public int PayNo { get; set; }

        public int JobID { get; set; }

        public string CurType { get; set; }

        public int TotalCost { get; set; }

        public DateTime Compdate { get; set; }

        public DateTime Paydate { get; set; }

        public string PayType { get; set; }

        public int CardNo { get; set; }

        public bool ValidIntNoData(int Test)
        {
            if (Test <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidInt(int Test)
        {
            if (Test <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidIntInvalidData(string Test)
        {
            Int32 test;
            try
            {
                test = Convert.ToInt32(Test);
                return false;
            }
            catch
            {
                return true;
            }
        }

        public bool ValidString(string Test)
        {
            if (Test.Length <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidStringInvalidData(string Test)
        {
            if (Test.Length >= 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidDateNoData(string Test)
        {
            DateTime TempDate;
            Boolean OK = true;
            try
            {
                TempDate = Convert.ToDateTime(Test);
                if (TempDate < DateTime.Now.Date.AddDays(-1))
                {
                    OK = true;
                }
                return OK;
            }
            catch
            {
                return OK;
            }
        }

        public bool ValidDate(string Test)
        {
            DateTime TempDate;
            Boolean OK = true;
            try
            {
                TempDate = Convert.ToDateTime(Test);
                if (TempDate < DateTime.Now.Date.AddDays(-1))
                {
                    OK = true;
                }
                return OK;
            }
            catch
            {
                return OK;
            }
        }

        public bool ValidDateInvalidData(string Test)
        {
            DateTime TempDate;
            Boolean OK = true;
            try
            {
                TempDate = Convert.ToDateTime(Test);
                if (TempDate < DateTime.Now.Date.AddDays(-1))
                {
                    OK = true;
                }
                return OK;
            }
            catch
            {
                return OK;
            }
        }

        public Boolean Find(Int32 PayNo)
        {
            //open a connection to the database
            clsDataConnection TheDatabase = new clsDataConnection();
            //add the parameter
            TheDatabase.AddParameter("@PayNo", PayNo);
            //execute the stored procedure 
            TheDatabase.Execute("sproc_tblpayments_FilterByPayNo");
            //if only one record is found
            if (TheDatabase.Count == 1)
            {
                //create an instance of clsPayment
                clsPayment ThisRecord = new clsPayment();
                //copy the data from the database
                ThisRecord.PayNo = Convert.ToInt32(TheDatabase.DataTable.Rows[0]["PayNo"]);
                ThisRecord.JobID = Convert.ToInt32(TheDatabase.DataTable.Rows[0]["JobID"]);
                ThisRecord.CurType = Convert.ToString(TheDatabase.DataTable.Rows[0]["CurType"]);
                ThisRecord.TotalCost = Convert.ToInt32(TheDatabase.DataTable.Rows[0]["TotalCost"]);
                ThisRecord.Compdate = Convert.ToDateTime(TheDatabase.DataTable.Rows[0]["Compdate"]);
                ThisRecord.Paydate = Convert.ToDateTime(TheDatabase.DataTable.Rows[0]["Paydate"]);
                ThisRecord.PayType = Convert.ToString(TheDatabase.DataTable.Rows[0]["PayType"]);
                ThisRecord.CardNo = Convert.ToInt32(TheDatabase.DataTable.Rows[0]["CardNo"]);
                //return the object ThisRecord
                return true;
            }
            else
            {
                //return a null value to indicate that something has gone wrong
                return false;
            }
        }

    }
}
