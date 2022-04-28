//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace S00213942ProjectOOD
//{
//    public class Fork
//    {
//        //Properties of the Bike Frame
//        public int ForkID { get; set; }
//        public string Brand { get; set; }
//        public int Travel { get; set; }
//        public string Discipline { get; set; }
//        public string Description { get; set; }
//        public decimal Price { get; set; }
//        public string ForkImage { get; set; }

//        public override string ToString()
//        {
//            return Brand;

//        }

//        public string GetPartInfo()
//        {
//            return $"Price: {Price:C}            " + $"Travel: {Travel}mm \n" + $"{Description}";
//        }
//    }
//    public class ForkInfo : DbContext
//    {
//        public ForkInfo() : base("EmmetsForks") { }

//        public DbSet<Fork> Forks { get; set; }
//    }
//}
