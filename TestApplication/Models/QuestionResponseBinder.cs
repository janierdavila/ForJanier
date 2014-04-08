using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime.Tree;
using IModelBinder = System.Web.ModelBinding.IModelBinder;

namespace TestApplication.Models
{
    public class QuestionResponseBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpRequestBase request = controllerContext.HttpContext.Request;
            var form = controllerContext.HttpContext.Request.Form;

            var listQuestionResponse = new List<QuestionResponse> {};


            int i = 0;
            while (!string.IsNullOrEmpty(form["Questions[" + i + "].QuestionName"]))
            {
                var questionResponse = new QuestionResponse()
                {
                    Options = new List<QuestionOptions>() { }
                };
                
                questionResponse.QuestionName = form["Questions[" + i + "].QuestionName"];
                questionResponse.QuestionId = int.Parse(form["Questions[" + i + "].QuestionId"]);
                questionResponse.QuestionCode = form["Questions[" + i + "].QuestionCode"];
                questionResponse.QuestionType = form["Questions[" + i + "].QuestionType"];

                int j = 0;
                while(!string.IsNullOrEmpty(form["Questions["+i+"].Options[" + j +"].OptionDescription"]))
                {
                    var questionOptions = new QuestionOptions(){};
                    questionOptions.OptionDescription = form["Questions[" + i + "].Options[" + j + "].OptionDescription"];
                    questionOptions.OptionId = int.Parse(form["Questions[" + i + "].Options[" + j + "].OptionId"]);
                    questionOptions.OptionName = form["Questions[" + i + "].Options[" + j + "].OptionName"];
                    questionOptions.OptionType = form["Questions[" + i + "].Options[" + j + "].OptionType"];
                    //questionOptions.Selected = bool.Parse(form["Questions[" + i + "].Options[" + j + "].Selected"]);

                    questionResponse.Options.Add(questionOptions);
                    j++;
                }

                listQuestionResponse.Add(questionResponse);
                i++;
            }

            return listQuestionResponse.Count == 0 ? base.BindModel(controllerContext, bindingContext) : listQuestionResponse;
        }
    }
}