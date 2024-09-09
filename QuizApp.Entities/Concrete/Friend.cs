using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Entities.Concrete;

public class Friend : BaseEntity
{
    public string Email { get; set; }
    public string Name { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public int CorrenctAnswer { get; set; }
    public int CurrentQuiz { get; set; }
    public bool IsFinished { get; set; }
    public DateTime ExpiredDate { get; set; }
}
