using System;
using System.ComponentModel;

namespace NoLibrary.ViewModels
{
    // https://qiita.com/nossey/items/7c415799bc6fda45f94e
    class PropertyChangedEventListener : IDisposable
    {
        private INotifyPropertyChanged Source;
        private readonly PropertyChangedEventHandler Handler;

        public PropertyChangedEventListener(INotifyPropertyChanged source, PropertyChangedEventHandler handler)
        {
            Source = source;
            Source.PropertyChanged += Handler;
            Handler = handler;
        }

        public void Dispose()
        {
            if (Source != null && Handler != null)
                Source.PropertyChanged -= Handler;
        }
    }
}
