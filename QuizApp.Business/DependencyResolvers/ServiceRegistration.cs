using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using QuizApp.Business.Abstract;
using QuizApp.Business.Concrete;
using QuizApp.DataAccess.Abstract;
using QuizApp.DataAccess.Concrete.EntityFramework;

namespace QuizApp.Business.DependencyResolvers;

public static class ServiceRegistration
{
    public static void AddBusinessRegistration(this IServiceCollection services)
    {
        services.AddScoped<IAnswerService, AnswerManager>();
        services.AddScoped<IAnswerDal, EfAnswerDal>();

        services.AddScoped<IFriendService, FriendManager>();
        services.AddScoped<IFriendDal, EfFriendDal>();

        services.AddScoped<IQuizService, QuizManager>();
        services.AddScoped<IQuizDal, EfQuizDal>();

        services.AddScoped<IUserService, UserManager>();
        services.AddScoped<IUserDal, EfUserDal>();

        services.AddScoped<IUserAnswerService, UserAnswerManager>();
        services.AddScoped<IUserAnswerDal, EfUserAnswerDal>();


    }

}
