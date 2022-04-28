using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00213942ProjectOOD
{
   public class Frame : IComparable
    {
        //Properties of the Bike Frame
        public int FrameID { get; set; }
        public string Brand { get; set; }
        public string Discipline { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string FrameImage { get; set; }

        public override string ToString()
        {
            return Brand;

        }
        //for the part info textblock
        public string GetPartInfo()
        {
            return $"Price: {Price:C}            " + $"Discipline: {Discipline} \n" + $"{Description}";
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
    public class Fork
    {
        //Properties of the Bike Fork
        public int ForkID { get; set; }
        public string Brand { get; set; }
        public int Travel { get; set; }
        public string Discipline { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string ForkImage { get; set; }

        public override string ToString()
        {
            return Brand;

        }

        public string GetPartInfo()
        {
            return $"Price: {Price:C}            " + $"Travel: {Travel}mm \n" + $"{Description}";
        }
    }
    public class Drivetrain
    {
        //Properties of the Bike Drivetrain
        public int DriveTrainID { get; set; }
        public string Brand { get; set; }
        public int Gears{ get; set; }
        public string Discipline { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string DriveImage { get; set; }

        public override string ToString()
        {
            return Brand;

        }

        public string GetPartInfo()
        {
            return $"Price: {Price:C}            " + $"Gears: {Gears}mm \n" + $"{Description}";
        }
    }


    public class FrameInfo : DbContext
    {//creating and adding to this databae
        public FrameInfo() : base("100%TheLastDatabase") { }

        public DbSet<Frame> Frames { get; set; }
        public DbSet<Fork> Forks { get; set; }
        public DbSet<Drivetrain> Drivetrains { get; set; }
            }

    }
