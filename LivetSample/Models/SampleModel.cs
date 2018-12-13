using Livet;
using Livet.EventListeners;
using System;
using System.Diagnostics;
using System.IO;

namespace LivetSample.Models
{
    class SampleModel : NotificationObject, IDisposable
    {
        private int _ButtonCount;
        public int ButtonCount
        {
            get => _ButtonCount;
            private set => RaisePropertyChangedIfSet(ref _ButtonCount, value);
        }

        #region InputFile

        private string _FilePath;
        public string FilePath
        {
            get => _FilePath;
            private set => RaisePropertyChangedIfSet(ref _FilePath, value);
        }

        private long _FileSize;
        public long FileSize
        {
            get => _FileSize;
            private set => RaisePropertyChangedIfSet(ref _FileSize, value);
        }

        #endregion

        public SampleModel()
        {
            var listener = new PropertyChangedEventListener(this)
            {
                nameof(FilePath), (_, e) =>
                {
                    if (e.PropertyName == nameof(FilePath))
                    {
                        FileSize = new FileInfo(FilePath).Length;
                    }
                },
            };
        }

        public void IncrementButtonCount()
        {
            ButtonCount++;
        }

        public void SetFilepath(string path)
        {
            FilePath = path;
        }

        public void Dispose()
        {
            Debug.WriteLine("SampleModel.Dispose()");
        }
    }
}
