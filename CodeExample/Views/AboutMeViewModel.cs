using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExample.Views
{
    using System.ComponentModel;
    using System.IO;
    using System.Runtime.CompilerServices;

    using CodeExample.Annotations;
    using CodeExample.Objects;

    using Gu.Reactive;

    public class AboutMeViewModel : INotifyPropertyChanged
    {
        private RelayCommand _senEmailCommand;

        public Max Me => new Max();
        public RelayCommand SendEmailCommand
        {
            get
            {
                return _senEmailCommand
                       ?? (_senEmailCommand =
                           new RelayCommand(
                               o => System.Diagnostics.Process.Start(string.Concat("mailto:", Me.Email)),
                               o => true));
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
