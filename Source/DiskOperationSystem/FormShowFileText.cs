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
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiskOperationSystem
{
    public partial class FormShowFileText : Form
    {
        public FormShowFileText()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 将字符串s的内容在窗口的TextBox上输出
        /// </summary>
        /// <param name="s">要显示的字符串的引用</param>
        public void setText(ref string s)
        {
            textBox1.Text = s;
            SuccessReadText = true;
        }

        /// <summary>
        /// 设置窗口的文本框是否为只读模式，只读模式禁止修改内容
        /// </summary>
        /// <param name="isReadOnly">是否允许只读模式，允许为true</param>
        public void setTextBoxReadOnly(bool isReadOnly)
        {
            textBox1.ReadOnly = isReadOnly;
        }

        //记录调用该窗口的文件节点信息
        private FileNode CurrentOpenFileNode;
        /// <summary>
        /// 将被打开文件的节点信息存放进Form中，用于在关闭窗口时调用该节点删除OFT表对应对象
        /// </summary>
        /// <param name="node">被打开文件的节点信息</param>
        public void setCurrentNode(ref FileNode node)
        {
            CurrentOpenFileNode = node;
        }

        /// <summary>
        /// 在窗口被关闭后执行该操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormShowFileText_FormClosed(object sender, FormClosedEventArgs e)
        {
            //若文件内容被改变，弹出提示框提示是否保存该文件
            if (isModified)
            {
                DialogResult result = DialogResult.No; //默认为取消
                result = MessageBox.Show("文件被改变，是否保存？", "保存", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.Yes:
                        //点击了“保存”按钮，执行保存操作
                        saveFile();
                        break;
                    case DialogResult.No:
                        //点击了“取消”按钮，直接退出
                        break;
                    default:
                        return;
                }
            }
            //当窗口关闭时从已打开文件表中释放对象
            Form1.OpenFileTable.Remove(CurrentOpenFileNode);
        }
        
        private bool SuccessReadText = false;//用于标记文件内容有没有初始化到TextBox中，在初始化显示内容时被设定
        private bool isModified = false;//用于标记文件内容是否被改变，默认为false
        /// <summary>
        /// 在TextBox内容发生改变后触发此函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (SuccessReadText)//加上判断原因是初始化TextBox时会将文件原有内容改变为文件内容，此时会出发TextChanged条件，需要排除掉
            {
                //在此处添加文本框内容发生变化后的处理方式
                //统计当前textBox内字符的字符数并显示在标签中
                labelCurrentTextNum.Visible = true;
                labelCurrentTextNum.Text = "当前文本框内字符数：" + textBox1.Text.Count().ToString();
                //允许“保存”按钮被点击
                buttonSave.Enabled = true;
                //设置文件内容是否被更改的标志为true
                isModified = true;
            }
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //询问是否保存
            DialogResult result = MessageBox.Show("是否保存文件？", "保存", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //保存文件
                saveFile();
            }
            else
            {
                return;
            }
        }

        private void saveFile()
        {
            //确认保存，执行保存操作
            byte startNodeNum = CurrentOpenFileNode.StartNode;//要保存文件的起始盘块号
            string s = textBox1.Text;//要保存的文件内容
                                     //开始保存
            byte usedBlockNum = Command.saveFileText(ref s, ref startNodeNum);//保存文件，并得到文件使用的盘块数量
            //TODO:修改文件的大小
            byte[] nodeInfo = new byte[64];
            IOClass.FileRead(ref nodeInfo, Form1.CurrentDirList.Last().StartNode * 64, 64);
            string nodeInfoString = Encoding.ASCII.GetString(nodeInfo);
            for (int i = 0; i < 8; i++)
            {
                //获取节点的name和type并截断后面的'\0'部分
                string name = nodeInfoString.Substring(i * 8, 3);
                string type = nodeInfoString.Substring(i * 8 + 3, 2);
                for (int j = 0; j < 3; j++)
                {
                    if (name[j] == '\0')
                    {
                        name = name.Remove(j);
                        break;
                    }
                }
                for (int j = 0; j < 2; j++)
                {
                    if (type[j] == '\0')
                    {
                        type = type.Remove(j);
                        break;
                    }
                }
                //获取成功
                //比较该节点是否与打开文件的信息一致
                if (CurrentOpenFileNode.Name == name && CurrentOpenFileNode.Type == type)
                {
                    //找到节点，开始修改
                    byte[] length = new byte[1] { usedBlockNum };
                    IOClass.FileWrite(Form1.CurrentDirList.Last().StartNode * 64 + i * 8 + 7, ref length);
                    //修改完成
                    break;
                }
            }
            //修改完毕
            MessageBox.Show("保存成功", "保存", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //保存成功后将文件设为未被更改状态
            isModified = false;
            buttonSave.Enabled = false;
            //结束保存
            return;
        }
    }
}
