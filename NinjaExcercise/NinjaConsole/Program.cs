using NinjaDomain.Classes;
using NinjaDomain.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1.	Return a ninja for a specified id
            Console.WriteLine("{0} has id {1}", GetNinja(2).Name, 2);
            Console.WriteLine();

            // 2.	Return a list of ninjas and print them out
            foreach (var ninjas in GetNinjaList())
            {
                Console.WriteLine(ninjas.Name);
            }
            Console.WriteLine();

            // 3.	Return a list of the equipment owned by Ninja Paul
            var paulsEquipment = GetNinjaEquipmentList(GetNinja(1));
            foreach (var equipment in paulsEquipment)
            {
                Console.WriteLine(equipment.Name);
            }
            Console.WriteLine();

            // 4.	Return a List of the Clans and their Ninja Members
            var clanList = GetNinjaClanMemberLists();
            foreach (var clan in clanList)
            {
                Console.WriteLine(clan.ClanName);
            }

            
            Console.ReadKey();
        }

        public static Ninja GetNinja(int id)
        {
            using(NinjaContext nc = new NinjaContext())
            {
                return nc.Ninjas.Where(i => i.Id == id).FirstOrDefault();
            }
        }

        public static List<Ninja> GetNinjaList()
        {
            using(NinjaContext nc = new NinjaContext())
            {
                return nc.Ninjas.ToList();
            }
        }

        public static List<NinjaEquipment> GetNinjaEquipmentList(Ninja ninja)
        {
            using(NinjaContext nc = new NinjaContext())
            {
                return nc.Equipment.Where(e => e.Ninja.Id == ninja.Id).ToList();
            }
        }
        public static List<Clan> GetNinjaClanMemberLists()
        {
            using(NinjaContext nc = new NinjaContext())
            {
                return nc.Ninjas.Select(n => n.Clan).Distinct().ToList();
            }
        }
    }
}
