using CVProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CVProject.Entities.Concrete
{
    public class Experience : IEntity
    {
        [Key]
        public int ExperienceId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Date { get; set; }
        //deneme2
        //deneme3
    }
}
