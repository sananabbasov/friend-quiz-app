using QuizApp.Core.DataAccess.EntityFramework;
using QuizApp.DataAccess.Abstract;
using QuizApp.Entities.Concrete;

namespace QuizApp.DataAccess.Concrete.EntityFramework;

public class EfQuizDal : EfRepositoryBase<Quiz, AppDbContext>, IQuizDal
{
    
}
