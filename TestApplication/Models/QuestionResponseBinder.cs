using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IModelBinder = System.Web.ModelBinding.IModelBinder;

namespace TestApplication.Models
{
    public class QuestionResponseBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpRequestBase request = controllerContext.HttpContext.Request;
            
            return new object();
        }
    }
}