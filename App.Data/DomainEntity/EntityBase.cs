using App.Data.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.DomainEntity
{
    public abstract class EntityBase<T> : IEntityBase<T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }

        object IEntityBase.Id
        {
            get { return Id; }
            set { Id = (T)Convert.ChangeType(value, typeof(T)); }
        }

        private DateTime? createDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedDate
        {
            get { return createDate ?? DateTime.UtcNow; }
            set { createDate = value; }
        }

        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
}