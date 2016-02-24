namespace CodeExample.Objects
{
    using System;
    using Views;
    public class Skill
    {
        public Skill(string name, DateTime start, Level level, string page = "")
        {
            Name = name;
            Start = start;
            Level = level;
            Page = page;
            VisitPageCommand = new RelayCommand(ExecuteStart, o => !string.IsNullOrEmpty(Page));
        }

        public string Name { get; }

        public DateTime Start { get; }

        public Level Level { get; }

        public string Page { get; }

        public RelayCommand VisitPageCommand { get; }

        private void ExecuteStart(object obj)
        {
            System.Diagnostics.Process.Start(Page);
        }
    }
}