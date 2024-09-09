using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Entities.Concrete;

public class UserAnswer : BaseEntity
{
    public Guid UserId { get; set; }
    public Guid QuizId { get; set; }
    public Guid AnswerId { get; set; }


    
    public User User { get; set; }
    public Quiz Quiz { get; set; }
    public Answer Answer { get; set; }
}
