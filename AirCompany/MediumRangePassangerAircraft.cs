
namespace AirCompany
{
    public class MediumRangePassangerAircraft : PassangerAirPlanes
    {
        public MediumRangePassangerAircraft(PassangerModels model) : base(model) { }
        public MediumRangePassangerAircraft() : base()
        {
            rangeFlight = 5500;
        }
        public MediumRangePassangerAircraft(uint capacity, double fuel, uint averageSpeed, double weight, int rangeFlight, PassangerModels passangerModels)
            : base(capacity, fuel, averageSpeed, weight, rangeFlight, passangerModels)
        {
            if (rangeFlight > 5500)
            {
                this.rangeFlight = 5500;
            }
            else
            {
                this.rangeFlight = rangeFlight;
            }
        }
        public override string ToString()
        {
            return $"MediumRangePassengerPlane: {{Model: {this.PassangerModel.ToString()}}}{{Fuel: {fuel}}},{{weight:{weight}}},{{Avarange Speed:{averageSpeed}}}," +
                    $"{{Range:{rangeFlight}}}, {{Capacity:{capacity}}}";
        }

    }

}
