using System;
using System.IO;
using System.Windows.Input;

namespace NoLibrary.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        public string Title { get; } = "MVVM NoLibrary";

        #region Input

        private string _InputPath = @"C:\";
        public string InputPath
        {
            get => _InputPath;
            set => SetProperty(ref _InputPath, value);
        }

        private long _InputFileSize;
        public long InputFileSize
        {
            get => _InputFileSize;
            set => SetProperty(ref _InputFileSize, value);
        }

        #endregion

        // 表示したPathを削除
        public RelayCommand ClearPathCommand =>
            _ClearPathCommand ?? (_ClearPathCommand = new RelayCommand(
            () => InputPath = "",
            () => !string.IsNullOrWhiteSpace(InputPath)));
        private RelayCommand _ClearPathCommand;

        public MainWindowViewModel()
        {
            // ◆Disposeに未対応
            var listener = new PropertyChangedEventListener(this,
                (_, e) => {
                    if (e.PropertyName == nameof(InputPath))
                    {
                        InputFileSize = !File.Exists(InputPath) ? 0 : new FileInfo(InputPath).Length;
                        ClearPathCommand.RaiseCanExecuteChanged();
                    }
                });
        }

    }
}
