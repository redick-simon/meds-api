using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedServerAPI.Model
{
    public interface IMedicalService
    {
        List<Medicine> GetMedicines();
        void AddMedicine(Medicine medicine);
        string UpdateMedicine(Medicine medicine);
    }
}
