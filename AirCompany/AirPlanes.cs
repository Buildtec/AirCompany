
namespace AirCompany
{
    public class AirPlanes
    {
        
        protected double fuel;
        protected uint  averageSpeed;
        protected double weight; 
        protected int rangeFlight; 
        
        
        public double Fuel { get { return fuel; } set { fuel = value; } }
        public uint AverageSpeed { get { return averageSpeed; } set { averageSpeed = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
        public int RangeFlight { get { return rangeFlight; } set { rangeFlight = value; } }
        public virtual uint Capacity { get { return 0; } set { } }
        public AirPlanes() 
        {
            
            fuel = 0;
            averageSpeed = 0;   
            weight = 0; 
            rangeFlight = 0;

        }
        public  AirPlanes( double fuel, uint averageSpeed, double weight, int rangeFlight)
        {
           
            this.fuel = fuel;
            this.averageSpeed = averageSpeed;
            this.weight = weight;
            this.rangeFlight = rangeFlight;
            
        }
        public AirPlanes(double fuel, double weight, int rangeFlight)
        {

            this.fuel = fuel;
            this.weight = weight;
            this.rangeFlight = rangeFlight;

        }
        public override string ToString()
        {
            return $"AirPlane: {{Fuel: {fuel}}},{{weight:{weight}}},{{Avarange Speed:{averageSpeed}}},{{Range:{rangeFlight}}}";
        }
    }
}




