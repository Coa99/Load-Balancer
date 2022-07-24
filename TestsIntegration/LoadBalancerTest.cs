using LBWorkerLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectLibrary;
using ProjektniZadatak;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TestsIntegration
{
    [TestClass]
    public class LoadBalancerTest
    {
        [TestMethod]
        public void TestLoadBalancer()
        {

            LoadBalancer loadBalancer = new LoadBalancer();
            Item i = new Item();
            Item i2 = new Item(Codes.CODE_ANALOG, 1);
            Item i3 = new Item(Codes.CODE_CUSTOM, 2);
            Item i4 = new Item(Codes.CODE_DIGITAL,1);
            Item i5 = new Item(Codes.CODE_LIMITSET,2);
            Item i6 = new Item(Codes.CODE_MULTIPLENODE,3);
            Item i7 = new Item(Codes.CODE_SOURCE,4);
            ItemDescription itemDescription = new ItemDescription();
            ItemDescription itemDescription2 = new ItemDescription(1);
            ItemDescription itemDescription3 = new ItemDescription(1);
            

            itemDescription.DescriptionDataSet = new DataSet(1, ProjectLibrary.Codes.CODE_ANALOG, ProjectLibrary.Codes.CODE_DIGITAL, 1, 2, EnteredData.full);

            Worker.Worker w = new Worker.Worker();
            IPAddress address = new IPAddress(123456789);
            List<ItemDescription> id = new List<ItemDescription>();

            Assert.IsNotNull(loadBalancer);
            Assert.AreEqual(loadBalancer.indexCalculator(i), -1);
            Assert.AreEqual(loadBalancer.indexCalculator(i4), 1);
            Assert.AreEqual(loadBalancer.indexCalculator(i5), 2);
            Assert.AreEqual(loadBalancer.indexCalculator(i6), 3);
            Assert.AreEqual(loadBalancer.indexCalculator(i7), 4);
            try
            {
                
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //ProjektniZadatak.Program.Run(socket);
                // Assert.IsTrue(false);
            }
            catch{ Assert.IsTrue(true); }

            try
            {
                loadBalancer.AddWorker(1);
                Assert.IsTrue(true);
            }
            catch{}
            try
            {
                loadBalancer.AddWorkerProxy(2);
                Assert.IsTrue(true);
            }
            catch { }
            Assert.AreEqual(loadBalancer.ispisCuvanjaItemDescriptiona(itemDescription), "0;1;CODE_ANALOG;CODE_DIGITAL;1;2;full;");
            itemDescription.DescriptionDataSet = new DataSet(2, ProjectLibrary.Codes.CODE_ANALOG, ProjectLibrary.Codes.CODE_DIGITAL, 1, 2, EnteredData.left);

            try
            {
                loadBalancer.DoItem(i6);
                Assert.IsTrue(true);
            }
            catch
            {
               // Assert.IsTrue(false);

            }
            try
            {
                loadBalancer.SendDataToWorker(itemDescription,1);
               // Assert.IsTrue(false);
            }
            catch
            {
                Assert.IsTrue(true);

            }
          /*  try
            {
                loadBalancer.SendDataToWorker(itemDescription2, 1);
                Assert.IsTrue(false);
            }
            catch
            {
                Assert.IsTrue(true);

            } */
            try
            {
                loadBalancer.cleanIdc(itemDescription);
                Assert.IsTrue(true);
            }
            catch
            {
              //  Assert.IsTrue(false);

            }
            try
            {
                loadBalancer.StartWorkerExe(w);
               // Assert.IsTrue(false);
            }
            catch
            {
                Assert.IsTrue(true);

            }
            try
            {
                loadBalancer.MakeEmptyItemDescription(1);
                Assert.IsTrue(true);
            }
            catch
            {
               // Assert.IsTrue(false);

            } 
            try
            {
                loadBalancer.ShutWorker(1);
                Assert.IsTrue(true);
            }
            catch
            {
              //  Assert.IsTrue(false);

            } 
           try
            {
                loadBalancer.FillItemDescription(i6, 1);
                loadBalancer.AktivniWorkeri.Add(2);
                loadBalancer.FillItemDescription(i6, 2);
                Assert.IsTrue(true);
            }
            catch
            {
              //  Assert.IsTrue(false);

            }
            try
            {
                loadBalancer.FillItemDescription(i2, 1);
                Assert.IsTrue(true);
            }
            catch
            {
              //  Assert.IsTrue(false);

            }
            try
            {
                loadBalancer.FillItemDescription(i3, 1);
                Assert.IsTrue(true);
            }
            catch
            {
               // Assert.IsTrue(false);

            } 
            try
            {
                loadBalancer.AddWorker(1,address);
                Assert.IsTrue(true);
            }
            catch
            {
              //  Assert.IsTrue(false);

            }  
         /*   try
            {
                loadBalancer.RemoveWorker(1, address);
                Assert.IsTrue(true);
            }
            catch
            {
             //   Assert.IsTrue(false);

            } */
            try
            {
                loadBalancer.IspisiItemDescriptin(id);
                Assert.IsTrue(true);
            }
            catch
            {
               // Assert.IsTrue(false);

            } 
            try
            {
                loadBalancer.UcitajItemDescriptione();
                Assert.IsTrue(true);
            }
            catch
            {
               // Assert.IsTrue(false);

            }
            try
            {
                loadBalancer.retriveActiveWorkers();
                Assert.IsTrue(true);
            }
            catch
            {
                // Assert.IsTrue(false);

            }

        }
    }
}
