using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using HumanResourcesSystem.Business.Abstract;
using HumanResourcesSystem.Business.ValidationRules.FluentValidation;
using HumanResourcesSystem.DataAccess.Abstract;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Concrete
{
    public class SelfHistoryManager : ISelfHistoryService
    {
        private ISelfHistoryDal _selfHistoryDal;
        public SelfHistoryManager(ISelfHistoryDal selfHistoryDal)
        {
            _selfHistoryDal = selfHistoryDal;
        }
        [FluentValidationAspect(typeof(SelfHistoryValidator))]
        public void Add(SelfHistory selfHistory)
        {
            _selfHistoryDal.Add(selfHistory);
        }

        public void Delete(SelfHistory selfHistory)
        {
            _selfHistoryDal.Delete(selfHistory);
        }

        public List<SelfHistory> GetAll()
        {
            return _selfHistoryDal.GetList();
        }

        public SelfHistory GetById(int id)
        {
            return _selfHistoryDal.Get(s => s.Id == id);
        }

        public void Update(SelfHistory selfHistory)
        {
            _selfHistoryDal.Update(selfHistory);
        }
    }
}
