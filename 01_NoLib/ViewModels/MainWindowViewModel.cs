using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoLibrary.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        private static readonly string DefaultTitle = "MVVM NoLibrary";
        
        private string _Title = DefaultTitle;
        public string Title
        {
            get => _Title;
            private set => SetProperty(ref _Title, value);
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
