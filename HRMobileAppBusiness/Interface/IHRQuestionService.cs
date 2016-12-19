using HRMobileAppEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMobileAppBusiness
{
    public interface IHRQuestionService
    {
        HRQuestionEntity GetById(int Id);
        IEnumerable<HRQuestionEntity> GetAll();
        int Create(HRQuestionEntity tEntity);
        bool Update(int Id, HRQuestionEntity tEntity);
        bool Delete(int Id);

    }//end class...
}//end ns...
