using System;
using System.Collections.Generic;
using System.Text;

namespace Projet
{
    class File
    {
        protected String backupName { get; set; }
        protected String destinationPath { get; set; }
        protected String sourcePath { get; set; }
        protected double timestamp { get; set; }

        public File()
        {
        }
    }
}
