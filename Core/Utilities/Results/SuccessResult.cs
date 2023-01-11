using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        //First upper Result class constructer
        public SuccessResult(string message) : base(true, message)
        {

        }
        
        //Second upper Result class constructer
        public SuccessResult() : base(true)
        {

        }
    }
}
