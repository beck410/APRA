using APRA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APRA.Repositories {
  interface IPatientRepo {

    List<Patient> GetPatientsByUserId(int userId);
    Patient GetPatientById(int id);
    Patient Delete(int id);
    Patient Add(Patient patient);
    Patient Edit(Patient patient);
  }
}
