using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{//TEMEL VOIDLER ICIN BASLANGIC
    public interface IResult
    { bool Success { get; }

       string Message { get; }
    }
}
