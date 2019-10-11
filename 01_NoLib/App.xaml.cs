using NoLibrary.Models;
using System.Windows;

namespace NoLibrary
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        public ModelContext ModelContext { get; } = new ModelContext();

        public static new App Current => (App)Application.Current;
    }
}
