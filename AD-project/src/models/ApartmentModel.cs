using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_project.src.models
{
    public class ApartmentModel
    {
        private string id;
        private string building_id;
        private string class_id;
        private string parking_id;
        private string state;
        private int floor_area;
        private double monthly_rent;
        private double reservation_fee;
        private double refundable_deposit;
        private int max_oc_no;

        public ApartmentModel()
        {
        }

        public ApartmentModel(string building_id, string class_id, string parking_id, string state, int floor_area, double monthly_rent, double reservation_fee, double refundable_deposit, int max_oc_no)
        {
            this.Building_id = building_id;
            this.Class_id = class_id;
            this.Parking_id = parking_id;
            this.State = state;
            this.Floor_area = floor_area;
            this.Monthly_rent = monthly_rent;
            this.Reservation_fee = reservation_fee;
            this.Refundable_deposit = refundable_deposit;
            this.Max_oc_no = max_oc_no;
        }

        public ApartmentModel(string id, string building_id, string class_id, string parking_id, string state, int floor_area, double monthly_rent, double reservation_fee, double refundable_deposit, int max_oc_no)
        {
            this.Id = id;
            this.Building_id = building_id;
            this.Class_id = class_id;
            this.Parking_id = parking_id;
            this.State = state;
            this.Floor_area = floor_area;
            this.Monthly_rent = monthly_rent;
            this.Reservation_fee = reservation_fee;
            this.Refundable_deposit = refundable_deposit;
            this.Max_oc_no = max_oc_no;
        }

        public string Id { get => id; set => id = value; }
        public string Building_id { get => building_id; set => building_id = value; }
        public string Class_id { get => class_id; set => class_id = value; }
        public string Parking_id { get => parking_id; set => parking_id = value; }
        public string State { get => state; set => state = value; }
        public int Floor_area { get => floor_area; set => floor_area = value; }
        public double Monthly_rent { get => monthly_rent; set => monthly_rent = value; }
        public double Reservation_fee { get => reservation_fee; set => reservation_fee = value; }
        public double Refundable_deposit { get => refundable_deposit; set => refundable_deposit = value; }
        public int Max_oc_no { get => max_oc_no; set => max_oc_no = value; }
    }
}
