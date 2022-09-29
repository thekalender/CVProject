using CVProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CVProject.Entities.Concrete
{
    public class Education : IEntity
    {
        [Key]
        public int EducaitonId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Decription { get; set; }
        public short GNOT { get; set; }
        public string Date { get; set; }
    }
}
