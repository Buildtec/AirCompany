using System;
namespace AirCompany
{
     class MainClass
    {
        public static void Menu(AirCompany company)
        {
            int c = -1;
            do
            {
                Console.WriteLine("1 - Total Capacity");
                Console.WriteLine("2 - Get the total weight");
                Console.WriteLine("3 - Sorting aircraft by flight range");
                Console.WriteLine("4 - Taircraft search by Fuel");
                Console.WriteLine("0 - Exit");
                c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.WriteLine("Total capacity = " + company.TotalCapacity().ToString());
                        break;
                    case 2:
                        Console.WriteLine("Total weight = " + company.GetAircrafttWeight().ToString());
                        break;
                    case 3:
                        company.Sort();
                        company.Print();
                        break;
                    case 4:
                        Console.WriteLine("Enter range of values for fuel(from 1200 to 350000)");
                        double min = Convert.ToDouble(Console.ReadLine()),
                            max = Convert.ToDouble(Console.ReadLine());
                        var pl = company.Search(min, max);
                        if (pl != null)
                        {
                            Console.WriteLine(pl.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Aircraft not found");
                        }
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Incorrect value. Try again...");
                        break;

                }
            } while (c != 0);
        }
        static void Main(string[] args)
        {
            AirPlanes[] planes = new AirPlanes[11]
             {
                new PassangerAirPlanes(PassangerModels.Boeing777),
                new MilitaryAircraft(MilitaryModels.B2),
                new MilitaryAircraft(MilitaryModels.MIG29),
                new MilitaryAircraft(MilitaryModels.F22),
                new MilitaryAircraft(MilitaryModels.TU160),
                new ShotRangePassangerAircraft(PassangerModels.AN2),
                new MediumRangePassangerAircraft(PassangerModels.AirbusA320),
                new LongRangePassangerAircraft(PassangerModels.Boeing777),
                new ShotRangePassangerAircraft(PassangerModels.AN10),
                new MediumRangePassangerAircraft(PassangerModels.AirbusA340),
                new LongRangePassangerAircraft(PassangerModels.AirbusA380)
                // can add.
             };

            
            AirCompany company = new AirCompany("Belavia", planes);
            
            Menu(company);
            Console.Read();

        }
    }
}
