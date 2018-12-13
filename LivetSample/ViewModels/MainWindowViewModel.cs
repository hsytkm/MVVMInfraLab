using Livet;
using Livet.EventListeners;
using LivetSample.Models;

namespace LivetSample.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        private SampleModel SampleModel = new SampleModel();

        public int Counter { get => SampleModel.ButtonCount; }

        public MainWindowViewModel()
        {
            CompositeDisposable.Add(SampleModel);

            // Modelの変更通知を伝搬
            var counterListener = new PropertyChangedEventListener(SampleModel)
            {
                  () => SampleModel.ButtonCount, (_, __) => RaisePropertyChanged(nameof(Counter))
            };

        }

        public void Initialize() { }

        // Viewからメソッドを直接Binding
        public void ButtonClickCommand()
        {
            SampleModel.IncrementButtonCount();
        }
    }
}
