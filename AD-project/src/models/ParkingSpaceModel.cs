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

        public ParkingSpaceModel()
        {
        }

        public ParkingSpaceModel(double fee, string availability)
        {
            this.Fee = fee;
            this.Availability = availability;
        }

        public ParkingSpaceModel(string id, double fee, string availability)
        {
            this.Id = id;
            this.Fee = fee;
            this.Availability = availability;
        }

        public string Id { get => id; set => id = value; }
        public double Fee { get => fee; set => fee = value; }
        public string Availability { get => availability; set => availability = value; }
    }
}
