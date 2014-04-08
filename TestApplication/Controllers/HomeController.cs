using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        [HttpGet]
        public ActionResult Questionnaire()
        {
            #region HardCodedDataz
            var questions = new List<QuestionResponse>
            {
                new QuestionResponse
                {
                    QuestionId = 1,
                    OpenResponse = null,
                    QuestionCode = "1",
                    QuestionName = "What kind of movies do you like?",
                    QuestionType = "Checklist",
                    Options = new List<QuestionOptions>
                    {
                        new QuestionOptions
                        {
                            OptionDescription = "Horror",
                            OptionId = 1,
                            OptionName = "Horror",
                            OptionResponse = null,
                            OptionType = "boolean",
                            Selected = false
                        },
                        new QuestionOptions()
                        {
                            OptionDescription = "Family",
                            OptionId = 2,
                            OptionName = "Family",
                            OptionResponse = null,
                            OptionType = "boolean",
                            Selected = false
                        },
                        new QuestionOptions()
                        {
                            OptionDescription = "Comedy",
                            OptionId = 3,
                            OptionName = "Comedy",
                            OptionResponse = null,
                            OptionType = "boolean",
                            Selected = false
                        },
                        new QuestionOptions()
                        {
                            OptionDescription = "Adventure",
                            OptionId = 4,
                            OptionName = "Adventure",
                            OptionResponse = null,
                            OptionType = "boolean",
                            Selected = false
                        },
                        new QuestionOptions()
                        {
                            OptionDescription = "Drama",
                            OptionId = 5,
                            OptionName = "Drama",
                            OptionResponse = null,
                            OptionType = "boolean",
                            Selected = false
                        }
                    }
                },
                new QuestionResponse()
                {
                    QuestionId = 2,
                    OpenResponse = null,
                    QuestionCode = "2",
                    QuestionName = "Which university did you attend in your first year of college?", 
                    QuestionType = "RadioButton",
                    Options = new List<QuestionOptions>
                    {
                        new QuestionOptions()
                        {
                            OptionDescription = "Cornell",
                            OptionId = 1,
                            OptionName = "Cornell",
                            OptionResponse = null,
                            OptionType = "boolean",
                            Selected = false 
                        },
                        new QuestionOptions()
                        {
                            OptionDescription = "Columbia",
                            OptionId = 2,
                            OptionName = "Columbia",
                            OptionResponse = null,
                            OptionType = "boolean",
                            Selected = false 
                        },
                        new QuestionOptions()
                        {
                            OptionDescription = "Harvard",
                            OptionId = 3,
                            OptionName = "Harvard",
                            OptionResponse = null,
                            OptionType = "boolean",
                            Selected = false 
                        },
                        new QuestionOptions()
                        {
                            OptionDescription = "Yale",
                            OptionId = 4,
                            OptionName = "Yale",
                            OptionResponse = null,
                            OptionType = "boolean",
                            Selected = false 
                        },
                        new QuestionOptions()
                        {
                            OptionDescription = "Princeton",
                            OptionId = 5,
                            OptionName = "Princeton",
                            OptionResponse = null,
                            OptionType = "boolean",
                            Selected = false 
                        }
                    }
                }
            };
            #endregion

            var model = new Questionnaire()
            {
                Questions = questions,
                Responses = new List<int>()
            };
            
            return PartialView(model);
        }

        [HttpPost]
        public JsonResult Questionnaire([ModelBinder(typeof(QuestionResponseBinder))]List<QuestionResponse> questions, List<int> responses)
        {
            return Json(new
            {
                success = "some success message",
                error = "some error message"
            });
        }
    }
}