using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestApplication.Models
{
    public class Questionnaire
    {
        private List<QuestionResponse> _questions;

        [UIHint("QuestionResponse")]
        public List<QuestionResponse> Questions
        {
            get { return _questions ?? (_questions = new List<QuestionResponse>()); }
            set { _questions = value; }
        }

        public List<int> Responses;
    }
}