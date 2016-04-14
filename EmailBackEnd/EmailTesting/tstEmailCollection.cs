using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace EmailTesting
{
    [TestClass]
    public class tstEmailCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsEmailCollection AllEmails = new clsEmailCollection();
            //Test to see that it exists
            Assert.IsNotNull(AllEmails);
        }

        [TestMethod]
        public void EmailListOK()
        {
            //Create an instance of the class we want to create
            clsEmailCollection AllEmails = new clsEmailCollection();
            //Create some test data to assign to the property
            List<clsEmail> TestList = new List<clsEmail>();
            //Add item to list
            //Create the item of test data
            clsEmail TestItem = new clsEmail();
            //Set properties
            TestItem.EmailDate = DateTime.Now.Date;
            TestItem.EmailAddress = "joe_bloggs@mail.com";
            TestItem.EmailField = "Hello, can you...";
            TestItem.EmailSubject = "Meetings";
            TestItem.EmailID = 1;
            //Adding item to test list
            TestList.Add(TestItem);
            //Assigning data to property
            AllEmails.EmailList = TestList;
            //Testing to see if two values are same
            Assert.AreEqual(AllEmails.EmailList, TestList);
        }

        [TestMethod]
        public void ThisEmailPropertyOK()
        {
            //Create an instance of the class we want to create
            clsEmailCollection AllEmails = new clsEmailCollection();
            //Create some test data to assign to the property
            clsEmail TestEmail = new clsEmail();
            //Set properties
            TestEmail.EmailDate = DateTime.Now.Date;
            TestEmail.EmailAddress = "joe_bloggs@mail.com";
            TestEmail.EmailField = "Hello, can you...";
            TestEmail.EmailSubject = "Meetings";
            TestEmail.EmailID = 1;
            //Assigning data to property
            AllEmails.ThisEmail = TestEmail;
            //Testing to see if two values are same
            Assert.AreEqual(AllEmails.ThisEmail, TestEmail);
        }

        /*[TestMethod]
        public void CountPropertyOK()
        {
            //Create an instance of the class we want to create
            clsEmailCollection AllEmails = new clsEmailCollection();
            //Create some test data to assign to the property
            Int32 SomeCount = 1;
            //Assign the data to the property
            AllEmails.Count = SomeCount;
            //Test to see that it exists
            Assert.AreEqual(AllEmails.Count, SomeCount);
        }*/

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsEmailCollection AllEmails = new clsEmailCollection();
            //Create some test data to assign to the property
            List<clsEmail> TestList = new List<clsEmail>();
            //Add item to list
            //Create the item of test data
            clsEmail TestItem = new clsEmail();
            //Set properties
            TestItem.EmailDate = DateTime.Now.Date;
            TestItem.EmailAddress = "joe_bloggs@mail.com";
            TestItem.EmailField = "Hello, can you...";
            TestItem.EmailSubject = "Meetings";
            TestItem.EmailID = 1;
            //Adding item to test list
            TestList.Add(TestItem);
            //Assigning data to property
            AllEmails.EmailList = TestList;
            //Testing to see if two values are same
            Assert.AreEqual(AllEmails.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //Create an instance of the class we want to create
            clsEmailCollection AllEmails = new clsEmailCollection();
            //Test to see that it exists
            Assert.AreEqual(AllEmails.Count, 2);
        }

        /*[TestMethod] 
        public void AllEmailsOK()
        {
            //Create an instance of the class we want to create
            clsEmailCollection Emails = new clsEmailCollection();
            //Create some test data to assign to the property, data needs to be in a list
            List<clsEmail> TestList = new List<clsEmail>();
            //Add an item to the list, create the item of the test data
            clsEmail TestItem = new clsEmail();
            //Set its properties
            TestItem.Emails
        }*/
    }
}
