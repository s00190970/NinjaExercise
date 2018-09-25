using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NinjaDomain.Classes;
using System.Collections.Generic;
using System.Linq;
//using NUnit.Framework;

namespace NinjaTests
{
    [TestClass]
    public class NinjaTests
    {
        [TestMethod]
        public void TestNinja()
        {
            //Ninja n = NinjaConsole.Program.GetNinja(1);
            //Assert.AreEqual(n.Name, "Ninja Paul");
        }

        [TestMethod]
        public void TestNinjaCount()
        {
            //int count = NinjaConsole.Program.GetNinjaList().Count; 
            //Assert.AreEqual(count, 4);
        }

        [TestMethod]
        public void TestNinjaNames()
        {
            //List<string> Ninjas = NinjaConsole.Program.GetNinjaList().Select(n => n.Name).ToList();
            //CollectionAssert.Contains(Ninjas,"Ninja Paul","Ninja Paul not found");
            //CollectionAssert.Contains(Ninjas, "Ninja Fred", "Ninja Fred not found");
            //CollectionAssert.Contains(Ninjas, "Ninja Martha", "Ninja Martha not found");
            //CollectionAssert.Contains(Ninjas, "Ninja Mary", "Ninja Mary not found");
        }


    }
    [TestClass]
    public class NinjaEquipmentTests
    {
        [TestMethod]
        public void TestNinjequipment()
        {

            //List<NinjaEquipment> Equipment = NinjaConsole.Program.GetNinjaEquipmentList(new Ninja { Id = 1 }).ToList();
            //List<string> EquipmentNames = new List<string>() { "Sweet thing", "Comona XL" };
            //foreach (var item in EquipmentNames)
            //{
            //    CollectionAssert.Contains(Equipment.Select(e => e.Name).ToList(), item, item + " not found");
            //}
        }


    }

    [TestClass]
    public class NinjaClanTests
    {
        [TestMethod]
        public void TestClanMembers()
        {
            //List<Clan> clansWithMmmbers = NinjaConsole.Program.GetNinjaClanMemberLists();
            //List<string> NinjasNames = clansWithMmmbers.First().Ninjas.Select(n => n.Name).ToList();
            //Assert.AreEqual(clansWithMmmbers.First().ClanName, "Pauls Clan");
            //CollectionAssert.Contains(NinjasNames, "Ninja Paul", "Ninja Paul not found");
            //CollectionAssert.Contains(NinjasNames, "Ninja Fred", "Ninja Fred not found");
        }
    }


}
