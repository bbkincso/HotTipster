using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdvancedProgCA4;
using System.Collections.Generic;
using System.Linq;


namespace UnitTestCA4

{
    [TestClass]
    public class AdvancedProgCA4Test
    {
        private myMethods m;
        private List<Bet> bets;
        

        [TestInitialize]
        public void SetUp() {
            m = new myMethods();
            bets = m.GetAllData();
        }
        // for testing I stored only the hard-coded data in the txt file. 
        // to test methods such as ShowByDate and ShowAllRecords, I used exploratory testing.

        [TestMethod]
        public void TestOfSuccess()
        {
            string expected = "18 won out of 36";

            string result = "";
            string actual = m.Success(result);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestOfMostPopularRaceCourse()
        {
            string expected = "The most popular race course is: " + Environment.NewLine + "Punchestown";

            string result = "";
            string actual = m.MostPopularRaceCourse(result);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestOfHighestWonMostLost()
        {
            string expected = "The highest amount won is: €525.74 and the most lost is: €50.00";

            string result = "";
            string actual = m.HighestWonMostLost(result);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestOfShowTotalsByYear()
        {
            string expected = "Year" + "\tTotal Won" + "\tTotal Lost" + Environment.NewLine
                + "2016" + "\t€431.46"+"\t\t€205.00"+ Environment.NewLine
                + "2017" + "\t€1196.22"+ "\t\t€190.00";

            string result = "";
            string actual = m.ShowTotalsByYear(result);

            Assert.AreEqual(expected, actual);
        }

         [TestMethod]
         public void TestIfNewRecordAdded()
         {
             int count = bets.Count;
             m.AppendData("Aintree", Convert.ToDateTime("05/10/2016"), 75.00m, "false");

             myMethods m2 = new myMethods();

             Assert.AreEqual(count+1, m2.GetAllData().Count());
         }

         [TestMethod]
         public void TestIfAllRecordsAdded()
         {
             int count = bets.Count;
             m.WriteTofile();

             myMethods m2 = new myMethods();

             Assert.AreEqual(count + 36, m2.GetAllData().Count());
         }
    }
}
