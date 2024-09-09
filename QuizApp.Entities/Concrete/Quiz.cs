using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Entities.Concrete;

public class Quiz : BaseEntity
{
    public string Question { get; set; }
    public List<Answer> Answers { get; set; }
}
