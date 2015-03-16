using APRA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APRA.Repositories {
  interface IPermissionRepo {
    Permission GetByUserId(int userId);
    List<Permission> GetAllByPatientId(int patientId);
    Permission GetByUserIdAndPatientId(int userId, int patientId);
  }
}
