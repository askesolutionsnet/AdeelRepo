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
    public class TechCategoryService : ITechCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TechCategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<TechCategoryEntity> GetAll()
        {
            var model = _unitOfWork.TechCategoryRepository.GetAll().ToList();
            if (model.Any())
            {
                Mapper.Initialize(cfg => cfg.CreateMap<TechCategory, TechCategoryEntity>());
                var techCategoryModel = Mapper.Map<List<TechCategory>, List<TechCategoryEntity>>(model);
                return techCategoryModel;
            }
            return null;
        }

        public TechCategoryEntity GetById(int Id)
        {
            var model = _unitOfWork.TechCategoryRepository.GetByID(Id);
            if (model != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<TechCategory, TechCategoryEntity>());
                var techCategoryModel = Mapper.Map<TechCategory, TechCategoryEntity>(model);
                return techCategoryModel;
            }
            return null;
        }

        public int Create(TechCategoryEntity tEntity)
        {
            throw new NotImplementedException();
        }

        public bool Update(int Id, TechCategoryEntity tEntity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

    }//end class...
}//end ns...