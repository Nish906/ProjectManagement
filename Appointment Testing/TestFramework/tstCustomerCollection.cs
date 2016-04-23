using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Customer_Test
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instanc eof class customer collectio
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //check to see the class exist and they are same 
            Assert.IsNotNull(AllCustomers);
        }


        [TestMethod]
        public void CustomerListOK()
        {
            //create an instanc eof class customer collectio
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign the property 
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list 
            //create the items to the list 
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.Age = 22;
            TestItem.FirstName = "Mohammed";
            TestItem.LastName = "Kharodia";
            TestItem.Address = "6 Jellicoe Road";
            TestItem.City = "Leicester";
            TestItem.DateOfBirth = DateTime.Now.Date;
            //TestItem.DateOfBirth = Convert.ToDateTime("18/03/1994");
            TestItem.EmailAddress = "kharodia_14@hotmail.com";
            TestItem.Gender = "Male";
            TestItem.PhoneNumber = 123456789;
            TestItem.PostCode = "LE5 4FN";
            //add the item to test the list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //create an instanc eof class customer  collection
        //    clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //    //Create some test data to assign to the property
        //    Int32 SomeCount;
        //   // create some test data to assign the property 
        //    SomeCount = 3;
        //   // try to send the Address property 
        //    AllCustomers.Count = SomeCount;
        //   // check if the data in the varible and property are the same
        //    Assert.AreEqual(AllCustomers.Count, SomeCount);
        //}

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instanc eof class customer collectio
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign the property 
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list 
            //create the items to the list 
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.Age = 19;
            TestItem.FirstName = "Mariam";
            TestItem.LastName = "Bajahzar";
            TestItem.Address = "94 Brompton Road";
            TestItem.City = "Leicester";
            TestItem.DateOfBirth = DateTime.Now.Date;
            //TestItem.DateOfBirth = Convert.ToDateTime("12/06/1996");
            TestItem.EmailAddress = "masb-114@hotmail.com";
            TestItem.Gender = "female";
            TestItem.PhoneNumber = 784866466;
            TestItem.PostCode = "LE5 1PQ";
            //add the item to test the list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instanc eof class customer  collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign the property 
            clsCustomer TestCustomer = new clsCustomer();
            //set its properties of the test object
            TestCustomer.CustomerID = 1;
            TestCustomer.Age = 19;
            TestCustomer.FirstName = "Mariam";
            TestCustomer.LastName = "Bajahzar";
            TestCustomer.Address = "94 Brompton Road";
            TestCustomer.City = "Leicester";
            TestCustomer.DateOfBirth = DateTime.Now.Date;
            TestCustomer.EmailAddress = "masb-114@hotmail.com";
            TestCustomer.Gender = "female";
            TestCustomer.PhoneNumber = 784866466;
            TestCustomer.PostCode = "LE5 1PQ";
            //Assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of class customer  collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties of the test object
            TestItem.CustomerID = 1;
            TestItem.Age = 20;
            TestItem.FirstName = "Mohammed";
            TestItem.LastName = "Kharodia";
            TestItem.Address = "1 Highfields Road";
            TestItem.City = "Leicester";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.EmailAddress = "kharodia_14@hotmail.com";
            TestItem.Gender = "male";
            TestItem.PhoneNumber = 998244554;
            TestItem.PostCode = "LE5 4FH";
            //set this customer to data
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data 
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        //  [TestMethod]
        //  public void UpdateMethodOK()
        //  {
        ////create an instance of class customer  collection
        //      clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //      //create the item of test data
        //      clsCustomer TestItem = new clsCustomer();
        //      //var to store the primary key 
        //      Int32 PrimaryKey = 0;
        //      //set its properties of the test object
        //      TestItem.CustomerID = 1;
        //      TestItem.Age = 20;
        //      TestItem.FirstName = "Mohammed";
        //      TestItem.LastName = "Kharodia";
        //      TestItem.Address = "1 Highfields Road";
        //      TestItem.City = "Leicester";
        //      TestItem.DateOfBirth =  DateTime.Now.Date;
        //      TestItem.EmailAddress = "kharodia_14@hotmail.com";
        //      TestItem.Gender = "male";
        //      TestItem.PhoneNumber = 998244554;
        //      TestItem.PostCode = "LE5 4FH";
        //      //set this customer to data
        //      AllCustomers.ThisCustomer = TestItem;
        //      //add the record 
        //      PrimaryKey = AllCustomers.Add();
        //      //set the primary key of the test data 
        //      TestItem.CustomerID = PrimaryKey;
        //      //modify the test data
        //       TestItem.CustomerID = 1;
        //      TestItem.Age = 20;
        //      TestItem.FirstName = "Alexis";
        //      TestItem.LastName = "Sanchez";
        //      TestItem.Address = "17 Emirates Road";
        //      TestItem.City = "London";
        //      TestItem.DateOfBirth =  DateTime.Now.Date;
        //      TestItem.EmailAddress = "AlexisSanchez@hotmail.com";
        //      TestItem.Gender = "female";
        //      TestItem.PhoneNumber = 23456789;
        //      TestItem.PostCode = "LE5 134";
        //      //set the record based on the new test
        //      AllCustomers.ThisCustomer = TestItem;
        //      //Update the record
        //      AllCustomers.update();
        //      //find the record
        //      AllCustomers.ThisCustomer.Find(PrimaryKey);
        //      //test to see ThisCustomer matches the test data
        //      Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        //  }



    }
}

