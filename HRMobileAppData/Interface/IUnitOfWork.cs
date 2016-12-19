using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMobileAppData
{
    public interface IUnitOfWork
    {
        #region Properties
        GenericRepository<TechCategory> TechCategoryRepository { get; }
        GenericRepository<HRQuestion> HRQuestionRepository { get; }
        #endregion

        #region Public methods
        /// <summary>
        /// Save method.
        /// </summary>
        void Save();
        #endregion
    }
}
