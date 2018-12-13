using System;
using System.Windows.Input;

namespace NoLibrary.ViewModels
{
    // http://running-cs.hatenablog.com/entry/2016/09/03/211015
    class RelayCommand : ICommand
    {
        // Command実行時のアクション
        // 引数を受け取りたい場合はこのActionをAction<object>などにする
        private readonly Action action;

        public RelayCommand(Action act)
        {
            action = act;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return action != null;
        }

        public void Execute(object parameter)
        {
            action?.Invoke();
        }

    }
}
