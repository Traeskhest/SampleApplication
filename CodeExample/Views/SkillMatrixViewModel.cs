using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExample.Views
{
    using CodeExample.Objects;

    public class SkillMatrixViewModel
    {

        public SkillMatrixViewModel()
        {
            Skills = new List<Skill>()
                         {
                             new Skill()
                                 {
                                     Name = "WPF",
                                     Start =new DateTime(2012, 01, 01),
                                     Level = Level.Four
                                 },
                                     new Skill()
                                 {
                                     Name = "C#",
                                     Start = new DateTime(2012, 01, 01),
                                     Level = Level.Four
                                 },
                                  new Skill()
                                 {
                                     Name = "WCF",
                                     Start = new DateTime(2012, 01, 01),
                                     Level = Level.Two
                                 },
                                  new Skill()
                                 {
                                     Name = "Halcon",
                                     Start = new DateTime(2012, 01, 01),
                                     Level = Level.Five,
                                     Page = "http://www.halcon.com/"
                                 },
                                          new Skill()
                                 {
                                     Name = "Adept Ace",
                                     Start = new DateTime(2012, 01, 01),
                                     Level = Level.Three,
                                     Page = "http://www.adept.com/products/software/pc/adept-ace/general"
                                 }
                         };

        }
        public IEnumerable<Skill> Skills { get; set; }
    }
}
