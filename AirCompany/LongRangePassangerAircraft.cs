

namespace AirCompany
{
    internal class LongRangePassangerAircraft : PassangerAirPlanes
    {
        public LongRangePassangerAircraft() : base()
        {
            rangeFlight = int.MaxValue; 
        }
        public LongRangePassangerAircraft(uint capacity, double fuel, uint averageSpeed, double weight, int rangeFlight, PassangerModels passangerModels)
            : base(capacity, fuel, averageSpeed, weight, rangeFlight, passangerModels)
        {
            if (rangeFlight > 17000)
            {
                this.rangeFlight = 17000;
            }
            else
            {
                this.rangeFlight = rangeFlight;
            }

        }
        public LongRangePassangerAircraft(PassangerModels model) : base(model) 
        {

        }
        public override string ToString()
        {

            return $"LongRangePassengerPlane: {{Model: {this.PassangerModel.ToString()}}}{{Fuel: {fuel}}},{{weight:{weight}}},{{Avarange Speed:{averageSpeed}}}," +
                    $"{{Range:{rangeFlight}}}, {{Capacity:{capacity}}}";
        }

    }
}
