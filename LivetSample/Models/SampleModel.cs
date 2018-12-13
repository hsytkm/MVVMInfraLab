using Livet;

namespace LivetSample.Models
{
    class SampleModel : NotificationObject
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

    }
}
