using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer TestCustomer = new clsCustomer();
            Assert.IsNotNull(TestCustomer);
        }

        [TestMethod]
        public void AddressOK()
        {
            //create an instance of a class
            clsCustomer NewPage = new clsCustomer();
            //declare testing variable
            Int32 TestData;
            //allocate data into variable
            TestData = 123;
            //pass data to properites within class library
            NewPage.Address = TestData;
            //evaluate the outcome
            Assert.AreEqual(NewPage.Address, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 CustomerNo = 1;
            //Invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerNo = 21;
            //Invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //Check the addressNo
            if (AnCustomer.CustomerNo !=21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestFirstNameNoFound()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            int CustomerNo = 21;
            //Invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //Check the First Name
            if (AnCustomer.FirstName != "Test FirstName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestLastNameNoFound()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            int CustomerNo = 21;
            //Invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //Check the Last Name
            if (AnCustomer.LastName != "Test LastName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCityNoFound()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            int CustomerNo = 21;
            //Invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //Check the City
            if (AnCustomer.City != "Test City")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestEmailAddressNoFound()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            int CustomerNo = 21;
            //Invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //Check the Email Address
            if (AnCustomer.EmailAddress != "Test EmailAddress")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPostCodeNoFound()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            int CustomerNo = 21;
            //Invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //Check the Email Address
            if (AnCustomer.PostCode != "Test PostCode")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void StreetOK()
        {
            //create an instance of a class
            clsCustomer NewPage = new clsCustomer();
            //declare testing variable
            string TestData;
            //allocate data into variable
            TestData = "Street";
            //pass data to properites within class library
            NewPage.Street = TestData;
            //evaluate the outcome
            Assert.AreEqual(TestData, NewPage.Street);
        }

        [TestMethod]
        public void AddressTestMinMinusOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidIntNoData(0);
            //evaluate return value
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void AddressTestMinPlusOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidInt(1);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressTestMaxPlus1()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidInt(1);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressTestMax()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidInt(1);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressTestMid()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidInt(1);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressTestInvalidDataType()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidIntInvalidData("Highfields");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameTestMinBoundary()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("a");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameTestMinPlusOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("aa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameTestMax()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("aaaaaaaaaaaaaaaaaaaaaaaaa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("aaaaaaaaaaaaaaaaaaaaaaaaaa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameTestMinOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("aaaaaaaaaaaaaaaaaaaaaaaa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameTestInvalidDataType()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidStringInvalidData("Mohammed Mohammed Mohammed Mohammed Mohammed Mohammed");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameTestMinBoundary()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("a");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastTestMinPlusOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("aa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameTestMax()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("aaaaaaaaaaaaaaaaaaaaaaaaa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("aaaaaaaaaaaaaaaaaaaaaaaaaa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameTestMinOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("aaaaaaaaaaaaaaaaaaaaaaaa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameTestInvalidDataType()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidStringInvalidData("Kharodia Kharodia Kharodia Kharodia Kharodia Kharodia Kharodia ");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIDTestMinMinusOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidIntNoData(0);
            //evaluate return value
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void CustomerIDTestMinPlusOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidInt(1);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIDTestMaxPlus1()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidInt(1234567892);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIDTestMax()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidInt(1234567891);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIDTestMid()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidInt(12345);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIDTestInvalidDataType()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidIntInvalidData("Cars");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityTestMinBoundary()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("a");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityTestMinPlusOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("aa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityTestMax()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("aaaaaaaaaaaaaaaaaaaaaaaaa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityMaxPlusOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("aaaaaaaaaaaaaaaaaaaaaaaaaa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityTestMinOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("aaaaaaaaaaaaaaaaaaaaaaaa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityTestInvalidDataType()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidStringInvalidData("Arsenal Arsenal Arsenal Arsenal Arsenal Arsenal Arsenal");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressTestMinBoundary()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("a");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressTestMinPlusOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("aa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressTestMax()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("aaaaaaaaaaaaaaaaaaaaaaaaa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("aaaaaaaaaaaaaaaaaaaaaaaaaa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressTestMinOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.Validstring("aaaaaaaaaaaaaaaaaaaaaaaa");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddressTestInvalidDataType()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidStringInvalidData("Car Car Car Car Car Car Car Car");
            //evaluate return value
            Assert.IsTrue(OK);
        }

       
        [TestMethod]
        public void PostCodeTestMinLessOneBoundary()
        {
            //create an instance of a class
            clsCustomer AnAddress = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string HouseNo = "32a";
            string Street = "some street";
            string Town = "Leicester";
            string PostCode = "";
            string DateAdded = "17/9/2015";
            //invoke the method
            OK = AnAddress.Valid(HouseNo, Street, Town, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostCodeTestMinBoundary()
        {
            //create an instance of a class
            clsCustomer AnAddress = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string HouseNo = "32a";
            string Street = "some street";
            string Town = "Leicester";
            string PostCode = "a";
            string DateAdded = Convert.ToString (DateTime.Now.Date);
            //invoke the method
            OK = AnAddress.ValidConvert(HouseNo, Street, Town, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void PostCodeTestMinPlusOneBoundary()
        {
            //create an instance of a class
            clsCustomer AnAddress = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string HouseNo = "32a";
            string Street = "some street";
            string Town = "Leicester";
            string PostCode = "aa";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnAddress.ValidConvert(HouseNo, Street, Town, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void PostCodeTestMaxLessBoundary()
        {
            //create an instance of a class
            clsCustomer AnAddress = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string HouseNo = "32a";
            string Street = "some street";
            string Town = "Leicester";
            string PostCode = "aaaaaaaa";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnAddress.ValidConvert(HouseNo, Street, Town, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void PostCodeTestMaxBoundary()
        {
            //create an instance of a class
            clsCustomer AnAddress = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string HouseNo = "32a";
            string Street = "some street";
            string Town = "Leicester";
            string PostCode = "aaaaaaaaa";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnAddress.ValidConvert(HouseNo, Street, Town, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void PostCodeTestMaxPlusOneBoundary()
        {
            //create an instance of a class
            clsCustomer AnAddress = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string HouseNo = "32a";
            string Street = "some street";
            string Town = "Leicester";
            string PostCode = "aaaaaaaaaa";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnAddress.ValidConvert(HouseNo, Street, Town, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void PostCodeTestMidBoundary()
        {
            //create an instance of a class
            clsCustomer AnAddress = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            string HouseNo = "32a";
            string Street = "some street";
            string Town = "Leicester";
            string PostCode = "aaaa";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnAddress.ValidConvert(HouseNo, Street, Town, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodeTestInvalidDataType()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidStringInvalidData("krt kfrk fdrk frk ksdk sdr");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PhoneNumberTestMinMinusOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidIntNoData(0);
            //evaluate return value
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void PhoneNumberTestMinPlusOne()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidInt(1);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PhoneNumberTestMaxPlus1()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidInt(1);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PhoneNumberTestMax()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidInt(1);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PhoneNumberTestMid()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidInt(1);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PhoneNumberTestInvalidDataType()
        {
            //create an instance of a class
            clsCustomer TestCustomer = new clsCustomer();
            //declare testing variable
            Boolean OK;
            //Pass data to the class library for testing
            OK = TestCustomer.ValidIntInvalidData("Evington");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateAddedTestExtremeMin()
        {
            //Create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //Boolean variable to store the result of the vaidation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Address = "32a";
            string City = "some city";
            string PostCode = "LE1 1AS";
            //Create a variable to store the date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //Convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the method
            OK = AnAddress.Valid(Address, City, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedTestMinLessOne()
        {
            //Create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //Boolean variable to store the result of the vaidation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Address = "32a";
            string City = "some city";
            string PostCode = "LE1 1AS";
            //Create a variable to store the date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //Convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the method
            OK = AnAddress.Valid(Address, City, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedTestMin()
        {
            //Create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //Boolean variable to store the result of the vaidation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Address = "32a";
            string City = "some city";
            string PostCode = "LE1 1AS";
            //Create a variable to store the date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //Convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the method
            OK = AnAddress.Valid(Address, City, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateAddedTestMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //Boolean variable to store the result of the vaidation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Address = "32a";
            string City = "some city";
            string PostCode = "LE1 1AS";
            //Create a variable to store the date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //Convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the method
            OK = AnAddress.Valid(Address, City, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateAddedTestExtremeMax()
        {
            //Create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //Boolean variable to store the result of the vaidation
            Boolean OK = false;
            //Create some test data to pass to the method
            string Address = "32a";
            string City = "some city";
            string PostCode = "LE1 1AS";
            //Create a variable to store the date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //Convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the method
            OK = AnAddress.Valid(Address, City, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

      


     
    }
}