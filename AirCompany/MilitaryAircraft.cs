
namespace AirCompany
{
    public class MilitaryAircraft : AirPlanes
    {
        protected int maxSpeed; 
        protected int maxAltitude; 
        protected MilitaryModels militaryModels;
        public int MaxSpeed { get { return maxSpeed; } set { maxSpeed = value; } }
        public int MaximumAltitude { get { return maxAltitude; } set { maxAltitude = value; } }
        public MilitaryModels MilitaryModels { get { return militaryModels; } set { militaryModels = value; } }
        public MilitaryAircraft():base()
        {
            militaryModels = MilitaryModels.TU160;
        }
        public MilitaryAircraft( double fuel, double weight, int rangeFlight, int maxSpeed, int maximumAltitude, MilitaryModels militaryModels) 
            : base(fuel,  weight,  rangeFlight)
        {
            this.maxSpeed = maxSpeed;
            this.maxAltitude = maximumAltitude;  
        }
        public MilitaryAircraft(MilitaryModels militaryModels)
        {
            switch (militaryModels)
            {
                case MilitaryModels.SU27:
                    fuel = 9600;
                    weight = 16380;
                    rangeFlight = 3530;
                    maxSpeed = 2500;
                    maxAltitude = 18000;
                    break;
                case MilitaryModels.MIG29:
                    fuel = 4200;
                    weight = 11000;
                    rangeFlight = 1430;
                    maxSpeed = 2446;
                    maxAltitude = 18013;
                    break;
                case MilitaryModels.F22:
                    fuel = 8200;
                    weight = 27200;
                    rangeFlight = 3000;
                    maxSpeed = 2090;
                    maxAltitude = 18000;
                    break;
                case MilitaryModels.B2:
                    fuel = 73000;
                    weight = 171000;
                    rangeFlight = 11100;
                    maxSpeed = 1010;
                    maxAltitude = 15240;
                    break;
                case MilitaryModels.B52:
                    fuel = 181725;
                    weight = 256735;
                    rangeFlight = 11700;
                    maxSpeed = 820;
                    maxAltitude = 16765;
                    break;
                case MilitaryModels.TU160:
                    fuel = 148000;
                    weight = 275000;
                    rangeFlight = 12300;
                    maxSpeed = 2200;
                    maxAltitude = 16000;
                    break;
               
            }
            this.militaryModels = militaryModels;

        }
        public override string ToString()
        {
            return $"MilitaryPlane: {{Model: {this.militaryModels.ToString()}}}{{Fuel: {fuel}}},{{weight:{weight}}},{{Avarange Speed:{averageSpeed}}}," +
                    $"{{Range:{rangeFlight}}}";
        }

    }
}
