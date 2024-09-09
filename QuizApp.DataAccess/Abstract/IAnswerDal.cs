using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizApp.Core.DataAccess;
using QuizApp.Entities.Concrete;

namespace QuizApp.DataAccess.Abstract;

public interface IAnswerDal : IRepositoryBase<Answer>
{
    
}
