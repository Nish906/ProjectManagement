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

       

        [TestMethod]
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
        }

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

        /*[TestMethod]
        public void TwoAppointmentsPresent()
        {
            //create an instance of a class
            clsAppointmentCollection Appointments = new clsAppointmentCollection();
            //test to see that the two values are the same
            Assert.AreEqual(Appointments.Count, 2);
        }
        */
    }
}
