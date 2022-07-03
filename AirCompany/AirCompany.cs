using System;

namespace AirCompany
{
    public class AirCompany
    {
        private uint capacity;
        private string companyName;
        public string CompanyName { get { return companyName; } set { companyName = value; } }
        private AirPlanes[] planes;
        public AirPlanes[] Planes { get { return planes; } set { planes = value; } }
        public AirCompany(string companyName = "mycompany", AirPlanes[] planes = null)
        {
            this.companyName = companyName;
            this.planes = planes;
            capacity = 0;
        }
        public uint TotalCapacity() 
        {
            if (capacity == 0)
            {
                uint passangerCapacity = 0;
                foreach (var plane in planes)
                {
                    passangerCapacity += plane.Capacity;
                }
                capacity = passangerCapacity;
            }
            return capacity;
        }
        public void AddPlane(AirPlanes plane)
        {
            Array.Resize(ref this.planes, this.planes.Length + 1);
            this.planes[this.planes.Length - 1] = plane;
            capacity += plane.Capacity;
        }
        public double GetAircrafttWeight() 
        {
            double passangerWeightAircraft = 0;
            foreach (var plane in planes)
            {
                passangerWeightAircraft += plane.Weight;
            }

           
            return passangerWeightAircraft;
        }
        public void Sort() 
        {
            for (int i = 0; i < planes.Length - 1; i++)
            {
                for (int j = i; j < planes.Length; j++)
                {
                    if (planes[i].RangeFlight > planes[j].RangeFlight)
                    {
                        AirPlanes temp = planes[i];
                        planes[i] = planes[j];
                        planes[j] = temp;
                    }
                }
            }
        }

        public AirPlanes Search(double minFuel, double maxFuel)
        {
            foreach (var plane in planes)
            {
                if (plane.Fuel > minFuel && plane.Fuel < maxFuel)
                    return plane;
            }
            return null;
        }

        public void Print()
        {
            foreach (var i in planes)
            {
                Console.WriteLine(i.ToString());
            }
        }


    }
}



