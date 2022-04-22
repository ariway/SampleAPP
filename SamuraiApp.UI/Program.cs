 
//using SamuraiAPP.Data;
//using SamuraiApp.Domain;
//using Microsoft.EntityFrameworkCore;
////AddSamuraiByName
//SamuraiContext _context = new SamuraiContext();
//_context.Database.EnsureCreated();
//AddSamurai("Samurai 3","Samurai 4", "Samurai 5", "Samurai 6");

////AddVaroiusTypes();
////QueryFilters();
////QueryAggregates();
////RetrieveAndUpdateSamurai();
////RetriveAndUpdateMultipleSamurais();
////MultipleDatabaseOperations();
////RetrieveAndDeleteSamurai();
////QueryAndUpdateBattles_Disconnect();
////InsertNewSamuraiWithQuote();
////AddQuoteToExistingSamurai();
////AddQuoteToExistingSamuraiNoTracking(14);
////SimpleAddQuoteToExistingSamuraiNoTracking(16);
////EagerLoadSamuraiWithQuote();
////ProjectingSample();
////ExplicitLoadQuotes();
////FilteringWithRelatedData();
////ModifyRelateddData();
////ModifyRelatedDataNoTracking();
////AddNewSamuraiToBattle();
////BattleWithSamurai();
////AddAllSamuraiToAllBattle();
////RemoveSamuraiFromBattle();
////RemoveSamuraiFromBattleExplicit();
////AddNewSamuraiWithHorse();
////AddNewHorseToSamurai();
////QueryViewBattleStat();
////QueryUsingRawSql();
////QueryUsingSPRaw();
////AddNewInfoSword();
////ElementSword();
//GetSamurais();


Console.WriteLine("Press any key");
Console.ReadLine();


//void AddSamurai(params string[] names)
//{
//    foreach (string name in names)
//    {
//        _context.Samurais.AddAsync(new Samurai { Name = name });

//    }
//    _context.SaveChanges();
//}

//void AddVaroiusTypes()
//{
//    /* _context.Samurais.AddRange(
//         new Samurai { Name = "Kensin" },
//         new Samurai { Name = "Shisio" }
//         );
//     _context.Battles.AddRange(
//         new Battle { Name = "Battle Of Anegawa" },
//         new Battle { Name = "Battle Of Nagasio" }
//         );*/
//    _context.AddRange(new Samurai { Name = "Shinobu" }, new Samurai { Name = "Muichiro" },
//        new Battle { Name = "Battle of District Arc" }, new Battle { Name = "Battle Of Kyoto" });
//    _context.SaveChanges();

//}

//void GetSamurais()
//{
//    var samurais = _context.Samurais
//        .TagWith("Get Samurai Method")
//        .ToList();
//    Console.WriteLine($"Jumlah Samurai Adalah {samurais.Count}");
//    foreach (var samurai in samurais)
//    {
//        Console.WriteLine($"{samurai.Id}-{samurai.Name}");
//    }
//}
//void GetBattles()
//{
//    var battles = _context.Battles.ToList();
//    foreach (var battle in battles)
//    {
//        Console.WriteLine($"{battle.BattleID} - {battle.Name} - {battle.StartDate} - {battle.EndDate}");
//    }
//}
///*void QueryFilters()
//{
//    var samurais = _context.Samurais.Where(s => s.Name == "Rengoku").ToList();
//    var samurais = _context.Samurais.Where(s => s.Name.StartsWith("Tan")).OrderBy(s => s.Name).ToList();
//    var samurais = _context.Samurais.Where(s => EF.Functions.Like(s.Name, "Re%")).ToList();
//    foreach (var samurai in samurais)
//    {
//        Console.WriteLine(samurai.Name);
//    }
//}*/
///*void QueryAggregates()
//{
//    var name = "Rengoku";
//    var samurai =_context.Samurais.FirstOrDefault(s => s.Name==name);
//    /*var samurai = (from s in _context.Samurais
//                  where s.Name==name
//                  select s).FirstOrDefault();
//    var samurai = _context.Samurais.Find(1);
//    Console.WriteLine($"ID {samurai.Id} - Nama {samurai.Name}");
//}*/

//void RetrieveAndUpdateSamurai()
//{
//    var samurai = _context.Samurais.FirstOrDefault(s => s.Id == 1);
//    samurai.Name = "Kyojiro Rengoku";
//    _context.SaveChanges();
//}

//void RetriveAndUpdateMultipleSamurais()
//{
//    var samurais = _context.Samurais.Skip(0).Take(4).ToList();
//    samurais.ForEach(s => s.Name += " San");
//    _context.SaveChanges();
//}

//void MultipleDatabaseOperations()
//{
//    var samurai = _context.Samurais.OrderBy(s => s.Id).LastOrDefault();
//    samurai.Name += " San";
//    _context.Samurais.Add(new Samurai { Name = "Gyomei Himejima" });
//    _context.SaveChanges();
//}

//void RetrieveAndDeleteSamurai()
//{
//    var samurai = _context.Samurais.Find(15);
//    _context.Samurais.Remove(samurai);
//    var samurais = _context.Samurais.Where(s => s.Name.StartsWith("Samurai")).ToList();
//    _context.Samurais.RemoveRange(samurais);
//    _context.SaveChanges();
//}

