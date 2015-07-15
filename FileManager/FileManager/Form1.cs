using DevExpress.XtraEditors;
using FileManager.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileManager {
    public partial class Form1 : Form {


        public Form1() {
            InitializeComponent();



            //var viewModel = mvvmContext1.GetViewModel<FileManagerViewModel>();
            //viewModel.Path = @"c:\";
            //var fluentAPI = mvvmContext1.OfType<FileObjectCollectionViewModel>();
            //fluentAPI.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Files);
        }
    }
        

}
