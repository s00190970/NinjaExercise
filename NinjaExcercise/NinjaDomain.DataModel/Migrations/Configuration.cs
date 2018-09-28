namespace NinjaDomain.DataModel.Migrations
{
    using NinjaDomain.Classes;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    

    internal sealed class Configuration : DbMigrationsConfiguration<NinjaDomain.DataModel.NinjaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NinjaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Clans.AddOrUpdate(new Clan[]
            {
                new Clan {Id=1, ClanName="Paul's Clan",Ninjas=new List<Ninja>()
                {
                    new Ninja
                    {
                        Id = 1, DateOfBirth = DateTime.Parse("12/02/2006"),
                        EquipmentOwned = new List<NinjaEquipment>()
                        {
                            new NinjaEquipment { Name = "Sweet thing", Id = 1, Type = EquipmentType.Weapon},
                            new NinjaEquipment {Name = "Comona XL", Id = 2, Type = EquipmentType.Outwear}
                        },
                        Name = "Ninja Paul", ServedInOniwaban = true
                    },
                    new Ninja
                    {
                        Id=2, DateOfBirth = DateTime.Parse("02/02/2000"),
                        EquipmentOwned = new List<NinjaEquipment>()
                        {
                            new NinjaEquipment { Name = "Comona XS", Id = 3, Type = EquipmentType.Outwear}
                        },
                        Name = "Ninja Fred", ServedInOniwaban=false 
                    }
                }

                },
                new Clan {Id =2, ClanName = "Ninja Girls Clan", Ninjas=new List<Ninja>()
                {
                    new Ninja
                    {
                        Id = 3, DateOfBirth = DateTime.Parse("12/02/1900"),
                        EquipmentOwned = new List<NinjaEquipment>()
                        {
                            new NinjaEquipment { Name = "Sour Grapes", Id = 4, Type = EquipmentType.Weapon}
                        },
                        Name = "Ninja Martha", ServedInOniwaban = true
                    },
                    new Ninja
                    {
                        Id=4, DateOfBirth = DateTime.Parse("10/02/1990"),
                        EquipmentOwned = new List<NinjaEquipment>()
                        {
                            new NinjaEquipment { Name = "Fishing Net", Id=5, Type = EquipmentType.Tool}
                        },
                        Name = "Ninja Mary", ServedInOniwaban = true
                    }
                }
                }
            });

        }
    }
}
