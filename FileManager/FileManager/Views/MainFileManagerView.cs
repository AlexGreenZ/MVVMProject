using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using FileManager.ViewModel;

namespace FileManager.Views {
    public partial class MainFileManagerView : UserControl {

        string directoryPath;
        FileExtension currentFileExtension;

        public MainFileManagerView() {
            InitializeComponent();
            GetViewModel();
        }

        private void GetViewModel() {
            var viewModel = mvvmContext1.GetViewModel<FileManagerViewModel>();           
            viewModel.CurrentFileExtention = GetCurrentFileExtension();
            viewModel.DirectoryPath = GetDirectoryPath();
            SetGridControlDatasource();
        }

        string GetDirectoryPath() {
            if (barManager1.ActiveEditor == null)
                directoryPath = barEditItem1.EditValue.ToString();
            else {
                ButtonEdit edit = (ButtonEdit)barManager1.ActiveEditor;
                if (edit != null)
                    directoryPath = edit.EditValue.ToString();
            }
            return directoryPath;
        }

        void SetGridControlDatasource() {
            var fluentAPI = mvvmContext1.OfType<FileManagerViewModel>();
            fluentAPI.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.FileList);
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            GetViewModel();
        }

        FileExtension GetCurrentFileExtension() {
            if (barEditItem2.EditValue.ToString() != "cs" && barEditItem2.EditValue.ToString() != "vb")
                currentFileExtension = FileExtension.Other;
            else
                currentFileExtension = (FileExtension)Enum.Parse(typeof(FileExtension), barEditItem2.EditValue.ToString());
            return currentFileExtension;
        }
    }
    
}
