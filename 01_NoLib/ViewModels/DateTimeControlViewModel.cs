using NoLibrary.Infrastructures;
using System;

namespace NoLibrary.ViewModels
{
    class DateTimeControlViewModel : BindableBase
    {
        public string Time { get; }
        public DateTimeControlViewModel(DateTime time)
        {
            Time = time.ToString();
        }

    }
}
