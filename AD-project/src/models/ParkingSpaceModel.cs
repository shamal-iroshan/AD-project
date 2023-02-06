using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_project.src.models
{
    public class ParkingSpaceModel
    {
        private string id;
        private double fee;
        private string availability;
        private string apartmentId;
        private int lease_aggrement_id;


        public ParkingSpaceModel()
        {
        }

        public ParkingSpaceModel(double fee, string availability, string apartmentId)
        {
            this.Fee = fee;
            this.Availability = availability;
            this.ApartmentId = apartmentId;
        }

        public ParkingSpaceModel(string id, double fee, string availability, string apartmentId)
        {
            this.Id = id;
            this.Fee = fee;
            this.Availability = availability;
            this.ApartmentId = apartmentId;
        }

        public string Id { get => id; set => id = value; }
        public double Fee { get => fee; set => fee = value; }
        public string Availability { get => availability; set => availability = value; }
        public string ApartmentId { get => apartmentId; set => apartmentId = value; }
        public int Lease_aggrement_id { get => lease_aggrement_id; set => lease_aggrement_id = value; }
    }
}
