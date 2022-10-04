using CVProject.Entities.Concrete;
using System.Collections.Generic;

namespace CVProject.WepUI.Model.CVPProjectModel
{
    public class CVPProjectListViewModel
    {
        public List<About> Abouts { get; set; }
        public List<Award> Awards { get; set; }
        public List<Education> Educations { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Interest> Interests { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
