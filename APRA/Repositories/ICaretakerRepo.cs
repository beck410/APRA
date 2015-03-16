using APRA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APRA.Repositories {
  interface ICaretakerRepo {
    Caretaker GetById(int id);
    Caretaker GetByPatientId(int patient_id);
    Caretaker Delete(int id);
    Caretaker Add(Caretaker caretaker);
    Caretaker Edit(Caretaker caretaker);
  }
}
