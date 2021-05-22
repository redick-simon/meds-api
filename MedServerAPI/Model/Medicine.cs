using System;
using System.ComponentModel.DataAnnotations;

namespace MedServerAPI.Model
{
    public class Medicine
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }
        public string Notes { get; set; }

    }
}
