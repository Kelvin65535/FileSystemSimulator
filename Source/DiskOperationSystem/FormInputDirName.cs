///***********************************************************************
///Copyright 2016 叶嘉永
///
///Licensed under the Apache License, Version 2.0 (the "License");
///you may not use this file except in compliance with the License.
///You may obtain a copy of the License at
///
///    http://www.apache.org/licenses/LICENSE-2.0
///
///Unless required by applicable law or agreed to in writing, software
///distributed under the License is distributed on an "AS IS" BASIS,
///WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
///See the License for the specific language governing permissions and
///limitations under the License.
///***********************************************************************

using System;
using System.Windows.Forms;

namespace DiskOperationSystem
{
    public partial class FormInputDirName : Form
    {
        public FormInputDirName()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Text = textBoxInput.Text;
            this.Close();
        }

        /// <summary>
        /// 将对话框里的提示内容（即label的Text）替换成s的字符串
        /// </summary>
        /// <param name="s">指定替换内容的字符串</param>
        public void changeLabelName(string s)
        {
            this.label1.Text = s;
        }

        
        
    }
}
