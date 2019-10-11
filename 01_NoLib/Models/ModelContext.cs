using NoLibrary.Infrastructures;
using System;
using System.Threading.Tasks;

namespace NoLibrary.Models
{
    public class ModelContext : BindableBase
    {
        public DateTime DateTimeNow
        {
            get => _dateTimeNow;
            private set => SetProperty(ref _dateTimeNow, value);
        }
        private DateTime _dateTimeNow;

        public ModelContext()
        {
            _ = PushDateTime();
        }

        private async Task PushDateTime()
        {
            for (; ; )
            {
                await Task.Delay(1000);
                DateTimeNow = DateTime.Now;
            }
        }

    }
}
