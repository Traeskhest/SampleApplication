namespace CodeExample.Views
{
    using System;
    using System.Collections.Generic;
    using Objects;
    public class SkillMatrixViewModel
    {
        public SkillMatrixViewModel()
        {
            Skills = new List<Skill>()
                         {
                             new Skill("WPF", new DateTime(2012, 01, 01), Level.Four),
                             new Skill("C#", new DateTime(2012, 01, 01), Level.Four),
                             new Skill("WCF", new DateTime(2012, 01, 01), Level.Two),
                             new Skill(
                                 "Halcon",
                                 new DateTime(2012, 01, 01),
                                 Level.Five,
                                 "http://www.halcon.com/"),
                             new Skill(
                                 "Adept Ace",
                                 new DateTime(2012, 01, 01),
                                 Level.Three,
                                 "http://www.adept.com/products/software/pc/adept-ace/general")
                         };
        }
        public IEnumerable<Skill> Skills { get; set; }
    }
}
