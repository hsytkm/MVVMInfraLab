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
            // Modelの変更通知を伝搬
            var counterListener = new PropertyChangedEventListener(SampleModel)
            {
                  () => SampleModel.ButtonCount, (_, __) => RaisePropertyChanged(nameof(Counter))
            };

        }

        // Viewからメソッドを直接Binding
        public void ButtonCommand()
        {
            // Modelを書き換える
            SampleModel.IncrementButtonCount();
        }
    }
}
