using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HRMobileAppEntites;
using HRMobileAppData;

namespace HRMobileAppBusiness
{
    public class HRQuestionService : IHRQuestionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public HRQuestionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<HRQuestionEntity> GetAll()
        {
            var model = _unitOfWork.HRQuestionRepository.GetAll().ToList();
            if (model.Any())
            {
                Mapper.Initialize(cfg => cfg.CreateMap<HRQuestion, HRQuestionEntity>());
                var hrQuestionModel = Mapper.Map<List<HRQuestion>, List<HRQuestionEntity>>(model);
                return hrQuestionModel;
            }
            return null;
        }

        public HRQuestionEntity GetById(int Id)
        {
            var model = _unitOfWork.HRQuestionRepository.GetByID(Id);
            if (model != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<HRQuestion, HRQuestionEntity>());
                var hrQuestionModel = Mapper.Map<HRQuestion, HRQuestionEntity>(model);
                return hrQuestionModel;
            }
            return null;
        }
        public int Create(HRQuestionEntity tEntity)
        {
            throw new NotImplementedException();
        }

        public bool Update(int Id, HRQuestionEntity tEntity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

    }//end class...
}//end ns...
