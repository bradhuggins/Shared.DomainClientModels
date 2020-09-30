#region Using Statments
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text; 
#endregion

namespace Shared.DomainClientModels.Enums
{
    public enum SortDirection
    {
        [EnumMember(Value = "Asc")]
        Ascending,

        [EnumMember(Value = "Desc")]
        Descending
    }
}
