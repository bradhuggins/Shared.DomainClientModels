#region Using Statments
using System;
using System.Collections.Generic;
using System.Text; 
#endregion

namespace Shared.DomainClientModels.Dtos
{
    public class PagingList<T> : List<T>
    {
        public PagingList()
            : base()
        {
        }

        public PagingList(int capacity)
            : base(capacity)
        {
        }

        public PagingList(IEnumerable<T> collection)
            : base(collection)
        {
        }

        public int? TotalCount { get; set; }
    }
}
