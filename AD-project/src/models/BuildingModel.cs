using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_project.src.models
{
    public class BuildingModel
    {
        private string id;
        private string location;

        public BuildingModel()
        {
        }

        public BuildingModel(string location)
        {
            this.Location = location;
        }

        public BuildingModel(string id, string location) : this(id)
        {
            this.Location = location;
        }

        public string Id { get => id; set => id = value; }
        public string Location { get => location; set => location = value; }
    }
}
