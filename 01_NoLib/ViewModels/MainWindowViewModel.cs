using System.Windows.Input;

namespace NoLibrary.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        public string Title { get; } = "MVVM NoLibrary";

        private string _InputPath = @"C:\";
        public string InputPath
        {
            get => _InputPath;
            set => SetProperty(ref _InputPath, value);
        }

        // 表示したPathを削除
        private ICommand _ClearPathCommand;
        public ICommand ClearPathCommand
        {
            get
            {
                return _ClearPathCommand
                    ?? (_ClearPathCommand = new RelayCommand(
                    () =>
                    {
                        InputPath = "";
                    }));
            }
        }

        public MainWindowViewModel() { }

    }
}
