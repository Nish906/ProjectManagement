using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Customer_Test
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instanc eof class customer 
            clsCustomer ACustomer = new clsCustomer();
            //check to see the class exist and they are same 
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instanc eof class customer 
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 CustomerID = 5;
            //Invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see the results is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void CustomerIDTestFound()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable to store the result of the validation
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 2;
            //Invoke the method
            Found = ACustomer.Find(CustomerID);
            //check if the customer id 
            if (ACustomer.CustomerID != 2)
            {
                OK = false;
            }
            //test to see the results is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameTestFound()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable to store the result of the validation
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 1;
            //Invoke the method
            Found = ACustomer.Find(CustomerID);
            //check if the customer id 
            if (ACustomer.FirstName != "Mohammed")
            {
                OK = false;
            }
            //test to see the results is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameTestFound()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable to store the result of the validation
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 1;
            //Invoke the method
            Found = ACustomer.Find(CustomerID);
            //check if the customer id 
            if (ACustomer.LastName != "Kharodia")
            {
                OK = false;
            }
            //test to see the results is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AgeTestFound()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable to store the result of the validation
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 1;
            //Invoke the method
            Found = ACustomer.Find(CustomerID);
            //check if the customer id 
            if (ACustomer.Age != 22)
            {
                OK = false;
            }
            //test to see the results is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void EmailAddressTestFound()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable to store the result of the validation
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerID = 1;
            //Invoke the method
            Found = ACustomer.Find(CustomerID);
            //check if the customer id 
            if (ACustomer.EmailAddress != "kharodia_14@hotmail.com")
            {
                OK = false;
            }
            //test to see the results is correct
            Assert.IsTrue(OK);
        }




        //Testing the properties 

        [TestMethod]
        public void Address()
        {
            //create an instanc eof class customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a varibele to store the the Address 
            string SomeAddress;
            //create some test data to assign the property 
            SomeAddress = "6 Highfields Road";
            //try to send the Address property 
            ACustomer.Address = SomeAddress;
            //check if the data in the varible and property are the same
            Assert.AreEqual(ACustomer.Address, SomeAddress);
        }

        [TestMethod]
        public void Age()
        {
            //create an instanc eof class customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a varibele to store the the Age 
            Int32 SomeAge;
            //create some test data to assign the property 
            SomeAge = 20;
            //try to send the age property 
            ACustomer.Age = SomeAge;
            //check if the data in the varible and property are the same
            Assert.AreEqual(ACustomer.Age, SomeAge);
        }

        [TestMethod]
        public void City()
        {
            //create an instanc eof class customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a varibele to store the the City 
            string SomeCity;
            //create some test data to assign the property 
            SomeCity = "Leicester";
            //try to send the City property 
            ACustomer.City = SomeCity;
            //check if the data in the varible and property are the same
            Assert.AreEqual(ACustomer.City, SomeCity);
        }


        [TestMethod]
        public void CustomerID()
        {
            //create an instanc eof class customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a varibele to store the the CustomerID 
            Int32 SomeID;
            //create some test data to assign the property 
            SomeID = 1;
            //try to send the Customer ID property 
            ACustomer.CustomerID = SomeID;
            //check if the data in the varible and property are the same
            Assert.AreEqual(ACustomer.CustomerID, SomeID);
        }


        [TestMethod]
        public void DateOfBirth()
        {
            //create an instanc eof class customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a varibele to store the the DateOfBirth 
            DateTime SomeDateOfBirth = new DateTime(12 / 06 / 1996);
            //try to send the DOB property 
            ACustomer.DateOfBirth = SomeDateOfBirth;
            //check if the data in the varible and property are the same
            Assert.AreEqual(ACustomer.DateOfBirth, SomeDateOfBirth);
        }

        [TestMethod]
        public void Password()
        {
            //create an instanc eof class customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a varibele to store the the postcode 
            string SomePassword;
            //create some test data to assign the property 
            SomePassword = "LE5 1QW";
            //try to send the postcode property 
            ACustomer.Password = SomePassword;
            //check if the data in the varible and property are the same
            Assert.AreEqual(ACustomer.Password, SomePassword);
        }

        [TestMethod]
        public void PostCode()
        {
            //create an instanc eof class customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a varibele to store the the postcode 
            string SomePostCode;
            //create some test data to assign the property 
            SomePostCode = "LE5 1PQ";
            //try to send the postcode property 
            ACustomer.PostCode = SomePostCode;
            //check if the data in the varible and property are the same
            Assert.AreEqual(ACustomer.PostCode, SomePostCode);
        }

        [TestMethod]
        public void EmailAddress()
        {
            //create an instanc eof class customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a varibele to store the the EmailAddress 
            string SomeEmail;
            //create some test data to assign the property 
            SomeEmail = "kharodia_14@hotmail.com";
            //try to send the EmailAddress property 
            ACustomer.EmailAddress = SomeEmail;
            //check if the data in the varible and property are the same
            Assert.AreEqual(ACustomer.EmailAddress, SomeEmail);
        }


        [TestMethod]
        public void Gender()
        {
            //create an instanc eof class customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a varibele to store the the Ethnicity 
            string SomeGender;
            //create some test data to assign the property 
            SomeGender = "Male";
            //try to send the Gender property 
            ACustomer.Gender = SomeGender;
            //check if the data in the varible and property are the same
            Assert.AreEqual(ACustomer.Gender, SomeGender);
        }


        [TestMethod]
        public void FirstName()
        {
            //create an instanc eof class customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a varibele to store the the FirstName 
            string SomeFirstName;
            //create some test data to assign the property 
            SomeFirstName = "Mohammed";
            //try to send the First Name property 
            ACustomer.FirstName = SomeFirstName;
            //check if the data in the varible and property are the same
            Assert.AreEqual(ACustomer.FirstName, SomeFirstName);
        }


        [TestMethod]
        public void LastName()
        {
            //create an instanc eof class customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a varibele to store the the FirstName 
            string SomeLastName;
            //create some test data to assign the property 
            SomeLastName = "Kharodia";
            //try to send the Last Name property 
            ACustomer.LastName = SomeLastName;
            //check if the data in the varible and property are the same
            Assert.AreEqual(ACustomer.LastName, SomeLastName);
        }


        [TestMethod]
        public void PhoneNumber()
        {
            //create an instanc eof class customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a varibele to store the the FirstName 
            Int32 SomePhoneNumber = 784866466;
            //try to send the phone number property 
            ACustomer.PhoneNumber = SomePhoneNumber;
            //check if the data in the varible and property are the same
            Assert.AreEqual(ACustomer.PhoneNumber, SomePhoneNumber);
        }



        [TestMethod]
        public void ValidMethodOKFirstName()
        {
            //create an instance of a class we want create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeFirstName = "Mohammed";
            //Pass data to the class library for testing
            OK = ACustomer.ValidFirstName(SomeFirstName);
            //evaluate return value
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void FirstNameMinBoundary()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeFirstName = "m";
            //Pass data to the class library for testing
            OK = ACustomer.ValidFirstName(SomeFirstName);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeFirstName = "";
            //Pass data to the class library for testing
            OK = ACustomer.ValidFirstName(SomeFirstName);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeFirstName = "mm";
            //Pass data to the class library for testing
            OK = ACustomer.ValidFirstName(SomeFirstName);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeFirstName = "mmmmmmmmmmmmmmmmmmmm";
            //Pass data to the class library for testing
            OK = ACustomer.ValidFirstName(SomeFirstName);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeFirstName = "mmmmmmmmmmmmmmmmmmm";
            //Pass data to the class library for testing
            OK = ACustomer.ValidFirstName(SomeFirstName);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeFirstName = "mmmmmmmmmmmmmmmmmmmmm";
            //Pass data to the class library for testing
            OK = ACustomer.ValidFirstName(SomeFirstName);
            //evaluate return value
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeFirstName = "mmmmmmmmmm";
            //Pass data to the class library for testing
            OK = ACustomer.ValidFirstName(SomeFirstName);
            //evaluate return value
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeFirstName = "";
            SomeFirstName = SomeFirstName.PadRight(25, 'm');
            //Pass data to the class library for testing
            OK = ACustomer.ValidFirstName(SomeFirstName);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ValidMethodOKLastName()
        {
            //create an instance of a class we want create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeLastName = "Smith";
            //Pass data to the class library for testing
            OK = ACustomer.ValidLastName(SomeLastName);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMinBoundary()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeLastName = "b";
            //Pass data to the class library for testing
            OK = ACustomer.ValidLastName(SomeLastName);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeLastName = "";
            //Pass data to the class library for testing
            OK = ACustomer.ValidLastName(SomeLastName);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeLastName = "bb";
            //Pass data to the class library for testing
            OK = ACustomer.ValidLastName(SomeLastName);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeLastName = "bbbbbbbbbbbbbbbbbbbb";
            //Pass data to the class library for testing
            OK = ACustomer.ValidLastName(SomeLastName);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeLastName = "bbbbbbbbbbbbbbbbbbb";
            //Pass data to the class library for testing
            OK = ACustomer.ValidLastName(SomeLastName);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeLastName = "bbbbbbbbbbbbbbbbbbbbb";
            //Pass data to the class library for testing
            OK = ACustomer.ValidLastName(SomeLastName);
            //evaluate return value
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeLastName = "bbbbbbbbbb";
            //Pass data to the class library for testing
            OK = ACustomer.ValidLastName(SomeLastName);
            //evaluate return value
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeLastName = "";
            SomeLastName = SomeLastName.PadRight(25, 'b');
            //Pass data to the class library for testing
            OK = ACustomer.ValidLastName(SomeLastName);
            //evaluate return value
            Assert.IsFalse(OK);
        }



        [TestMethod]
        public void ValidMethodOKGender()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeGender = "female";
            //Pass data to the class library for testing
            OK = ACustomer.ValidGender(SomeGender);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void GenderMinLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeGender = "mmm";
            //Pass data to the class library for testing
            OK = ACustomer.ValidGender(SomeGender);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void GenderMinPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeGender = "mmmmm";
            //Pass data to the class library for testing
            OK = ACustomer.ValidGender(SomeGender);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void GenderMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeGender = "mmmmmm";
            //Pass data to the class library for testing
            OK = ACustomer.ValidGender(SomeGender);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void GenderMaxLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeGender = "mmmmm";
            //Pass data to the class library for testing
            OK = ACustomer.ValidGender(SomeGender);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void GenderMaxPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeGender = "mmmmmmm";
            //Pass data to the class library for testing
            OK = ACustomer.ValidGender(SomeGender);
            //evaluate return value
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void GenderMid()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeGender = "mmm";
            //Pass data to the class library for testing
            OK = ACustomer.ValidGender(SomeGender);
            //evaluate return value
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void GenderExtremeMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeGender = "mmmmmmmm";
            //Pass data to the class library for testing
            OK = ACustomer.ValidGender(SomeGender);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ValidMethodOKPostCod()
        {
            //create an instance of a class we want create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePostCode = "LE5 1PQ";
            //Pass data to the class library for testing
            OK = ACustomer.ValidPostCode(SomePostCode);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodeMinBoundary()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePostCode = "le5 1pq";
            //Pass data to the class library for testing
            OK = ACustomer.ValidPostCode(SomePostCode);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePostCode = "le5 1p";
            //Pass data to the class library for testing
            OK = ACustomer.ValidPostCode(SomePostCode);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePostCode = "le5 1pqq";
            //Pass data to the class library for testing
            OK = ACustomer.ValidPostCode(SomePostCode);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePostCode = "le5 1pqq";
            //Pass data to the class library for testing
            OK = ACustomer.ValidPostCode(SomePostCode);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePostCode = "le5 1pq";
            //Pass data to the class library for testing
            OK = ACustomer.ValidPostCode(SomePostCode);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePostCode = "le5 1pqqq";
            //Pass data to the class library for testing
            OK = ACustomer.ValidPostCode(SomePostCode);
            //evaluate return value
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePostCode = "le5";
            //Pass data to the class library for testing
            OK = ACustomer.ValidPostCode(SomePostCode);
            //evaluate return value
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePostCode = "le5 1pqqq";
            //Pass data to the class library for testing
            OK = ACustomer.ValidPostCode(SomePostCode);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ValidMethodOKAddress()
        {
            //create an instance of a class we want create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAddress = "152 Mill Lane";
            //Pass data to the class library for testing
            OK = ACustomer.ValidAddress(SomeAddress);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAddress = "1 laz Road";
            //Pass data to the class library for testing
            OK = ACustomer.ValidAddress(SomeAddress);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAddress = "12 Rose Road";
            //Pass data to the class library for testing
            OK = ACustomer.ValidAddress(SomeAddress);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK;
            //create some test data to assign the property 
            string SomeAddress = "12 Sand hills avenue";
            //Pass data to the class library for testing
            OK = ACustomer.ValidAddress(SomeAddress);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAddress = "112 Coloumbine Road";
            //Pass data to the class library for testing
            OK = ACustomer.ValidAddress(SomeAddress);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAddress = "8 sand hills avenue  ";
            //Pass data to the class library for testing
            OK = ACustomer.ValidAddress(SomeAddress);
            //evaluate return value
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void AddressMid()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAddress = "1 Ros Road";
            //Pass data to the class library for testing
            OK = ACustomer.ValidAddress(SomeAddress);
            //evaluate return value
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAddress = "";
            SomeAddress = SomeAddress.PadRight(40, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidAddress(SomeAddress);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ValidMethodOKCity()
        {
            //create an instanc eof class customer 
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeCity = "Leicester";
            //Pass data to the class library for testing 
            OK = ACustomer.ValidCity(SomeCity);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityMinBoundary()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeCity = "a";
            //Pass data to the class library for testing
            OK = ACustomer.ValidCity(SomeCity);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityMinLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeCity = "";
            //Pass data to the class library for testing
            OK = ACustomer.ValidCity(SomeCity);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CityMinPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeCity = "aa";
            //Pass data to the class library for testing
            OK = ACustomer.ValidCity(SomeCity);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeCity = "";
            SomeCity = SomeCity.PadRight(92, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidCity(SomeCity);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityMaxLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeCity = "1 Ros Road";
            SomeCity = SomeCity.PadRight(91, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidCity(SomeCity);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityMaxPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeCity = "1 Ros Road";
            SomeCity = SomeCity.PadRight(93, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidCity(SomeCity);
            //evaluate return value
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void CityMid()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeCity = "";
            SomeCity = SomeCity.PadRight(46, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidCity(SomeCity);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityExtremeMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeCity = "";
            SomeCity = SomeCity.PadRight(95, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidCity(SomeCity);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ValidMethodOKEmailAddress()
        {
            //create an instanc eof class customer 
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeEmail = "kharodia_14@hotmail.com";
            //Pass data to the class library for testing 
            OK = ACustomer.ValidEmail(SomeEmail);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressMinBoundary()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeEmail = "";
            SomeEmail = SomeEmail.PadRight(14, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidEmail(SomeEmail);
            //evaluate return value
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeEmail = "";
            SomeEmail = SomeEmail.PadRight(13, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidEmail(SomeEmail);
            //evaluate return value
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeEmail = "";
            SomeEmail = SomeEmail.PadRight(15, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidEmail(SomeEmail);
            //evaluate return value
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void EmailAddressMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeEmail = "";
            SomeEmail = SomeEmail.PadRight(70, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidEmail(SomeEmail);
            //evaluate return value
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeEmail = "";
            SomeEmail = SomeEmail.PadRight(69, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidEmail(SomeEmail);
            //evaluate return value
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeEmail = "";
            SomeEmail = SomeEmail.PadRight(71, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidEmail(SomeEmail);
            //evaluate return value
            Assert.IsFalse(OK);

        }


        [TestMethod]
        public void EmailAddressMid()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeEmail = "";
            SomeEmail = SomeEmail.PadRight(35, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidEmail(SomeEmail);
            //evaluate return value
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeEmail = "";
            SomeEmail = SomeEmail.PadRight(80, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidEmail(SomeEmail);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ValidMethodOKAge()
        {
            //create an instance of a class we want create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAge = "30";
            //SomeAge = Convert.ToInt32();
            //Pass data to the class library for testing
            OK = ACustomer.ValidAge(SomeAge);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AgeMinBoundary()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAge = "16";
            //Pass data to the class library for testing
            OK = ACustomer.ValidAge(SomeAge);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AgeMinLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAge = "15";
            //Pass data to the class library for testing
            OK = ACustomer.ValidAge(SomeAge);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AgeMinPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAge = "17";
            //Pass data to the class library for testing
            OK = ACustomer.ValidAge(SomeAge);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AgeMaxLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAge = "89";
            //Pass data to the class library for testing
            OK = ACustomer.ValidAge(SomeAge);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AgetMaxPlussOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAge = "91";
            //Pass data to the class library for testing
            OK = ACustomer.ValidAge(SomeAge);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AgeMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAge = "90";
            //Pass data to the class library for testing
            OK = ACustomer.ValidAge(SomeAge);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AgeMid()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAge = "45";
            //Pass data to the class library for testing
            OK = ACustomer.ValidAge(SomeAge);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AgeExtremeMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAge = "95";
            //Pass data to the class library for testing
            OK = ACustomer.ValidAge(SomeAge);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AgeInvalidDatatypes()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomeAge = "asksk";
            //Pass data to the class library for testing
            OK = ACustomer.ValidAge(SomeAge);
            //evaluate return value
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void ValidMethodOKPhoneNumber()
        {
            //create an instance of a class we want create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePhoneNumber = "784866466";
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerPhoneNumber(SomePhoneNumber);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePhoneNumber = "1";
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerPhoneNumber(SomePhoneNumber);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePhoneNumber = "0";
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerPhoneNumber(SomePhoneNumber);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePhoneNumber = "12";
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerPhoneNumber(SomePhoneNumber);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePhoneNumber = "10";
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerPhoneNumber(SomePhoneNumber);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PhoneNumberMaxPlussOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePhoneNumber = "12";
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerPhoneNumber(SomePhoneNumber);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePhoneNumber = "11";
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerPhoneNumber(SomePhoneNumber);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePhoneNumber = "12345";
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerPhoneNumber(SomePhoneNumber);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePhoneNumber = "20";
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerPhoneNumber(SomePhoneNumber);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ValidMethodOKDOB()
        {
            //create an instance of a class we want create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //convert the date varible to string vairble 
            string DateOfBirth = DateTime.Now.Date.ToString();
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerDOB(DateOfBirth);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DOBMin()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create a varible to store the test date data
            DateTime SomeDOB;
            //set the date to todays date
            SomeDOB = DateTime.Now.Date;
            //change the date to date required
            SomeDOB = SomeDOB.AddDays(-01 / 01 / 2000);
            //convert the date varible to string vairble 
            string DateOfBirth = SomeDOB.ToString();
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerDOB(DateOfBirth);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DOBMinLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create a varible to store the test date data
            DateTime SomeDOB;
            //set the date to todays date
            SomeDOB = DateTime.Now.Date;
            //change the date to date required
            SomeDOB = SomeDOB.AddDays(-01 / 01 / 2001);
            //convert the date varible to string vairble 
            string DateOfBirth = SomeDOB.ToString();
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerDOB(DateOfBirth);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DOBMinPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create a varible to store the test date data
            DateTime SomeDOB;
            //set the date to todays date
            SomeDOB = DateTime.Now.Date;
            //change the date to date required
            SomeDOB = SomeDOB.AddDays(-01 / 01 / 1999);
            //convert the date varible to string vairble 
            string DateOfBirth = SomeDOB.ToString();
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerDOB(DateOfBirth);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DOBMaxLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create a varible to store the test date data
            DateTime SomeDOB;
            //set the date to todays date
            SomeDOB = DateTime.Now.Date;
            //change the date to date required
            SomeDOB = SomeDOB.AddDays(-01 / 01 / 1927);
            //convert the date varible to string vairble 
            string DateOfBirth = SomeDOB.ToString();
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerDOB(DateOfBirth);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DOBMaxPlussOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create a varible to store the test date data
            DateTime SomeDOB;
            //set the date to todays date
            SomeDOB = DateTime.Now.Date;
            //change the date to date required
            SomeDOB = SomeDOB.AddDays(-01 / 01 / 1925);
            //convert the date varible to string vairble 
            string DateOfBirth = SomeDOB.ToString();
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerDOB(DateOfBirth);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DOBMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create a varible to store the test date data
            DateTime SomeDOB;
            //set the date to todays date
            SomeDOB = DateTime.Now.Date;
            //change the date to date required
            SomeDOB = SomeDOB.AddDays(-01 / 01 / 1926);
            //convert the date varible to string vairble 
            string DateOfBirth = SomeDOB.ToString();
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerDOB(DateOfBirth);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DOBMid()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create a varible to store the test date data
            DateTime SomeDOB;
            //set the date to todays date
            SomeDOB = DateTime.Now.Date;
            //change the date to date required
            SomeDOB = SomeDOB.AddDays(-01 / 01 / 1971);
            //convert the date varible to string vairble 
            string DateOfBirth = SomeDOB.ToString();
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerDOB(DateOfBirth);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DOBExtremeMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create a varible to store the test date data
            DateTime SomeDOB;
            //set the date to todays date
            SomeDOB = DateTime.Now.Date;
            //change the date to date required
            SomeDOB = SomeDOB.AddDays(-01 / 01 / 1921);
            //convert the date varible to string vairble 
            string DateOfBirth = SomeDOB.ToString();
            //Pass data to the class library for testing
            OK = ACustomer.ValidCustomerDOB(DateOfBirth);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOKPassword()
        {
            //create an instance of a class we want create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePassword = "hytgds";
            //Pass data to the class library for testing
            OK = ACustomer.ValidPassword(SomePassword);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordMinBoundary()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePassword = "hufgda";

            //Pass data to the class library for testing
            OK = ACustomer.ValidPassword(SomePassword);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePassword = "esaxc";
            //Pass data to the class library for testing
            OK = ACustomer.ValidPassword(SomePassword);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePassword = "ghbvcds";
            //Pass data to the class library for testing
            OK = ACustomer.ValidPassword(SomePassword);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePassword = "";
            SomePassword = SomePassword.PadRight(15, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidPassword(SomePassword);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordtMaxPlussOne()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePassword = "";
            SomePassword = SomePassword.PadRight(17, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidPassword(SomePassword);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePassword = "";
            SomePassword = SomePassword.PadRight(16, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidPassword(SomePassword);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePassword = "";
            SomePassword = SomePassword.PadRight(8, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidPassword(SomePassword);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePassword = "";
            SomePassword = SomePassword.PadRight(20, 'a');
            //Pass data to the class library for testing
            OK = ACustomer.ValidPassword(SomePassword);
            //evaluate return value
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PasswordInvalidDatatypes()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //boolean varible to store the results of the validation
            Boolean OK = false;
            //create some test data to assign the property 
            string SomePassword = "//az";
            //Pass data to the class library for testing
            OK = ACustomer.ValidPassword(SomePassword);
            //evaluate return value
            Assert.IsFalse(OK);
        }
    }
}
