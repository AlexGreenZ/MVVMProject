using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Mvvm.DataAnnotations;

namespace FileManager.ViewModel {
    public class FileManagerViewModel {

        string directoryPath;
        FileExtension currentFileExtention;
        BindingList<FileItem> fileList = new BindingList<FileItem>();

        public BindingList<FileItem> FileList {
            get {return fileList;}
            set {fileList = value;}
        }

        public virtual string DirectoryPath {
            get {return directoryPath;}
            set { directoryPath = value;
            OnDirectoryPathChanged();
            }
        }


        public virtual FileExtension CurrentFileExtention {
            get { return currentFileExtention; }
            set {
                currentFileExtention = value;
            }
        }

        protected void OnDirectoryPathChanged() {
            if (Directory.Exists(directoryPath)) {
                fileList.Clear();
                string[] files = Directory.GetFiles(directoryPath);
                foreach (string file in files) {
                    if (Path.GetExtension(file) == String.Empty)
                        continue;
                    FileItem fileItem = new FileItem();
                    fileItem.Name = Path.GetFileName(file);
                    fileItem.Path = Path.GetFullPath(file);
                    if (Path.GetExtension(file) != ".cs" && Path.GetExtension(file) != ".vb") {
                        fileItem.Extention = FileExtension.Other;
                    }
                    else
                        fileItem.Extention = (FileExtension)Enum.Parse(typeof(FileExtension), Path.GetExtension(file).Remove(0, 1));

                    if (fileItem.Extention == currentFileExtention)
                        fileList.Add(fileItem);
                }
            }
            else
                MessageBox.Show("This directory is not exists!");
        }

    }
}
