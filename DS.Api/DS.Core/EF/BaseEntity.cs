using System;
namespace DS.Core.EF
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }
    }
}

