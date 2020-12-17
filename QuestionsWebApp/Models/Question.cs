using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsWebApp.Models
{
    public class Questions
    {

        public int Id { get; set; }
        public string Question { get; set; }
        public string QuestionAnswer { get; set; }

        public Questions()
        {

        }
    }
}
