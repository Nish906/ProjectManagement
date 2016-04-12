using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class tstAppointments
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsAppointments TestAppointments = new clsAppointments();
            //evaluate class for content
            Assert.IsNotNull(TestAppointments);
        }

        /*[TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of a class
            clsAppointments AAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
        } */


        [TestMethod]
        public void AppointmentDetailsOK()
        {
            //create an instance of a class
            clsAppointments TestDetails = new clsAppointments();
            //declare testing variable
            string TestData;
            //assign value to test variable
            TestData = "Software Instalation";
            //pass data to properites within class library
            TestDetails.AppointmentDetails = TestData;
            //evaluate the outcome
            Assert.AreEqual(TestDetails.AppointmentDetails, TestData);
        }

        [TestMethod]
        public void AppointmentIDOK()
        {
            //create an instance of a class
            clsAppointments TestDetails = new clsAppointments();
            //declare testing variable
            Int32 TestData;
            //assign value to test variable
            TestData = 1;
            //pass data to properites within class library
            TestDetails.AppointmentID = TestData;
            //evaluate the outcome
            Assert.AreEqual(TestDetails.AppointmentID, TestData);
        }

        [TestMethod]
        public void AppointmentDateOK()
        {
            //create an instance of a class
            clsAppointments TestDetails = new clsAppointments();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            TestDetails.AppointmentDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TestDetails.AppointmentDate, TestData);
        }


        [TestMethod]
        public void AppointmentDetailsMinMinusOne()
        {
            //create an instance of a class
            clsAppointments TestAppointment = new clsAppointments();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestAppointment.ValidAppointmentDetailMin("");
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AppointmentDetailsMin()
        {
            //create an instance of a class
            clsAppointments TestAppointment = new clsAppointments();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestAppointment.ValidAppointmentDetailMin("a");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AppointmentDetailsMinPlus1()
        {
            //create an instance of a class
            clsAppointments TestAppointment = new clsAppointments();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestAppointment.ValidAppointmentDetailMin("aa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AppointmentDetailsMaxMinusOne()
        {
            //create an instance of a class
            clsAppointments TestAppointment = new clsAppointments();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestAppointment.ValidAppointmentDetailMin("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AppointmentDetailsMaxBoundary()
        {
            //create an instance of a class
            clsAppointments TestAppointment = new clsAppointments();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestAppointment.ValidAppointmentDetailMax("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AppointmentDetailsMaxPlusOne()
        {
            //create an instance of a class
            clsAppointments TestAppointment = new clsAppointments();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestAppointment.ValidAppointmentDetailMax("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AppointmentDetailsMaxExtreme()
        {
            //create an instance of a class
            clsAppointments TestAppointment = new clsAppointments();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestAppointment.ValidAppointmentDetailMax("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            //evaluate return value
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void AppointmentDetailsMid()
        {
            //create an instance of a class
            clsAppointments TestAppointment = new clsAppointments();
            //declare testing variable
            Boolean OK = false;
            string SomeApointments = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            OK = TestAppointment.ValidAppointmentDetailMid(SomeApointments);
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void AppointmentIDMinMinusOne()
        {
            //create an instance of a class
            clsAppointments TestAppointmentID = new clsAppointments();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestAppointmentID.ValidAppointmentIDMin(-1111111111);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AppointmentIDMaxMinusOne()
        {
            //create an instance of a class
            clsAppointments TestAppointmentID = new clsAppointments();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestAppointmentID.ValidAppointmentIDMax(99999998);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AppointmentIDMinBoundary()
        {
            //create an instance of a class
            clsAppointments TestAppointmentID = new clsAppointments();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestAppointmentID.ValidAppointmentIDMin(00000001);
            //evaluate return value
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void AppointmentIDInvalidDataType()
        {
            //create an instance of a class
            clsAppointments TestAppointmentID = new clsAppointments();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestAppointmentID.ValidAppointmentInvalid("aaaaaa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AppointmentDateExtemeMin()
        {
            //create an instance of a class
            clsAppointments TestAppointmentDate = new clsAppointments();
            //boolean varibale to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentDetails = "Software Upgrade";
            //create varible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date minus 365 days
            TestDate = TestDate.AddDays(-365);
            //convert the date variable to a string variable
            string AppointmentDate = TestDate.ToString();
            //invoke the method
            OK = TestAppointmentDate.ValidAppointmentDate(AppointmentDetails, AppointmentDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AppointmentDateMinMinusOne()
        {
            //create an instance of a class
            clsAppointments TestAppointmentDate = new clsAppointments();
            //boolean varibale to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentDetails = "Software Upgrade";
            //create varible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date minus 365 days
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string AppointmentDate = TestDate.ToString();
            //invoke the method
            OK = TestAppointmentDate.ValidAppointmentDate(AppointmentDetails, AppointmentDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AppointmentDateMinBondary()
        {
            //create an instance of a class
            clsAppointments TestAppointmentDate = new clsAppointments();
            //boolean varibale to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentDetails = "Software Upgrade";
            //create varible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date minus 365 days
            TestDate = TestDate.Date;
            //convert the date variable to a string variable
            string AppointmentDate = TestDate.ToString();
            //invoke the method
            OK = TestAppointmentDate.ValidAppointmentDate(AppointmentDetails, AppointmentDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AppointmentDateMinPlusOne()
        {
            //create an instance of a class
            clsAppointments TestAppointmentDate = new clsAppointments();
            //boolean varibale to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentDetails = "Software Upgrade";
            //create varible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date minus 365 days
            TestDate = TestDate.Date;
            //convert the date variable to a string variable
            string AppointmentDate = TestDate.ToString();
            //invoke the method
            OK = TestAppointmentDate.ValidAppointmentDate(AppointmentDetails, AppointmentDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }






        [TestMethod]
        public void AppointmentDateMaxMinusOne()
        {
            //create an instance of a class
            clsAppointments TestAppointmentDate = new clsAppointments();
            //boolean varibale to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentDetails = "Software Upgrade";
            //create varible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date.AddDays(729);
            //change the date to whatever the date minus 365 days
            TestDate = TestDate.Date;
            //convert the date variable to a string variable
            string AppointmentDate = TestDate.ToString();
            //invoke the method
            OK = TestAppointmentDate.ValidAppointmentDate(AppointmentDetails, AppointmentDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AppointmentDateMaxBoundary()
        {
            //create an instance of a class
            clsAppointments TestAppointmentDate = new clsAppointments();
            //boolean varibale to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentDetails = "Software Upgrade";
            //create varible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date.AddDays(730);
            //change the date to whatever the date minus 365 days
            TestDate = TestDate.Date;
            //convert the date variable to a string variable
            string AppointmentDate = TestDate.ToString();
            //invoke the method
            OK = TestAppointmentDate.ValidAppointmentDate(AppointmentDetails, AppointmentDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AppointmentDateMaxPlusOne()
        {
            //create an instance of a class
            clsAppointments TestAppointmentDate = new clsAppointments();
            //boolean varibale to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentDetails = "Software Upgrade";
            //create varible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date.AddDays(731);
            //change the date to whatever the date minus 365 days
            TestDate = TestDate.Date;
            //convert the date variable to a string variable
            string AppointmentDate = TestDate.ToString();
            //invoke the method
            OK = TestAppointmentDate.ValidAppointmentDate(AppointmentDetails, AppointmentDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AppointmentDateMid()
        {
            //create an instance of a class
            clsAppointments TestAppointmentDate = new clsAppointments();
            //boolean varibale to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentDetails = "Software Upgrade";
            //create varible to store the test date data
            DateTime TestDate;
            //TestDate = DateTime.Now.Date;
            //set the date to todays date
            TestDate = DateTime.Now.Date.AddDays(365);
            //change the date to whatever the date minus 365 days
            TestDate = TestDate.Date;
            //convert the date variable to a string variable
            string AppointmentDate = TestDate.ToString();
            //invoke the method
            OK = TestAppointmentDate.ValidAppointmentDate(AppointmentDetails, AppointmentDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AppointmentDateExtremeMax()
        {
            //create an instance of a class
            clsAppointments TestAppointmentDate = new clsAppointments();
            //boolean varibale to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentDetails = "Software Upgrade";
            //create varible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date.AddDays(1000);
            //change the date to whatever the date minus 365 days
            TestDate = TestDate.Date;
            //convert the date variable to a string variable
            string AppointmentDate = TestDate.ToString();
            //invoke the method
            OK = TestAppointmentDate.ValidAppointmentDate(AppointmentDetails, AppointmentDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AppointmentDateInvaild()
        {
            //create an instance of a class
            clsAppointments TestAppointmentDate = new clsAppointments();
            //boolean varibale to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentDetails = "Software Upgrade";
            //create varible to store the test date data
            //set the dataadded to a non date value
            string AppointmentDate = "this is not a date!";
            //invoke the method
            OK = TestAppointmentDate.ValidAppointmentDate(AppointmentDetails, AppointmentDate);
            //test to see that the results is correct
            Assert.IsFalse(OK);
        }

        /*[TestMethod]
        public void AppointmentTimeExtremeMin()
        {
            //create an instance of a class
            clsAppointments TestAppointmentTime = new clsAppointments();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestAppointmentTime.ValidAppointmentInvalid("aaaaaa");
            //evaluate return value
            Assert.IsTrue(OK);
        } */

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of a class
            clsAppointments TestAppointmentDate = new clsAppointments();
            //boolean varibale to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method
            Int32 AppointmentID = 2;
            //invoke the method
            Found = TestAppointmentDate.Find(AppointmentID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAppointmentDetailsFound()
        {
            //create an instance of a class
            clsAppointments TestAppointmentDate = new clsAppointments();
            //boolean varibale to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AppointmentID = 2;
            //invoke the method
            Found = TestAppointmentDate.Find(AppointmentID);
            //check the property 
            if (TestAppointmentDate.AppointmentDetails != "Software Upgrade")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAppointmentDateFound()
        {
            //create an instance of a class
            clsAppointments TestAppointmentDate = new clsAppointments();
            //boolean varibale to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AppointmentID = 2;
            //invoke the method
            Found = TestAppointmentDate.Find(AppointmentID);
            //check the property 
            if (TestAppointmentDate.AppointmentDate != Convert.ToDateTime ("16/9/2016"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAppointmentID()
        {
            //create an instance of a class
            clsAppointments TestAppointmentID = new clsAppointments();
            //boolean varibale to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AppointmentID = 2;
            //invoke the method
            Found = TestAppointmentID.Find(AppointmentID);
            //check the property 
            if (TestAppointmentID.AppointmentID !=2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
