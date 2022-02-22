using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsApp.Controllers
{
    public class Question
    {
        public int ID { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public Question()
        {

        }
    }
}
