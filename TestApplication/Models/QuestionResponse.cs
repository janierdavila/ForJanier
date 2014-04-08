using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class QuestionResponse
    {
        public int QuestionId;

        public string QuestionType;

        public string QuestionCode;

        public string QuestionName;

        public string OpenResponse;
        
        public List<QuestionOptions> Options;
    }

    public class QuestionOptions
    {
        public int OptionId;

        public string OptionType;

        public string OptionName;

        public string OptionDescription;

        public string OptionResponse;

        public bool Selected;

    }
}