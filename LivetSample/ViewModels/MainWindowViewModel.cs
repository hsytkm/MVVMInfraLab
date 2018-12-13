using Livet;
using Livet.EventListeners;
using LivetSample.Models;

namespace LivetSample.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        private SampleModel SampleModel = new SampleModel();

        public int Counter { get => SampleModel.ButtonCount; }

        #region InputFile

        private string _InputPath;
        public string InputPath
        {
            get => _InputPath;
            set
            {
                if (RaisePropertyChangedIfSet(ref _InputPath, value))
                {
                    SampleModel.SetFilepath(_InputPath);
                }
            }
        }

        public long _InputFileSize;
        public long InputFileSize
        {
            get => _InputFileSize;
            private set => RaisePropertyChangedIfSet(ref _InputFileSize, value);
        }

        #endregion

        public MainWindowViewModel()
        {
            CompositeDisposable.Add(SampleModel);

            #region ModelEvent

            // Modelの変更通知を伝搬
            var listener = new PropertyChangedEventListener(SampleModel)
            {
                nameof(SampleModel.ButtonCount), (_, e) =>
                {
                    if (e.PropertyName == nameof(SampleModel.ButtonCount))
                    {
                        RaisePropertyChanged(nameof(Counter));
                    }
                },
                nameof(SampleModel.FileSize), (_, e) =>
                {
                    if (e.PropertyName == nameof(SampleModel.FileSize))
                    {
                        InputFileSize = SampleModel.FileSize;
                    }
                },
            };

            #endregion
        }

        public void Initialize() { }

        // Viewからメソッドを直接Binding
        public void ButtonClickCommand()
        {
            SampleModel.IncrementButtonCount();
        }
    }
}
