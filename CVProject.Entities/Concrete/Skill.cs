using CVProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CVProject.Entities.Concrete
{
    public class Skill : IEntity
    {
        [Key]
        public int SkillId { get; set; }
        public string StillItem { get; set; }
    }
}
