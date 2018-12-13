using Livet;
using System;
using System.Diagnostics;

namespace LivetSample.Models
{
    class SampleModel : NotificationObject, IDisposable
    {
        private int _ButtonCount;
        public int ButtonCount
        {
            get => _ButtonCount;
            private set => RaisePropertyChangedIfSet(ref _ButtonCount, value);
        }

        public SampleModel() { }

        public void IncrementButtonCount()
        {
            ButtonCount++;
        }

        public void Dispose()
        {
            Debug.WriteLine("SampleModel.Dispose()");
        }
    }
}
