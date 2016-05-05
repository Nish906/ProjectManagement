using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace UnitTestProject1Payment
{
    [TestClass]
    public class PaymentTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //evaluate class for content
            Assert.IsNotNull(TestPayment);
        }

        [TestMethod]
        public void PayNoOK()
        {
            //create an instance of a class
            clsPayment NewPage = new clsPayment();
            //declare testing variable
            Int32 TestData;
            //allocate data into variable
            TestData = 123;
            //pass data to properites within class library
            NewPage.PayNo = TestData;
            //evaluate the outcome
            Assert.AreEqual(TestData, NewPage.PayNo);
        }

        [TestMethod]
        public void JobIDOK()
        {
            //create an instance of a class
            clsPayment NewPage = new clsPayment();
            //declare testing variable
            Int32 TestData;
            //allocate data into variable
            TestData = 123;
            //pass data to properites within class library
            NewPage.JobID = TestData;
            //evaluate the outcome
            Assert.AreEqual(TestData, NewPage.JobID);
        }

        [TestMethod]
        public void CurTypeOK()
        {
            //create an instance of a class
            clsPayment NewPage = new clsPayment();
            //declare testing variable
            string TestData;
            //allocate data into variable
            TestData = "Pounds";
            //pass data to properites within class library
            NewPage.CurType = TestData;
            //evaluate the outcome
            Assert.AreEqual(TestData, NewPage.CurType);
        }

        [TestMethod]
        public void TotalCostOK()
        {
            //create an instance of a class
            clsPayment NewPage = new clsPayment();
            //declare testing variable
            Int32 TestData;
            //allocate data into variable
            TestData = 123;
            //pass data to properites within class library
            NewPage.TotalCost = TestData;
            //evaluate the outcome
            Assert.AreEqual(TestData, NewPage.TotalCost);
        }

        [TestMethod]
        public void CompdateOK()
        {
            //create an instance of a class
            clsPayment NewPage = new clsPayment();
            //declare testing variable
            DateTime TestData;
            //allocate data into variable
            TestData = new DateTime(2001, 01, 01);
            //pass data to properites within class library
            NewPage.Compdate = TestData;
            //evaluate the outcome
            Assert.AreEqual(TestData, NewPage.Compdate);
        }

        [TestMethod]
        public void PaydateOK()
        {
            //create an instance of a class
            clsPayment NewPage = new clsPayment();
            //declare testing variable
            DateTime TestData;
            //allocate data into variable
            TestData = new DateTime(2001, 01, 01);
            //pass data to properites within class library
            NewPage.Paydate = TestData;
            //evaluate the outcome
            Assert.AreEqual(TestData, NewPage.Paydate);
        }

        [TestMethod]
        public void PayTypeOK()
        {
            //create an instance of a class
            clsPayment NewPage = new clsPayment();
            //declare testing variable
            string TestData;
            //allocate data into variable
            TestData = "Visa Direct Debit";
            //pass data to properites within class library
            NewPage.PayType = TestData;
            //evaluate the outcome
            Assert.AreEqual(TestData, NewPage.PayType);
        }

        [TestMethod]
        public void CardNoOK()
        {
            //create an instance of a class
            clsPayment NewPage = new clsPayment();
            //declare testing variable
            Int32 TestData;
            //allocate data into variable
            TestData = 123;
            //pass data to properites within class library
            NewPage.CardNo = TestData;
            //evaluate the outcome
            Assert.AreEqual(TestData, NewPage.CardNo);
        }

        [TestMethod]
        public void PaymentNoTestExtremeMin()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidIntNoData(-2147483648);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentNoTestMinMinusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidIntNoData(0);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentNoTestMinBoundary()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(1);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentNoTestMinPlusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(2);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentNoTestMaxMinusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(2147483646);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentNoTestMaxBoundary()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(2147483647);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentNoTestMid()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(1013741824);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentNoTestExtremeMax()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidString("VisaDirectDebit VisaDirectDebit");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentNoTestInvalidDataType()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidIntInvalidData("VisaDirectDebit VisaDirectDebit VisaDirectDebit VisaDirectDebit VisaDirectDebit VisaDirectDebit VisaDirectDebit VisaDirectDebit");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentNoTestOtherTests()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidIntInvalidData("Burger_King_4294967296");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentTypeTestMinBoundary()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidString("V");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentTypeTestMinPlusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidString("Vi");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentTypeTestMaxMinusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidString("VisaDirectDebi");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentTypeTestMaxBoundary()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidString("VisaDirectDebit");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentTypeTestMaxPlusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidStringInvalidData("VisaDirectDebits");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentTypeTestMid()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidString("VisaDire");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentTypeTestExtremeMax()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidStringInvalidData("VisaDirectDebit VisaDirectDebit");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentTypeTestInvalidDataType()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidStringInvalidData("VisaDirectDebit VisaDirectDebit VisaDirectDebit VisaDirectDebit VisaDirectDebit VisaDirectDebit VisaDirectDebit VisaDirectDebit");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaymentTypeTestOtherTests()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidStringInvalidData("VisaDirectDebit 123456");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CurTypeTestMinBoundary()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidString("V");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CurTypeTestMinPlusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidString("Vi");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CurTypeTestMaxMinusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidString("VisaDirectDebi");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CurTypeTestMaxBoundary()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidString("VisaDirectDebit");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CurTypeTestMaxPlusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidStringInvalidData("VisaDirectDebits");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CurTypeTestMid()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidString("VisaDire");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CurTypeTestExtremeMax()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidStringInvalidData("VisaDirectDebit VisaDirectDebit");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CurTypeTestInvalidDataType()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidStringInvalidData("VisaDirectDebit VisaDirectDebit VisaDirectDebit VisaDirectDebit VisaDirectDebit VisaDirectDebit VisaDirectDebit VisaDirectDebit");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CurTypeTestOtherTests()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidStringInvalidData("VisaDirectDebit 123456");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void JobIDTestExtremeMin()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidIntNoData(-2147483648);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void JobIDTestMinMinusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidIntNoData(0);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void JobIDTestMinBoundary()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(1);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void JobIDTestMinPlusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(2);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void JobIDTestMaxMinusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(2147483646);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void JobIDTestMaxBoundary()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(2147483647);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void JobIDTestMid()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(1013741824);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void JobIDTestInvalidDataType()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidIntInvalidData("Burger_King");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void JobIDTestOtherTests()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidIntInvalidData("Burger_King_4294967296");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TotalCostTestExtremeMin()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidIntNoData(-2147483648);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TotalCostTestMinMinusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidIntNoData(0);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TotalCostMinBoundary()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(1);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TotalCostTestMinPlusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(2);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TotalCostTestMaxMinusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(2147483646);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TotalCostTestMaxBoundary()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(2147483647);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TotalCostTestMid()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(1013741824);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TotalCostTestInvalidDataType()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidIntInvalidData("Burger_King");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TotalCostTestOtherTests()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidIntInvalidData("Burger_King_4294967296");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardNoTestExtremeMin()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidIntNoData(-2147483648);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardNoTestMinMinusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidIntNoData(0);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardNoTestMinBoundary()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(1);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardNoTestMinPlusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(2);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardNoTestMaxMinusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(2147483646);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardNoTestMaxBoundary()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(2147483647);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardNoTestMid()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidInt(1013741824);
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardNoTestInvalidDataType()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidIntInvalidData("Burger_King");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CardNoTestOtherTests()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidIntInvalidData("Burger_King_4294967296");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompdateTestExtremeMin()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDateNoData("01/01/-10000");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompdateTestMinMinusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDateNoData("31/12/-0001");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompdateTestMinBoundary()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDate("01/01/0001");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompdateTestMinPlusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDate("02/01/2001");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompdateTestMaxMinusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDate("30/12/9999");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompdateTestMaxBoundary()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDate("31/12/9999");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompdateInvalidTestMaxPlusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDateInvalidData("01/01/10000");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompdateTestMid()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDate("01/06/4999");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompdateTestExtremeMax()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDateInvalidData("01/01/9999999999");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompdateTestInvalidDataType()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDateInvalidData("01/01/9999999999");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompdateTestOtherTests()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDateInvalidData("01012000");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaydateTestExtremeMin()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDateNoData("01/01/-10000");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaydateTestMinMinusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDateNoData("31/12/-0001");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaydateTestMinBoundary()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDate("01/01/0001");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaydateTestMinPlusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDate("02/01/2001");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaydateTestMaxMinusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDate("30/12/9999");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaydateTestMaxBoundary()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDate("31/12/9999");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaydateInvalidTestMaxPlusOne()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDateInvalidData("01/01/10000");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaydateTestMid()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDate("01/06/4999");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaydateTestExtremeMax()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDateInvalidData("01/01/9999999999");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaydateInvalidDataType()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDateInvalidData("01012000");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PaydateTestOtherTests()
        {
            //create an instance of a class
            clsPayment TestPayment = new clsPayment();
            //declare testing variable
            Boolean OK;
            //pass data to the class library for testing
            OK = TestPayment.ValidDateInvalidData("00020101");
            //evaluate return value
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of a class
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create an instance of a class
            clsPayment APaymentTest = new clsPayment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            APaymentTest.PayNo = 1;
            APaymentTest.JobID = 1;
            APaymentTest.CurType = "1";
            APaymentTest.Paydate = new DateTime(2001, 01, 01);
            APaymentTest.Compdate = new DateTime(2001, 01, 01);
            APaymentTest.PayType = "1";
            APaymentTest.CardNo = 1;
            //set the ThisPayment to the test data
            AllPayments.ThisPayment = APaymentTest;
            //add the record
            PrimaryKey = AllPayments.InsertPayment();
            //set the primary key of the test data
            APaymentTest.PayNo = PrimaryKey;
            //find the record
            AllPayments.ThisPayment.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.ThisPayment, APaymentTest);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of a class
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create an instance of a class
            clsPayment APaymentTest = new clsPayment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            APaymentTest.PayNo = 1;
            APaymentTest.JobID = 1;
            APaymentTest.CurType = "1";
            APaymentTest.Paydate = new DateTime(2001, 01, 01);
            APaymentTest.Compdate = new DateTime(2001, 01, 01);
            APaymentTest.PayType = "1";
            APaymentTest.CardNo = 1;
            //set the ThisPayment to the test data
            AllPayments.ThisPayment = APaymentTest;
            //add the record
            PrimaryKey = AllPayments.InsertPayment();
            //set the primary key of the test data
            APaymentTest.PayNo = PrimaryKey;
            //modify the test data
            APaymentTest.JobID = 2;
            APaymentTest.CurType = "2";
            APaymentTest.Paydate = new DateTime(2002, 02, 02);
            APaymentTest.Compdate = new DateTime(2002, 02, 02);
            APaymentTest.PayType = "2";
            APaymentTest.CardNo = 2;
            //set the ThisPayment to the test data
            AllPayments.ThisPayment = APaymentTest;
            //update the record
            AllPayments.UpdatePayment();
            //find the record
            AllPayments.ThisPayment.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.ThisPayment, APaymentTest);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of a class
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create an instance of a class
            clsPayment APaymentTest = new clsPayment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            APaymentTest.PayNo = 1;
            APaymentTest.JobID = 1;
            APaymentTest.CurType = "1";
            APaymentTest.Paydate = new DateTime(2001, 01, 01);
            APaymentTest.Compdate = new DateTime(2001, 01, 01);
            APaymentTest.PayType = "1";
            APaymentTest.CardNo = 1;
            //set the ThisPayment to the test data
            AllPayments.ThisPayment = APaymentTest;
            //add the record
            PrimaryKey = AllPayments.InsertPayment();
            //set the primary key of the test data
            APaymentTest.PayNo = PrimaryKey;
            //set the ThisPayment to the test data
            AllPayments.ThisPayment = APaymentTest;
            //update the record
            AllPayments.DeletePayment();
            //find the record
            Boolean Found = AllPayments.ThisPayment.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }
    }
}
