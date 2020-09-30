#region Using Statements
using Shared.DomainClientModels.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

#endregion
namespace Shared.DomainClientModels.Messages
{
    public abstract class EntityResponseBase<T> : ResponseBase where T : class
    {
        public T Message { get; set; }

    }
}
