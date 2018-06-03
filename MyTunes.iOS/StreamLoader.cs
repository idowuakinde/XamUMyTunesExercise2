using System;
using System.IO;

namespace MyTunes
{
    public class StreamLoader : IStreamLoader
    {
        public StreamLoader(MyTunesViewController myTunesViewController)
        {
        }

        public Stream GetStreamForFilename(string filename)
        {
            return File.OpenRead(filename);
        }
    }
}
