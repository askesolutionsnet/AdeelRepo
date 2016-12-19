using HRMobileAppEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMobileAppBusiness
{
    public interface ITechCategoryService
    {

        TechCategoryEntity GetById(int Id);
        IEnumerable<TechCategoryEntity> GetAll();
        int Create(TechCategoryEntity tEntity);
        bool Update(int Id, TechCategoryEntity tEntity);
        bool Delete(int Id);


    }//end class...
}//end ns...
