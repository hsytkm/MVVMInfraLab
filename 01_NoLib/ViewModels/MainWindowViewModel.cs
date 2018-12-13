using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoLibrary.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        public string Title { get; } = "MVVM NoLibrary";

        private string _FilePath;
        public string FilePath
        {
            get => _FilePath;
            set => SetProperty(ref _FilePath, value);
        }

        //private int _Width;
        //public int Width
        //{
        //    get => _Width;
        //    private set => SetProperty(ref _Width, value);
        //}

        //private int _Height;
        //public int Height
        //{
        //    get => _Height;
        //    private set => SetProperty(ref _Height, value);
        //}

        public MainWindowViewModel() { }

    }
}
