using MedServerAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;

namespace MedServerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicineController : ControllerBase
    {
        private readonly IMedicalService _medicalService;

        public MedicineController(IMedicalService medicalService)
        {
            _medicalService = medicalService;
        }

        [HttpGet]
        public IEnumerable<Medicine> Get()
        {
            return _medicalService.GetMedicines();
        }

        [HttpPost]
        public HttpResponseMessage AddMeds(Medicine medicine)
        {     
            if(!ModelState.IsValid)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            _medicalService.AddMedicine(medicine);

            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        [HttpPut]
        public HttpResponseMessage UpdateMeds(Medicine medicine)
        {
            if (!ModelState.IsValid)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            var result = _medicalService.UpdateMedicine(medicine);

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
