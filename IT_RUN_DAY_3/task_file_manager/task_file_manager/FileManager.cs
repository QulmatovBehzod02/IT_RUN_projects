using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace task_file_manager
{
    public class FileManager : IDisposable
    {
        private bool disposed = false;
        private string filePath;
        private StreamWriter fileStream;

        public FileManager(string filePath)
        {
            this.filePath = filePath;
            this.fileStream = new StreamWriter(filePath, true);
        }

        public void WriteToFile(string text)
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException("FileManager", "Cannot write to a disposed FileManager object.");
            }

            this.fileStream.WriteLine(text);
        }

       

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                this.fileStream.Dispose();
            }

            disposed = true;
        }

        ~FileManager()
        {
            Dispose(false);
        }
    }
}
