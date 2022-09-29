using CVProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CVProject.Entities.Concrete
{
    public class Award : IEntity
    {
        [Key]
        public int AwardId { get; set; }
        public string AwardItem { get; set; }
        //deneme
    }
}
