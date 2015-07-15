using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileManager {
    public class FileItem {

        FileExtension extention;
        int size;
        string name;
        string path;

        public FileExtension Extention {
            get { return extention; }
            set { extention = value; }
        }
        public int Size {
            get { return size; }
            set { size = value; }
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Path {
            get { return path; }
            set { path = value; }
        }
    }

    public enum FileExtension {
        cs,
        vb,
        Other
    }
}
