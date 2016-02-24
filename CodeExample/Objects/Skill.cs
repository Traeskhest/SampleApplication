namespace CodeExample.Objects
{
    using System;
    using Views;

    public class Skill
    {
        private RelayCommand _visitPageCommand;
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public Level Level { get; set; }
        public string Page { get; set; }
        public RelayCommand VisitPageCommand
        {
            get
            {
                return _visitPageCommand
                       ?? (_visitPageCommand =
                           new RelayCommand(
                               o => System.Diagnostics.Process.Start(Page),
                               o => !string.IsNullOrEmpty(Page)));
            }
        }
    }
}