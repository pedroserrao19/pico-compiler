﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.calitha.goldparser;

namespace PICOCompiler
{
    public partial class MainForm : Form
    {
        private PICOParser _parser;
        private String _file;
        private String _file_name;
        //...

        public MainForm()
        {
            InitializeComponent();
            _parser = new PICOParser(Application.StartupPath + "\\GrammarTable.cgt");
            //...
        }

        private void _onOpenFilePrompt(object sender, EventArgs e)
        {
            this.Refresh();
            // ...
            if (_dialog_file.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(_dialog_file.FileName, Encoding.Default);
                _file = reader.ReadToEnd();
                _file_name = _dialog_file.FileName;
                reader.Close();
                _analyzeFile();
            }
        }

        private void _onOpenErrorList(object sender, EventArgs e)
        {
            ErrorForm form = new ErrorForm();
            //...
            _listErrors(form);
            form.Show();
        }

        private void _listErrors(ErrorForm a)
        {
            //...
        }

        private void _analyzeFile()
        {
            //...
        }
    }

}