//void QueryAndUpdateBattles_Disconnects()
//{
//    List<Battle> disconnectedBattles;
//    /* using(var context1 = new SamuraiContextNoTracking())
//     {
//         disconnectedBattles=context1.Battles.AsNoTracking().ToList();
//         disconnectedBattles = context1.Battles.ToList();

//     }//context 1 sudah diproses
//     disconnectedBattles.ForEach(b =>
//     {
//         b.StartDate = new DateTime(1580, 11, 01);
//         b.EndDate = new DateTime(1585, 5, 01);
//     });
//     using(var context2=new SamuraiContext())
//     {
//         context2.UpdateRange(disconnectedBattles);
//         context2.SaveChanges();
//     }*/
//}
//void InsertNewSamuraiWithQuote()
//{
//    var samurai = new Samurai
//    {
//        Name = "Miyamoto Musashi",
//        Quotes = new List<Quote>
//        {
//            new Quote {Text = "Think Lightly of yourself and deeply world"},
//            new Quote {Text = "I do what i want to do"}

//        }

//    };
//    _context.Samurais.Add(samurai);
//    _context.SaveChanges();
//}
//void ElementSword()
//{
//    var samurai = new Samurai
//    {
//        Name = "Miyamoto Musashi",
//        Elements = new List<Element>
//        {
//            new Element {nmelement = "Water"},
//            new Element {nmelement = "Fire"}

//        }

//    };
//    _context.Samurais.Add(samurai);
//    _context.SaveChanges();
//}

//void AddQuoteToExistingSamurai()
//{
//    var samurai = _context.Samurais.Where(s => s.Id == 17).FirstOrDefault();
//    samurai.Quotes.Add(new Quote
//    {
//        Text = "Do not fear about death"
//    });
//    _context.SaveChanges();
//}


//void AddQuoteToExistingSamuraiNoTracking(int samuraiId)
//{
//    var samurai = _context.Samurais.Find(samuraiId);

//    samurai.Quotes.Add(new Quote
//    {
//        Text = "Do not fear abour death"

//    });
//    using (var context1 = new SamuraiContext())
//    {
//        context1.Samurais.Attach(samurai);
//        context1.SaveChanges();
//    }
//}
//void SimpleAddQuoteToExistingSamuraiNoTracking(int samuraiId)
//{
//    var quote = new Quote { Text = "Never stray from the Way", SamuraiId = samuraiId };
//    using (var context1 = new SamuraiContext())
//    {
//        context1.Quotes.Add(quote);
//        context1.SaveChanges();
//    }
//}

//void SwordInfo(int samuraiId)
//{
//    var quote = new Quote { Text = "Never stray from the Way", SamuraiId = samuraiId };
//    using (var context1 = new SamuraiContext())
//    {
//        context1.Quotes.Add(quote);
//        context1.SaveChanges();
//    }
//}

//void EagerLoadSamuraiWithQuote()
//{
//    var samuraiWithQuotes = _context.Samurais.Include(s => s.Quotes).ToList();
//    var splitquery = _context.Samurais.AsSplitQuery().Include(s=>s.Quotes).ToList();
//    var filteredEntity = _context.Samurais.Include(s => s.Quotes.Where(
//     q => q.Text.Contains("fear"))).ToList();
//    /*var filteredEntityInclude = _context.Samurais.Where(s=>s.Name.Contains("San"))
//           .Include(s => s.Quotes).ToList();*/

//    var filterSingle = _context.Samurais.Where(s => s.Id == 1)
//        .Include(s => s.Quotes).FirstOrDefault();
//}
//void ProjectingSample()
//{
//    var results = _context.Samurais.Select(s => new { s.Id, s.Name }).ToList();
//    var idandnameresult=_context.Samurais.Select(s => new IdAndName(s.Id, s.Name)).ToList();
//    /* var resultsWithCount = _context.Samurais.Select(s =>
//     new {s.Id,s.Name,NumofQuote=s.Quotes.Count}).ToList();*/

//    var samuraiAndQuotes = _context.Samurais.Select(s => new
//    {
//        Samurai = s,
//        BestQuote = s.Quotes.Where(q => q.Text.Contains("fear"))
//    }).ToList();
//}
//void ExplicitLoadQuotes()
//{
//    _context.Set<Horse>().Add(new Horse { SamuraiId=1,Name="Yamatomaru" });
//    _context.SaveChanges();
//    _context.ChangeTracker.Clear();

//    var samurai = _context.Samurais.Find(1);
//    _context.Entry(samurai).Collection(s => s.Quotes).Load();
//}
//void FilteringWithRelatedData()
//{
//    var samurais = _context.Samurais.Where(s =>
//    s.Quotes.Any(q => q.Text.Contains("fear"))).ToList();
//}
//void ModifyRelatedData()
//{
//    var samurai = _context.Samurais.Include(s => s.Quotes)
//        .FirstOrDefault(s => s.Id == 38);
//    samurai.Quotes[0].Text = "hello world";
//    _context.Quotes.Remove(samurai.Quotes[1]);
//    _context.SaveChanges();
//}
//void ModifyRelatedDataNoTracking()
//{
//    var samurai = _context.Samurais.Include(s => s.Quotes)
//        .FirstOrDefault(s => s.Id == 38);
//    var quote = samurai.Quotes[0];
//    quote.Text = "hello of core 6.0";

