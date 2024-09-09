using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Core.Utilities.Results.Concrete.Success;

public class SuccessResult : Result
{
    public SuccessResult() : base(true)
    {
    }

    public SuccessResult(string message) : base(true, message)
    {
    }
}

// return new SuccessResult("Melumat elave olundu");
// return new SuccessResult();