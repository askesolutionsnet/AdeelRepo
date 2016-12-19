using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HRMobileAppBusiness;
using HRMobileAppEntites;

namespace HRMobileApp.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly ITechCategoryService _techcategoryservice;

        public CategoryController(ITechCategoryService techcategoryservice)
        {
            this._techcategoryservice = techcategoryservice;
        }

        // GET: Category
        public IEnumerable<TechCategoryEntity> Get()
        {
            return _techcategoryservice.GetAll();
        }
    }
}