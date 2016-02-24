namespace CodeExample.Views
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Annotations;
    using Objects;

    public class AboutMeViewModel : INotifyPropertyChanged
    {
        public AboutMeViewModel()
        {
            SendEmailCommand = new RelayCommand(SendEmail, o => !string.IsNullOrEmpty(Me.Email));
        }
        
        public Max Me => new Max();

        public RelayCommand SendEmailCommand { get; }

        private void SendEmail(object obj)
        {
            var adress = $"mailto:{Me.Email}";
            System.Diagnostics.Process.Start(adress);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
