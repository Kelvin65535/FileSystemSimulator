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
    public partial class FormInputFileName : Form
    {
        public FormInputFileName()
        {
            InitializeComponent();
            checkBox普通.Checked = true;
        }

        private void checkBox普通_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox普通.Checked == true)
            {
                checkBox只读.Checked = false;
                checkBox系统.Checked = false;
            }
            
        }

        private void checkBox只读_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox只读.Checked == true)
            {
                checkBox普通.Checked = false;
                checkBox系统.Checked = false;
            }
        }

        private void checkBox系统_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox系统.Checked == true)
            {
                checkBox普通.Checked = false;
                checkBox只读.Checked = false;
            }
        }

        public string getFileAttribute()
        {
            if (checkBox普通.Checked == true)
            {
                return "普通文件";
            }
            else if (checkBox只读.Checked == true)
            {
                return "只读文件";
            }
            else if (checkBox系统.Checked == true)
            {
                return "系统文件";
            }
            else
            {
                return "";
            }
        }

        public string getFileName()
        {
            return textBoxName.Text;
        }


        public bool isConfirm = false;


        private void button确定_Click(object sender, EventArgs e)
        {
            isConfirm = true;
            Close();
        }

        public void isChangeAttribute()
        {
            label提示.Text = "请选择要修改的文件属性";
            文件名label.Visible = false;
            textBoxName.Visible = false;
        }
    }
}
