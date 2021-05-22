using System;
using System.Collections.Generic;
using System.Linq;

namespace MedServerAPI.Model
{
    public class MockMedicalService : IMedicalService
    {
        private readonly List<Medicine> _medicines = new List<Medicine>
        {
            new Medicine
            {
                Name = "Eslo",
                Brand="Nurokind",
                Price = 190.22f,
                Quantity = 100,
                ExpiryDate= new DateTime(2022, 06, 12),
                Notes = "medication used to treat fever and mild to moderate pain"
             },
            new Medicine
            {
                Name = "Trimedor",
                Brand="Nurokind",
                Price = 28.45f,
                Quantity = 70,
                ExpiryDate= new DateTime(2022, 06, 12),
                Notes = "medication used to treat fever and mild to moderate pain"
             },
            new Medicine
            {
                Name = "Paracetamol",
                Brand="Dolo",
                Price = 13.78f,
                Quantity = 200,
                ExpiryDate= new DateTime(2022, 06, 12),
                Notes = "medication used to treat fever and mild to moderate pain"
             }
        };
        public void AddMedicine(Medicine medicine)
        {
            _medicines.Add(medicine);
        }

        public List<Medicine> GetMedicines()
        {
            return _medicines;
        }

        public string UpdateMedicine(Medicine medicine)
        {
            var foundMed = _medicines.FirstOrDefault(m => string.Compare(m.Name, medicine.Name, StringComparison.OrdinalIgnoreCase) ==0);

            if(foundMed != null)
            {
                foundMed = medicine;
                return "Updated";
            }

            return "not found";
        }
    }
}
