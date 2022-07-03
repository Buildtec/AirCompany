
namespace AirCompany
{
    public class ShotRangePassangerAircraft : PassangerAirPlanes
    {
        public ShotRangePassangerAircraft(PassangerModels model) : base(model) { }
        public ShotRangePassangerAircraft() : base() 
        {
            rangeFlight = 3000; 
        }
        public ShotRangePassangerAircraft(uint capacity, double fuel, uint averageSpeed, double weight, int rangeFlight, PassangerModels passangerModels)
            : base(capacity, fuel, averageSpeed, weight, rangeFlight, passangerModels)
        {
            if (rangeFlight > 3000)
            {
                this.rangeFlight = 3000;
            }
            else
            {
                this.rangeFlight = rangeFlight;
            }
        }
        public override string ToString()
        {
            return $"ShortRangePassengerPlane: {{Model: {this.PassangerModel.ToString()}}}{{Fuel: {fuel}}},{{weight:{weight}}},{{Avarange Speed:{averageSpeed}}}," +
                    $"{{Range:{rangeFlight}}}, {{Capacity:{capacity}}}";
        }

    }
    
}
