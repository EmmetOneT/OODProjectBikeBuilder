using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using S00213942ProjectOOD;

namespace ProjectManager
{
    class Program
    {
        static void Main(string[] args)
        {
            FrameInfo db = new FrameInfo();
            //ForkInfo db = new ForkInfo();


            using (db)

            {
                //These are the Frames for the database
                //These are the Frames for the database
                //These are the Frames for the database 
                Frame f1 = new Frame()
                {
                    Brand = "Commencal",
                    Discipline = "Cross Country",
                    Description = "Perfect for long cycles in the countryside or on forest fireroads",
                    Price = 500,
                    FrameImage = "/images/Commencal.jpg"

                };
                Frame f2 = new Frame()
                {
                    Brand = "Cube",
                    Discipline = "Trail",
                    Description = "The bike for small jumps and coquering rocks and roots",
                    Price = 800,
                    FrameImage = "/images/Cube.jpg"
                };
                Frame f3 = new Frame()
                {
                    Brand = "Nukeproof",
                    Discipline = "Downhill",
                    Description = "Huge jumps and descents are what these bikes were built for",
                    Price = 1050,
                    FrameImage = "/images/Nukeproof.jpg"
                };
                db.Frames.Add(f1);
                db.Frames.Add(f2);
                db.Frames.Add(f3);

                {
                    //These are the Forks for the database
                    //These are the Forks for the database
                    //These are the Forks for the database
                    Fork fk1 = new Fork()
                    {
                        Brand = "Fox XC",
                        Travel = 100,
                        Discipline = "Cross Country",
                        Description = "Great for the budget minded cross country rider. Lock out installed on the uppers",
                        Price = 300,
                        ForkImage = "/images/Fox100.jpg"

                    };
                    Fork fk2 = new Fork()
                    {
                        Brand = "RockShox XC",
                        Travel = 100,
                        Discipline = "Cross Country",
                        Description = "Great quality 100mm fork. Used for steep climbs with a lockout installed on the lowers.",
                        Price = 280,
                        ForkImage = "/images/Rockshox100.jpg"

                    };
                    Fork fk3 = new Fork()
                    {
                        Brand = "Marzocchi XC",
                        Travel = 120,
                        Discipline = "Cross Country",
                        Description = "More travel than the other options for a comfy ride on gravel and fireroads.",
                        Price = 360,
                        ForkImage = "/images/Marzocchi120.jpg"

                    };
                    Fork fk4 = new Fork()
                    {
                        Brand = "Fox Trail",
                        Travel = 150,
                        Discipline = "Trail",
                        Description = "Perfect entry fork for trail riders. This fork has no issues sucking up rocks and roots",
                        Price = 670,
                        ForkImage = "/images/Fox150.jpg"

                    };
                    Fork fk5 = new Fork()
                    {
                        Brand = "Marzocchi Trail",
                        Travel = 160,
                        Discipline = "Trail",
                        Description = "This 160mm fork makes short work of jumps and gravity sections of trail.",
                        Price = 800,
                        ForkImage = "/images/marzocchi160.jpg"

                    };
                    Fork fk6 = new Fork()
                    {
                        Brand = "RockShox Trail",
                        Travel = 160,
                        Discipline = "Trail",
                        Description = "It doesnt get much better than this fork for a trail bike. Itll give you all the confidece youll need.",
                        Price = 820,
                        ForkImage = "/images/rockshox160.jpg"
                    };
                    Fork fk7 = new Fork()
                    {
                        Brand = "Fox DH",
                        Travel = 200,
                        Discipline = "Downhill",
                        Description = "Used by professionals. Big descents and huge jumps are all in the lineup for this for. Adjustable rebound on lower",
                        Price = 1500,
                        ForkImage = "/images/fox200.jpg"

                    };
                    Fork fk8 = new Fork()
                    {
                        Brand = "RockShox DH",
                        Travel = 200,
                        Discipline = "Downhill",
                        Description = "Used by professionals. Big descents and huge jumps are all in the lineup for this for. Adjustable rebound on uppers",
                        Price = 1450,
                        ForkImage = "/images/rockshox200.jpg"

                    };

                    db.Forks.Add(fk1);
                    db.Forks.Add(fk2);
                    db.Forks.Add(fk3);
                    db.Forks.Add(fk4);
                    db.Forks.Add(fk5);
                    db.Forks.Add(fk6);
                    db.Forks.Add(fk7);
                    db.Forks.Add(fk8);


                    {
                        //These are the Drivetrains for the database
                        //These are the Drivetrains  for the database
                        //These are the Drivetrains  for the database
                        Drivetrain d1 = new Drivetrain()
                        {
                            Brand = "Shimano XC",
                            Gears = 12,
                            Discipline = "Cross Country",
                            Description = "This is the perfect drivetrain for beginner cross country riders.",
                            Price = 490,
                            DriveImage = "/images/shimano.jpg"

                        };
                        Drivetrain d2 = new Drivetrain()
                        {
                            Brand = "Sram XC",
                            Gears = 18,
                            Discipline = "Cross Country",
                            Description = "With 2 front chainrings for a classic 2x9 setup, this drivetrain is perfect for steep uphills",
                            Price = 690,
                            DriveImage = "/images/sram18.jpg"

                        };
                        Drivetrain d3 = new Drivetrain()
                        {
                            Brand = "Sram 11",
                            Gears = 11,
                            Discipline = "Trail",
                            Description = "Short gear ratio for descents. With great build quality, feel confident in hitting jumps.",
                            Price = 600,
                            DriveImage = "/images/sram11.jpg"

                        };
                        Drivetrain d4 = new Drivetrain()
                        {
                            Brand = "Deore Trail",
                            Gears = 9,
                            Discipline = "Trail",
                            Description = "With a wide range of sprocket sizes, this is the perfect drivetrain for flat cycles and desscents",
                            Price = 670,
                            DriveImage = "/images/deore9.jpg"

                        };
                        Drivetrain d5 = new Drivetrain()
                        {
                            Brand = "Shimano DH",
                            Gears = 9,
                            Discipline = "Downhill",
                            Description = "Built for downhill, this short gear ratio drivetrain will help you get the perfect gear for a descent",
                            Price = 680,
                            DriveImage = "/images/shimano9.jpg"

                        };
                        Drivetrain d6 = new Drivetrain()
                        {
                            Brand = "Sram DH",
                            Gears = 10,
                            Discipline = "Downhill",
                            Description = "Built for downhill, this short gear ratio drivetrain will help you get the perfect gear for a descent",
                            Price = 780,
                            DriveImage = "/images/sram10.jpg"
                        };



                        db.Drivetrains.Add(d1);
                        db.Drivetrains.Add(d2);
                        db.Drivetrains.Add(d3);
                        db.Drivetrains.Add(d4);
                        db.Drivetrains.Add(d5);
                        db.Drivetrains.Add(d6);
                    }

                }



            }
        }
    }
}
    




