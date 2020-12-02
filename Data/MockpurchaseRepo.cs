
// using System.Collections.Generic;
// using purchase.Data;
// using purchase.Models;


// namespace purchases.Data
// {
//     public class MockpurchasesRepo : IpurchasesRepo
//     {
//         public IEnumerable<Purchase> GetAppCommands()
//         {
//             var Purchase = new List<Purchase>()
//             {
//                 new Purchase()
//                 {
//                     Id = 0, 
//                     HowTo= "Boil an Egg", 
//                     Line="Boil water", 
//                     Platform = "Kettle & pan"
//                 },
//                 new Purchase()
//                 {
//                     Id = 1,
//                     HowTo= "Cut bread",
//                     Line="Get a knife",
//                     Platform ="Knife and Chopping board"
//                 },
//                 new Purchase() 
//                 {
//                     Id = 2,
//                     HowTo= "Make cup of tea",
//                     Line="Place teabag in cup",
//                     Platform = "Kettle & cup"
//                 }
//             };
//             return Purchase;
//         }

//         public Purchase GetCommandById(int id)
//         {
//             return new Purchase()
//             {
//                 Id = 0, 
//                 HowTo= "Boil an Egg", 
//                 Line="Boil water", 
//                 Platform = "Kettle & pan"
//             };
//         }

//     }
// }