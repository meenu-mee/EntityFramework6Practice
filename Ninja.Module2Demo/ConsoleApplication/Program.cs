using NinjaDomain.Classes;
using NinjaDomain.DataModel;
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new NullDatabaseInitializer<NinjaContext>());
            InsertNinja();
            // InsertMultipleNinjas();
            //SimpleNinjaQueries();
            //QueryAndUpdateNinja();
            //DeleteNinja();
            //RetrieveDataWithFind();
            //RetrieveDataWithStoredProc();
            //DeleteNinjaWithKeyValue();
            //DeleteNinjaViaStoredProcedure();
            //QueryAndUpdateNinjaDisconnected();

            //InsertNinjaWithEquipment();
            //SimpleNinjaGraphQuery();
            //ProjectionQuery();
            //QueryAndUpdateNinjaDisconnected();

            //ReseedDatabase();
            Console.ReadKey();
        }

        private static void InsertNinja()
        {
            var ninja = new Ninja
            {
                Name = "SampsonSan",
                ServedInOniwaban = false,
                DateOfBirth = new DateTime(2008, 1, 28),
                ClanId = 1

            };
            using (var context = new NinjaContext()) //insert ninja object to database by instantiating NinjaContext which has DbSet<Ninja> allowing to interact with DB                   
            {
                //context.Database.Log = Console.WriteLine;
                context.Ninjas.Add(ninja); //in Ninjas DbSet(table) in 'context' NinjaContext(DB) add the details on Ninja
                context.SaveChanges();
            }
        }

    }
}
