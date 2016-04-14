using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace EmailTesting
{
    /// <summary>
    /// Summary description for tstEmail
    /// </summary>
    [TestClass]
    public class tstEmail
    {
        public tstEmail()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Test to see that is exists
            Assert.IsNotNull(AEmail);
        }

        [TestMethod]
        public void EmailSubjectPropertyOK()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Create some test data to assign to the property
            string Subject = "Meetings";
            //Assign the data to the property
            AEmail.EmailSubject = Subject;
            //Test to see that the two values are the same
            Assert.AreEqual(AEmail.EmailSubject, Subject);
        }

        [TestMethod]
        public void EmailFieldPropertyOK()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Create some test data to assign to the property
            string Field = "Hi, I am writing this email";
            //Assign the data to the property
            AEmail.EmailField = Field;
            //Test to see that the two values are the same
            Assert.AreEqual(AEmail.EmailField, Field);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Create some test data to assign to the property
            string Address = "joe-bloggs@gmail.com";
            //Assign the data to the property
            AEmail.EmailAddress = Address;
            //Test to see that the two values are the same
            Assert.AreEqual(AEmail.EmailAddress, Address);
        }

        [TestMethod]
        public void EmailIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsEmail AnEmail = new clsEmail();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            AnEmail.EmailID = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnEmail.EmailID, TestData);
        }

        [TestMethod]
        public void EmailDatePropertyOK()
        {
            //Create an instance of the class we want to create
            clsEmail AnEmail = new clsEmail();
            //Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            AnEmail.EmailDate = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnEmail.EmailDate, TestData);
        }


        //
        //VALID METHOD
        //

        [TestMethod]
        public void ValidMethodOK()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Subject = "Meetings";
            //Invoke the method
            OK = AEmail.Valid(Subject);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidFieldMethodOK()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Field = "Hi, I am writing this email";
            //Invoke the method
            OK = AEmail.ValidField(Field);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidAddressMethodOK()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Address = "joe-bloggs@gmail.com";
            //Invoke the method
            OK = AEmail.ValidAddress(Address);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        //
        //FIND METHOD
        //

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsEmail AnEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Create some test data to assign to the property
            Int32 EmailNo = 9;
            //Invoke the method
            Found = AnEmail.Find(EmailNo);
            //Test to see that the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestEmailIDFound()
        {
            //Create an instance of the class we want to create
            clsEmail AnEmail = new clsEmail();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //Create some test data to assign to the property
            Int32 EmailID = 9;
            //Invoke the method
            Found = AnEmail.Find(EmailID);
            //Check the Email ID
            if (AnEmail.EmailID != 9)
            {
                OK = false;
            }
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailAddressFound()
        {
            //Create an instance of the class we want to create
            clsEmail AnEmail = new clsEmail();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //Create some test data to assign to the property
            Int32 EmailID = 9;
            //Invoke the method
            Found = AnEmail.Find(EmailID);
            //Check the Email ID
            if (AnEmail.EmailAddress != "test.test@test.com")
            {
                OK = false;
            }
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestEmailSubjectFound()
        {
            //Create an instance of the class we want to create
            clsEmail AnEmail = new clsEmail();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //Create some test data to assign to the property
            Int32 EmailID = 9;
            //Invoke the method
            Found = AnEmail.Find(EmailID);
            //Check the Email ID
            if (AnEmail.EmailSubject != "Testing")
            {
                OK = false;
            }
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestEmailFieldFound()
        {
            //Create an instance of the class we want to create
            clsEmail AnEmail = new clsEmail();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //Create some test data to assign to the property
            Int32 EmailID = 9;
            //Invoke the method
            Found = AnEmail.Find(EmailID);
            //Check the Email ID
            if (AnEmail.EmailField != "abcdefghijklmnopqrstuvwxyz")
            {
                OK = false;
            }
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestEmailDateFound()
        {
            //Create an instance of the class we want to create
            clsEmail AnEmail = new clsEmail();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //Create some test data to assign to the property
            Int32 EmailID = 9;
            //Invoke the method
            Found = AnEmail.Find(EmailID);
            //Check the Email ID
            if (AnEmail.EmailDate != Convert.ToDateTime("01/03/2016"))
            {
                OK = false;
            }
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }

        //
        //TEST SUBJECT
        //

        [TestMethod]
        public void SubjectMinMinusOne()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Subject = "";
            //Invoke the method
            OK = AEmail.Valid(Subject);
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void SubjectMinBoundary()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Subject = "a";
            //Invoke the method
            OK = AEmail.Valid(Subject);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SubjectMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Subject = "ab";
            //Invoke the method
            OK = AEmail.Valid(Subject);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SubjectMaxMinusOne()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Subject = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyza";
            //Invoke the method
            OK = AEmail.Valid(Subject);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SubjectMaxBoundary()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Subject = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzab";
            //Invoke the method
            OK = AEmail.Valid(Subject);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SubjectMaxPlusOne()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Subject = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabc";
            //Invoke the method
            OK = AEmail.Valid(Subject);
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void SubjectMid()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Subject = "Abcdefghijklmnopqrstuvwxyzabcdefghijklmn";
            //Invoke the method
            OK = AEmail.Valid(Subject);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SubjectExtremeMax()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Subject = "";
            //Pad the string with a characters
            Subject = Subject.PadRight(500, 'a');
            //Invoke the method
            OK = AEmail.Valid(Subject);
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }

        //
        //TEST FIELD
        //

        [TestMethod]
        public void FieldMinMinusOne()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Field = "";
            //Invoke the method
            OK = AEmail.ValidField(Field);
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FieldMinBoundary()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Field = "a";
            //Invoke the method
            OK = AEmail.ValidField(Field);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FieldMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Field = "ab";
            //Invoke the method
            OK = AEmail.ValidField(Field);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FieldMaxMinusOne()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Field = "";
            //Pad the string with a characters
            Field = Field.PadRight(1999, 'a');
            //Invoke the method
            OK = AEmail.ValidField(Field);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FieldMaxBoundary()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Field = "";
            //Pad the string with a characters
            Field = Field.PadRight(2000, 'a');
            //Invoke the method
            OK = AEmail.ValidField(Field);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FieldMaxPlusOne()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Field = "";
            //Pad the string with a characters
            Field = Field.PadRight(2001, 'a');
            //Invoke the method
            OK = AEmail.ValidField(Field);
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FieldMid()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Field = "";
            //Pad the string with a characters
            Field = Field.PadRight(1000, 'a');
            //Invoke the method
            OK = AEmail.ValidField(Field);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FieldExtremeMax()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Field = "";
            //Pad the string with a characters
            Field = Field.PadRight(3000, 'a');
            //Invoke the method
            OK = AEmail.ValidField(Field);
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }

        //
        //TEST ADDRESS
        //

        [TestMethod]
        public void AddressMinMinusOne()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Address = "ab";
            //Invoke the method
            OK = AEmail.ValidAddress(Address);
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressMinBoundary()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Address = "abc";
            //Invoke the method
            OK = AEmail.ValidField(Address);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Address = "abcd";
            //Invoke the method
            OK = AEmail.ValidAddress(Address);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMaxMinusOne()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Address = "abcdefghijklmnopqrstuvwxyzabcdefghijklm";
            //Invoke the method
            OK = AEmail.ValidAddress(Address);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMaxBoundary()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Address = "abcdefghijklmnopqrstuvwxyzabcdefghijklmn";
            //Invoke the method
            OK = AEmail.ValidAddress(Address);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Address = "abcdefghijklmnopqrstuvwxyzabcdefghijklmno";
            //Invoke the method
            OK = AEmail.ValidAddress(Address);
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressMid()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Address = "abcdefghijklmnopqrst";
            //Invoke the method
            OK = AEmail.ValidAddress(Address);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            string Address = "";
            //Pad the string with a characters
            Address = Address.PadRight(500, 'a');
            //Invoke the method
            OK = AEmail.ValidAddress(Address);
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }

        //
        //TEST DATE
        //

        [TestMethod]
        public void DateExtremeMin()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //Change the date to what ever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //Convert the date variable to a string variable
            string Date = TestDate.ToString();
            //Invoke the method
            OK = AEmail.ValidDate(Date);
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateMinMinusOne()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //Change the date to what ever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //Convert the date variable to a string variable
            string Date = TestDate.ToString();
            //Invoke the method
            OK = AEmail.ValidDate(Date);
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateMin()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //Convert the date variable to a string variable
            string Date = TestDate.ToString();
            //Invoke the method
            OK = AEmail.ValidDate(Date);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateMid()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //Convert the date variable to a string variable
            string Date = TestDate.ToString();
            //Invoke the method
            OK = AEmail.ValidDate(Date);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DateMax()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //Convert the date variable to a string variable
            string Date = TestDate.ToString();
            //Invoke the method
            OK = AEmail.ValidDate(Date);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DateMaxPlusOne()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //Change the date to what ever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //Convert the date variable to a string variable
            string Date = TestDate.ToString();
            //Invoke the method
            OK = AEmail.ValidDate(Date);
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateExtremeMax()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //Change the date to what ever the date is less 100 years
            TestDate = TestDate.AddYears(1);
            //Convert the date variable to a string variable
            string Date = TestDate.ToString();
            //Invoke the method
            OK = AEmail.ValidDate(Date);
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }

        //
        //TEST ID
        //

        [TestMethod]
        public void IDMinMinusOne()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            Int32 ID = 0;
            //Invoke the method
            OK = AEmail.ValidID(ID);
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void IDMin()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            Int32 ID = 1;
            //Invoke the method
            OK = AEmail.ValidID(ID);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void IDMid()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            Int32 ID = 3;
            //Invoke the method
            OK = AEmail.ValidID(ID);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void IDMax()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            Int32 ID = 5;
            //Invoke the method
            OK = AEmail.ValidID(ID);
            //Test to see that the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void IDMaxPlusOne()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            Int32 ID = 6;
            //Invoke the method
            OK = AEmail.ValidID(ID);
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void IDExtremMax()
        {
            //Create an instance of the class we want to create
            clsEmail AEmail = new clsEmail();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to assign to the property
            Int32 ID = 20;
            //Invoke the method
            OK = AEmail.ValidID(ID);
            //Test to see that the result is true
            Assert.IsFalse(OK);
        }
    }
}

