using APRA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APRA.Repositories {
  interface IContactRepo {
    List<Contact> GetContactsByPatientId(int patient_id);
    List<Contact> GetById(int id);
    Contact Delete(int id);
    Contact Add(Caretaker contact);
    Contact Edit(Contact contact);

  }
}
