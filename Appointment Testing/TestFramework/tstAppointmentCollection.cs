using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace TestFramework
{
    [TestClass]
    public class tstAppointmentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            //evaluate class for content
            Assert.IsNotNull(AllAppointments);
        }
                             
        
       /* [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of a class
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            //create some test data to assign to the property
            Int32 SomeAppointment = 2;
            //assign data to property 
            AllAppointments.Count = SomeAppointment;
            //Test to see that the two values are the same 
            Assert.AreEqual(AllAppointments.Count, SomeAppointment);
        } */

        [TestMethod]
        public void ListOfAppointmentsOK()
        {
            //create an instance of a class
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            //create some test data to assign to the property 
            List<clsAppointments> TestList = new List<clsAppointments>();
            //add items to list
            //create the item of test data
            clsAppointments TestItem = new clsAppointments();
            //set its properties
            TestItem.AppointmentID = 2;
            TestItem.AppointmentDetails = "Software Upgrade";
            TestItem.AppointmentDate = Convert.ToDateTime("16/9/2016");
            //add items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAppointments.AppointmentsList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.Count, TestList.Count);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of a class
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            //create some test data to assign to the property 
            List<clsAppointments> TestList = new List<clsAppointments>();
            //add items to list
            //create the item of test data
            clsAppointments TestItem = new clsAppointments();
            //set its properties
            TestItem.AppointmentID = 2;
            TestItem.AppointmentDetails = "Software Upgrade";
            TestItem.AppointmentDate = Convert.ToDateTime("16/9/2016");
            //add items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAppointments.AppointmentsList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.Count, TestList.Count);
        }

        /*[TestMethod]
        public void TwoAppointmentsPresent()
        {
            //create an instance of a class
            clsAppointmentCollection Appointments = new clsAppointmentCollection();
            //test to see that the two values are the same
            Assert.AreEqual(Appointments.Count, 2);
        }
        */

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of a class
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            //create the item of the test data
            clsAppointments TestItem = new clsAppointments();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AppointmentID = 5;
            TestItem.AppointmentDate = Convert.ToDateTime("12/12/2015");
            //set ThisAppointment to the test data
            AllAppointments.ThisAppointment = TestItem;
            //add the record
            PrimaryKey = AllAppointments.Add();
            //set the primary key of the test data
            TestItem.AppointmentID = PrimaryKey;
            //find the record
            AllAppointments.ThisAppointment.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.ThisAppointment, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of a class
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            //create the item of the test data
            clsAppointments TestItem = new clsAppointments();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AppointmentID = 15;
            TestItem.AppointmentDate = Convert.ToDateTime("22/04/2016");
            AllAppointments.ThisAppointment = TestItem;
            //set ThisAppointment to the test data
            PrimaryKey = AllAppointments.Add();
            //set the primary key of the test data
            TestItem.AppointmentID = PrimaryKey;
            //find the record
            AllAppointments.ThisAppointment.Find(PrimaryKey);
            //delete the record
            AllAppointments.Delete();
            //now find the record
            Boolean Found = AllAppointments.ThisAppointment.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
    }
}
