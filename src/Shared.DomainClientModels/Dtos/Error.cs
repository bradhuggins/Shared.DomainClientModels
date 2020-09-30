#region Using Statements
using System;
using System.Collections.Generic;
using System.Text; 
#endregion

namespace Shared.DomainClientModels.Dtos
{
    public class Error
    {
        public string ErrorCode { get; set; }

        public string ErrorMessage { get; set; }
    }
}
