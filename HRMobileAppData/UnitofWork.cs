using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMobileAppData
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly HRMobileAppDBEntities context;

        public UnitOfWork()
        {
            context = new HRMobileAppDBEntities();
        }

        private GenericRepository<TechCategory> techCategoryRepository;
        private GenericRepository<HRQuestion> hrQuestionRepository;

        public GenericRepository<TechCategory> TechCategoryRepository
        {
            get
            {

                if (this.techCategoryRepository == null)
                {
                    this.techCategoryRepository = new GenericRepository<TechCategory>(context);
                }
                return techCategoryRepository;
            }
        }

        public GenericRepository<HRQuestion> HRQuestionRepository
        {
            get
            {

                if (this.hrQuestionRepository == null)
                {
                    this.hrQuestionRepository = new GenericRepository<HRQuestion>(context);
                }
                return hrQuestionRepository;
            }
        }

        public void Save()
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException entityValidationException)
            {
                throw entityValidationException;

            }

        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
