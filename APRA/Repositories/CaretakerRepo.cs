using APRA.Context;
using APRA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace APRA.Repositories {
  public class CaretakerRepo : ICaretakerRepo {

    private ScheduleContext _dbContext;

    public CaretakerRepo() {
      _dbContext = new ScheduleContext();
    }

    public Caretaker GetById(int id) {
      return _dbContext.Caretakers.Find(id);
    }

    public Caretaker GetByPatientId(int patient_id) {
      throw new NotImplementedException();
    }


    public Caretaker Delete(int id) {
      throw new NotImplementedException();
    }

    public Caretaker Add(Models.Caretaker caretaker) {
      throw new NotImplementedException();
    }

    public Caretaker Edit(Models.Caretaker caretaker) {
      throw new NotImplementedException();
    }
  }
}