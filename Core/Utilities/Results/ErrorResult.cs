using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        //First upper Result class constructer
        public ErrorResult(string message) : base(false, message)
        {

        }

        //Second upper Result class constructer
        public ErrorResult() : base(false)
        {

        }
    }
}
