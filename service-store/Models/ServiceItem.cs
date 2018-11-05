using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceStore.Models
{
    public class ServiceItem
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //public ServiceTeam ParentTeam { get; set; }
        public bool AllowAttachments { get; set; }

        public ServiceItem()
        {
            Random randomInt = new Random();

            Id = randomInt.Next(10000);
            Title = randomInt.NextDouble().ToString();
            Description = randomInt.NextDouble().ToString();
            AllowAttachments = false;
        }
    }
}
