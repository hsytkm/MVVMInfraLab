using NoLibrary.Infrastructures;
using NoLibrary.Models;
using NoLibrary.Views;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace NoLibrary.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        private ModelContext Model = App.Current.ModelContext;

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

        public ObservableCollection<DateTimeControl> DateTimes { get; } = new ObservableCollection<DateTimeControl>();

        public MainWindowViewModel()
        {
            // ◆Disposeに未対応
            var selfListener = new PropertyChangedEventListener(this,
                (_, e) => {
                    if (e.PropertyName == nameof(InputPath))
                    {
                        InputFileSize = !File.Exists(InputPath) ? 0 : new FileInfo(InputPath).Length;
                        ClearPathCommand.RaiseCanExecuteChanged();
                    }
                });

            var dispatcher = App.Current.Dispatcher;

            var modelListener = new PropertyChangedEventListener(Model,
                (sender, e) => {
                    if (e.PropertyName == nameof(ModelContext.DateTimeNow))
                    {
                        if (!(sender is ModelContext model)) return;

                        dispatcher.Invoke(() => DateTimes.Add(new DateTimeControl(model.DateTimeNow)));
                    }
                });

        }

    }
}
