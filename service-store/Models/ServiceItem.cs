using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceStore.Models
{
    public class ServiceItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool AllowAttachments { get; set; }

        public ServiceItem()
        {
            Random randomInt = new Random();
            Title = randomInt.NextDouble().ToString();
            Description = randomInt.NextDouble().ToString();
            AllowAttachments = false;
        }

        public List<ServiceItem> PreloadServiceItems()
        {
            int rando = new Random().Next(5, 45);
            //Name = "Taco Test Bar";
            var serviceItems = new List<ServiceItem>();
            for (int i = 0; i < rando; i++)
            {
                serviceItems.Add(new ServiceItem());
            }
            return serviceItems;
        }
    }
}
