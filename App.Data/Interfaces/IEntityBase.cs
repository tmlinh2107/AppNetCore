using System;

namespace App.Data.Interfaces
{
    public interface IEntityBase
    {
        object Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }
    }

    public interface IEntityBase<T> : IEntityBase
    {
        new T Id { get; set; }
    }
}