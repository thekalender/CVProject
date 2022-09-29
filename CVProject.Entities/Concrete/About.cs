using CVProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CVProject.Entities.Concrete
{
    public class About : IEntity
    {
        [Key]
        public int AboutId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public short Phone { get; set; }
        public string Description { get; set; }
        public string SocialMedia { get; set; }
    }
}
