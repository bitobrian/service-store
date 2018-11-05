using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceStore.Models
{
    public class ServiceTeam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ServiceItem> ServiceItems { get; set; }

        public ServiceTeam()
        {
        }

    }
}
