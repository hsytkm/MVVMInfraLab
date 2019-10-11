using System;
using System.ComponentModel;

namespace NoLibrary.Infrastructures
{
    // https://qiita.com/nossey/items/7c415799bc6fda45f94e
    class PropertyChangedEventListener : IDisposable
    {
        private readonly INotifyPropertyChanged Source;
        private readonly PropertyChangedEventHandler Handler;

        public PropertyChangedEventListener(INotifyPropertyChanged source, PropertyChangedEventHandler handler)
        {
            Source = source;
            Handler = handler;
            Source.PropertyChanged += Handler;
        }

        public void Dispose()
        {
            if (Source != null && Handler != null)
                Source.PropertyChanged -= Handler;
        }
    }
}
