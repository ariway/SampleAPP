using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using SamuraiAPP.Data;
using SamuraiApp.Domain;

namespace SamuraiApp.Test
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void CanInsertSamuraiIntoDatabase()
        {
           /* using (var context = new SamuraiContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                var samurai = new Samurai() { Name="Musashi"};
                context.Samurais.Add(samurai);
                Debug.WriteLine($"Sebelum save : {samurai.Id}");
                context.SaveChanges();
                Debug.WriteLine($"Setelah save : {samurai.Id}");
                Assert.AreNotEqual(0, samurai.Id);

            } */
        }
        }
    }