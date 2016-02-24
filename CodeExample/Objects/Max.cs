namespace CodeExample.Objects
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Annotations;
    using Properties;

    public class Max : INotifyPropertyChanged
    {
        private int _age;

        public Max()
        {
            _age = 25;
        }
        public string LastName => "Anderung";

        public string FirstName => "Max";

        public string FullName => $"{FirstName} , {LastName}";

        public string AboutMe => Resources.AboutMe;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value == _age)
                {
                    return;
                }
                _age = value;
                OnPropertyChanged();
            }
        }

        public string Email => "max.anderung@gmail.com";

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}