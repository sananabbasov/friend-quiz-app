using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Entities.Concrete;

public class Answer : BaseEntity
{

    public string Option { get; set; }   
    public Guid QuizId { get; set; }
    public Quiz Quiz { get; set; }
}