//    using (var context1 = new SamuraiContext())
//    {
//        context1.Quotes.Update(quote);
//        context1.Entry(quote).State = EntityState.Modified;
//        context1.SaveChanges();
//    }
//}
//void AddNewSamuraiToBattle()
//{
//    var battle = _context.Battles.FirstOrDefault();
//    battle.Samurais.Add(new Samurai { Name = "Nobunaga Oda" });
//    _context.SaveChanges();
//}
//void BattleWithSamurai()
//{
//    var battle = _context.Battles.Include(b => b.Samurais).FirstOrDefault(b => b.BattleID == 1);
//    var battles = _context.Battles.Include(b => b.Samurais).ToList();
//}

//void AddAllSamuraiToAllBattle()
//{
//    var allbattles = _context.Battles.ToList();
//    var allsamurais = _context.Samurais.ToList();
//    foreach (var battle in allbattles)
//    {
//        battle.Samurais.AddRange(allsamurais);
//    }
//    _context.SaveChanges();
//}

//void RemoveSamuraiFromBattle()
//{
//    var battleWithSamurai = _context.Battles.Include(b => b.Samurais.Where(s => s.Id == 40))
//        .SingleOrDefault(b => b.BattleID == 1);
//    var samurai = battleWithSamurai.Samurais[0];
//    battleWithSamurai.Samurais.Remove(samurai);
//    _context.SaveChanges();

//}
//void RemoveSamuraiFromBattleExplicit()
//{
//    var battlesamurai = _context.Set<BattleSamurai>()
//        .SingleOrDefault(bs => bs.BattleId == 1 && bs.SamuraiId == 39);
//    if (battlesamurai != null)
//    {
//        _context.Remove(battlesamurai);
//        _context.SaveChanges();
//    }
//}

//void AddNewSamuraiWithHorse()
//{
//    var samurai = new Samurai { Name = "Kensin Himura" };
//    samurai.Horse = new Horse { Name = "Nekochan" };
//    _context.Samurais.Add(samurai);
//    _context.SaveChanges();
//}

//void AddNSwordInfo()
//{
//    var samurai = new Samurai { Name = "Kensin Himura" };
//    samurai.Horse = new Horse { Name = "Nekochan" };
//    _context.Samurais.Add(samurai);
//    _context.SaveChanges();
//}

//void AddNewHorseToSamurai()
//{
//    var horse = new Horse { Name = "Red Hare", SamuraiId = 13 };
//    _context.Add(horse);
//    _context.SaveChanges();

//}


//void AddNewInfoSword()
//{
//    var sword = new SwordInfo { Nama = "SYN", TahunPembuatan= "1560",
//    Berat = "5kg", Id = 13 };
//    _context.Add(sword);
//    _context.SaveChanges();

//}

//void QueryViewBattleStat()
//{/*
//    var results = _context.SamuraiBattleStats.ToList();
//    foreach(var stat in results)
//    {
//        Console.WriteLine($"{stat.Name} - {stat.NumberOfBattles} - {stat.EarliestBattle}");
//    }*/
//    var firststat = _context.SamuraiBattleStats.FirstOrDefault
//        (s => s.Name == "Kensin");
//    Console.WriteLine($"{firststat.Name} - {firststat.NumberOfBattles} -{firststat.EarliestBattle}");
//}

///*void QueryUsingRawSql()
//{
//     var samurais = _context.Samurais.FromSqlRaw("select * from Samurais").ToList();
//    var name = "Kensin";
//    var samurais = _context.Samurais
//        .FromSqlInterpolated($"select * from samurais where Name={name}").ToList();
//}*/

//void QueryUsingSPRaw()
//{
//    var text = "fear";
//    var samurais=_context.Samurais.FromSqlRaw("exec dbo.SamuraisWhoSaidAWord {0}",text).ToList();
//    /* var samurais=_context.Samurais.
//            FromSqlInterpolated($"exec dbo.SamuraisWhoSaidAWord {text}").ToList();*/

//    var samuraiId = "16";
//    _context.Database.ExecuteSqlRaw("exec dbo.DeleteQuotesForSamurai {0}", samuraiId);
//    _context.Database.ExecuteSqlInterpolated($"exec dbo.DeleteQuotesForSamurai {samuraiId}");

//    Console.WriteLine($"Data samurai id {samuraiId} berhasil di delete");
//}

///*void AddSamuraiByName(params string[] names)
//{
//    var bs = new BusinessDataLogic();
//    var newSamuraisCreateCount = bs.AddSamuraiByName(names);

//}*/

//struct IdAndName
//{
//    public IdAndName(int id, string name)
//    {
//        Id = id;
//        Name = name;
//    }
//    public int Id;
//    public string Name;
//}