using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accredit.Shared.Entities.Base
{
    public abstract class BaseEntity<T> : BasePropertyEntity
    {
        protected BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
    }
}
