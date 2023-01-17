using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_project.src.models
{
    public class ApartmentClassModel
    {
        private string id;
        private string title;
        private string description;

        public ApartmentClassModel()
        {
        }

        public ApartmentClassModel(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }

        public ApartmentClassModel(string id, string title, string description)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
        }

        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
    }
}
