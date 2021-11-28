using System;
using System.ComponentModel.DataAnnotations;

namespace Accredit.Shared.Entities.Base
{
    public abstract class BasePropertyEntity
    {
        /// <summary>
        /// Date time the entity was created
        /// This will be set by context on save changes
        /// </summary>
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}