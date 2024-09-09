using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Entities.Concrete;

public class User : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string  Email { get; set; }
    public List<UserAnswer> UserAnswers { get; set; }
}
