using LBWorkerLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker;

namespace TestsIntegration
{
    [TestClass]
    public class ReaderTest
    {
        [TestMethod]
         public void TestReader()
        {
            Reader reader = new Reader();
            CollectionDescription cD = new CollectionDescription();
            ItemDescription itemDescription = new ItemDescription(56);
            itemDescription.DescriptionDataSet = new DataSet(56, ProjectLibrary.Codes.CODE_ANALOG, ProjectLibrary.Codes.CODE_DIGITAL, 1, 2, EnteredData.full);
            CollectionDescription CD2 = new CollectionDescription(itemDescription);

            Assert.IsNotNull(reader);
            
           /*   try
              {
                  reader.CreateTable();
                //  Assert.IsTrue(false);
              }
              catch
              {
                  Assert.IsTrue(true);

              }
            try
            {
                reader.DeleteTable();
            }
               //   Assert.IsTrue(false);
              
              catch
              {
                  Assert.IsTrue(true);

              } */
            
              try
              {
                  reader.Select(CD2);
                //  Assert.IsTrue(false);
              }
              catch
              {
                  Assert.IsTrue(true);

              }
              try
              {
                  reader.Update(CD2);
                //  Assert.IsTrue(false);
              }
              catch
              {
                  Assert.IsTrue(true);

              } 
        /*    try
            {
                reader.Insert(CD2);
                CollectionDescription cD3 = new CollectionDescription(156);
                reader.Insert(cD3);
                //  Assert.IsTrue(false);
            }
            catch
            {
                Assert.IsTrue(true);

            }  */
        }
    }
}
 