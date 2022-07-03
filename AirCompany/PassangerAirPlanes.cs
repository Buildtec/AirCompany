
namespace AirCompany
{
    public class PassangerAirPlanes : AirPlanes
    {
        protected uint capacity;
        protected PassangerModels passangerModels;
        public override uint Capacity { get { return capacity; }set { capacity = value; } }
        public PassangerModels PassangerModel { get { return passangerModels; } set { passangerModels = value; } }
        public PassangerAirPlanes() : base() 
        {
            passangerModels = PassangerModels.AN2;
        }
        public PassangerAirPlanes(uint capacity, double fuel, uint averageSpeed, double weight, int rangeFlight, PassangerModels passangerModels)
            : base(fuel, averageSpeed, weight, rangeFlight) 
        {
            this.capacity = capacity;
            this.passangerModels = passangerModels;
        }
        public PassangerAirPlanes(PassangerModels passangerModels) 
        {
            switch (passangerModels)
            {
                case PassangerModels.TU134:
                    capacity = 76;
                    fuel = 14400;
                    averageSpeed = 850;
                    weight = 43000;
                    rangeFlight = 2770;
                    break;
                case PassangerModels.TU124:
                    capacity = 56;
                    fuel = 10500;
                    averageSpeed = 780;
                    weight = 38000;
                    rangeFlight = 2100;
                    break;
                case PassangerModels.AN2:
                    capacity = 12;
                    fuel = 1240;
                    averageSpeed = 180;
                    weight = 5500;
                    rangeFlight = 990;
                    break;
                case PassangerModels.AN10:
                    capacity = 96;
                    fuel = 10780;
                    averageSpeed = 675;
                    weight = 54000;
                    rangeFlight = 2000;
                    break;
                case PassangerModels.Boeing717:
                    capacity = 124;
                    fuel = 16670;
                    averageSpeed = 810;
                    weight = 54885;
                    rangeFlight = 3820;
                    break;
                case PassangerModels.TU144:
                    capacity = 120;
                    fuel = 80000;
                    averageSpeed = 2150;
                    weight = 195000;
                    rangeFlight = 3100;
                    break;
                case PassangerModels.AirbusA320:
                    capacity = 170;
                    fuel = 3190;
                    averageSpeed = 840;
                    weight = 77000;
                    rangeFlight = 6150;
                    break;
                case PassangerModels.EmbraerEJet:
                    capacity = 92;
                    fuel = 16250;
                    averageSpeed = 870;
                    weight = 51800;
                    rangeFlight = 4260;
                    break;
                case PassangerModels.McDonnellDouglasMD80:
                    capacity = 172;
                    fuel = 22100;
                    averageSpeed = 811;
                    weight = 64000;
                    rangeFlight = 2900;
                    break;
                case PassangerModels.SukhoiSuperjet100:
                    capacity = 75;
                    fuel = 15805;
                    averageSpeed = 830;
                    weight = 45880;
                    rangeFlight = 3050;
                    break;
                case PassangerModels.IL96:
                    capacity = 300;
                    fuel = 150000;
                    averageSpeed = 870;
                    weight = 250000;
                    rangeFlight = 9000;
                    break;
                case PassangerModels.TU114:
                    capacity = 180;
                    fuel = 8780;
                    averageSpeed = 770;
                    weight = 164000;
                    rangeFlight = 9720;
                    break;
                case PassangerModels.AirbusA340:
                    capacity = 295;
                    fuel = 141500;
                    averageSpeed = 870;
                    weight = 275000;
                    rangeFlight = 14600;
                    break;
                case PassangerModels.AirbusA380:
                    capacity = 853;
                    fuel = 310000;
                    averageSpeed = 903;
                    weight = 560000;
                    rangeFlight = 15000;
                    break;
                case PassangerModels.Boeing777:
                    capacity = 370;
                    fuel = 117000;
                    averageSpeed = 905;
                    weight = 297560;
                    rangeFlight = 6020;
                    break;
                
            }
            this.passangerModels = passangerModels;

        }
        public override string ToString()
        {
            return $"Passenge Plane: {{Model: {this.PassangerModel.ToString()}}}{{Fuel: {fuel}}},{{weight:{weight}}},{{Avarange Speed:{averageSpeed}}}," +
                $"{{Range:{rangeFlight}}}, {{Capacity:{capacity}}}";
        }

    }
}
