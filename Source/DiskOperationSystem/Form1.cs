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
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DiskOperationSystem
{
    public partial class Form1 : Form
    {
        /***************************************************************
         * 
         * 构造函数
         * 
         ***************************************************************/
        
        /// <summary>
        /// 主窗口的构造函数
        /// </summary>
        public Form1()
        {
            //初始化组件
            InitializeComponent();
            //初始化当前目录
            InitializeCurrentDir();
            //刷新ListView列表
            updateList(); 
        }

        /***************************************************************
         * 
         * 全局变量
         * 
         ***************************************************************/

        /// <summary>
        /// 存放当前目录节点信息的泛型List集合
        /// </summary>
        public static List<FileNode> CurrentDirList = new List<FileNode>();
        /// <summary>
        /// 存放已打开文件信息的泛型List集合
        /// </summary>
        public static List<FileNode> OpenFileTable = new List<FileNode>();

        /***************************************************************
         * 
         * 初始化函数
         * 
         ***************************************************************/
        /// <summary>
        /// 初始化当前目录为根目录"/"
        /// 将根目录的文件信息放进FileNode，并插入表示当前打开目录的List集合（CurrentDirList）的第一项
        /// 并将指示当前目录的Label改为根目录的名称"/"
        /// </summary>
        private void InitializeCurrentDir()
        {
            FileNode rootNode = new FileNode();
            rootNode.Name = "/";
            rootNode.StartNode = (byte)0x02;
            //添加进集合
            CurrentDirList.Add(rootNode);
            //初始化标签
            labelCurrentDir.Text = rootNode.Name;
        }

        /***************************************************************
         * 
         * 以下为点击窗体内的控件或内容后发生的响应事件
         * 
         ***************************************************************/

        private void 目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            目录ToolStripMenuItem1_Click(sender, e);
        }

        /// <summary>
        /// 当在ListView上单击右键时该方法发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            //当选择元素时点击右键，选择在右键上显示的项
            if (mainListView.SelectedItems.Count == 1)
            {
                //当在选择一个元素上点击右键时将右键菜单不需显示的元素隐藏掉
                mainContextMenuStrip.Items["新建ToolStripMenuItem"].Visible = false;
                mainContextMenuStrip.Items["刷新ToolStripMenuItem"].Visible = false;
                //当选择的元素是目录时，将“修改文件属性”菜单项隐藏掉
                if (mainListView.SelectedItems[0].SubItems[2].Text == "目录")
                {
                    mainContextMenuStrip.Items["修改文件属性ToolStripMenuItem"].Visible = false;
                }
            }
            //当在空白处点击右键，选择在右键上显示的项
            else if (mainListView.SelectedItems.Count == 0)
            {
                //当在空白地方点击右键时将右键菜单不需显示的元素隐藏掉
                mainContextMenuStrip.Items["toolStripSeparator1"].Visible = false;//分割线
                mainContextMenuStrip.Items["删除ToolStripMenuItem"].Visible = false;
                mainContextMenuStrip.Items["重命名ToolStripMenuItem"].Visible = false;
                mainContextMenuStrip.Items["属性ToolStripMenuItem"].Visible = false;
                mainContextMenuStrip.Items["修改文件属性ToolStripMenuItem"].Visible = false;
            }
            //当选择多个元素时，选择在右键上显示的项
            else
            {
                mainContextMenuStrip.Items["新建ToolStripMenuItem"].Visible = false;
                mainContextMenuStrip.Items["刷新ToolStripMenuItem"].Visible = false;
                mainContextMenuStrip.Items["重命名ToolStripMenuItem"].Visible = false;
                mainContextMenuStrip.Items["属性ToolStripMenuItem"].Visible = false;
                mainContextMenuStrip.Items["toolStripSeparator1"].Visible = false;//分割线
                mainContextMenuStrip.Items["toolStripSeparator2"].Visible = false;//分割线
                mainContextMenuStrip.Items["删除ToolStripMenuItem"].Visible = false;
                mainContextMenuStrip.Items["修改文件属性ToolStripMenuItem"].Visible = false;
            }
            
        }

        /// <summary>当ListView的右键菜单关闭的时候发生，将在打开菜单时设置的菜单项隐藏状态重设为可见</summary>
        private void mainContextMenuStrip_Closed(object sender, EventArgs e)
        {
            mainContextMenuStrip.Items["新建ToolStripMenuItem"].Visible = true;
            mainContextMenuStrip.Items["重命名ToolStripMenuItem"].Visible = true;
            mainContextMenuStrip.Items["删除ToolStripMenuItem"].Visible = true;
            mainContextMenuStrip.Items["刷新ToolStripMenuItem"].Visible = true;
            mainContextMenuStrip.Items["toolStripSeparator1"].Visible = true;//分割线
            mainContextMenuStrip.Items["属性ToolStripMenuItem"].Visible = true;
            mainContextMenuStrip.Items["toolStripSeparator2"].Visible = true;//分割线
            mainContextMenuStrip.Items["修改文件属性ToolStripMenuItem"].Visible = true;
        }

        private void 属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //当有项目被选中时执行该方法，显示该选中项目的属性
            if (mainListView.SelectedItems.Count == 1)
            {
                string s = null;
                s = s + "文件名：" + mainListView.SelectedItems[0].SubItems[0].Text + '\n';
                s = s + "文件类型：" + mainListView.SelectedItems[0].SubItems[1].Text + '\n';
                s = s + "文件属性：" + mainListView.SelectedItems[0].SubItems[2].Text + '\n';
                s = s + "起始盘块号：" + mainListView.SelectedItems[0].SubItems[3].Text + '\n';
                s = s + "大小：" + mainListView.SelectedItems[0].SubItems[4].Text + " 字节" + '\n';
                MessageBox.Show(s, "属性");
            }
        }

        private void 重命名toolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断重命名的对象是文件还是目录
            if (mainListView.SelectedItems[0].SubItems[2].Text == "目录")
            {
                //对一个目录进行重命名
                FormInputDirName form = new FormInputDirName(); //新建用于输入目录名称的窗口
                form.changeLabelName("请输入新的目录名称：");
                form.ShowDialog();
                //获得输入名称
                string name = form.Text;
                form.Close();
                //判断输入是否为空
                if (name == "")
                {
                    //MessageBox.Show("输入为空");
                    return;
                }
                //判断输入是否超过3个字符限制
                if (name.Length > 3)
                {
                    MessageBox.Show("错误：目录名应不超过3个字符", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //判断是否与当前目录内的项重名
                foreach (ListViewItem item in mainListView.Items)
                {
                    if (name == item.Text && name != mainListView.SelectedItems[0].Text)//防止与自己重名时发生错误
                    {
                        MessageBox.Show("错误：与当前目录现有项重名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //在name字符串后补'\0'使之达到3字节长度
                for (int i = name.Length; i < 3; i++)
                {
                    name += '\0';
                }
                //转换成byte[]数组
                byte[] nameByte = new byte[3];
                nameByte = ASCIIEncoding.ASCII.GetBytes(name);
                //当前目录的节点信息
                FileNode current = CurrentDirList.Last();
                //修改前的目录名
                string nameBeforeRename = mainListView.SelectedItems[0].SubItems[0].Text;
                for (int i = nameBeforeRename.Length; i < 3; i++)
                {
                    nameBeforeRename += '\0';
                }
                //根据当前目录的节点起始盘块号获取目录的盘块信息
                byte[] nodeinfo = new byte[64];
                IOClass.FileRead(ref nodeinfo, current.StartNode * 64, 64);
                string nodeinfoString = ASCIIEncoding.ASCII.GetString(nodeinfo);
                int index = 0;
                for (index = 0; index < 8; index++)
                {
                    string nameInNode = nodeinfoString.Substring(index * 8, 3);
                    if (nameBeforeRename == nameInNode && nodeinfo[index * 8 + 5] == 8)
                    {
                        //写入磁盘
                        IOClass.FileWrite(current.StartNode * 64 + index * 8, ref nameByte); //写入磁盘
                        break;
                    }
                }
                updateList();
            }

            else
            {
                //以下对一个文件进行重命名
                FormInputDirName form = new FormInputDirName(); //新建用于输入文件名称的窗口
                form.changeLabelName("请输入新的文件名称：");
                form.ShowDialog();
                //获取输入的文件名
                string input = form.Text;
                string[] inputArray = input.Split('.');
                //判断输入是否为空
                if (input == "")
                {
                    return;
                }
                //判断是否以正确的格式输入
                if (inputArray.Count() != 2)
                {
                    MessageBox.Show("错误：文件名输入错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                for (int i = 0; i < 2; i++)
                {
                    //判断文件名输入是否错误
                    if (i == 0 && inputArray[i].Length > 3)
                    {
                        MessageBox.Show("错误：文件名输入错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //判断文件类型名输入是否错误
                    if (i == 1 && inputArray[i].Length > 2)
                    {
                        MessageBox.Show("错误：文件名输入错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //判断输入是否为空
                    if (inputArray[i].Length == 0)
                    {
                        MessageBox.Show("错误：文件名输入错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string name = inputArray[0];
                string type = inputArray[1];
                //判断是否与当前目录内的项重名
                foreach (ListViewItem item in mainListView.Items)
                {
                    //当前项为目录时：
                    if (item.SubItems[3].Text == "目录")
                    {
                        if (name == item.SubItems[0].Text && name != mainListView.SelectedItems[0].SubItems[0].Text)//防止与自己重名时发生错误
                        {
                            MessageBox.Show("错误：与当前目录现有项重名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    //当前项为文件时：
                    else
                    {
                        if (name == item.SubItems[0].Text && name != mainListView.SelectedItems[0].SubItems[0].Text)//防止与自己重名时发生错误
                        {
                            if (type == item.SubItems[1].Text && name != mainListView.SelectedItems[0].SubItems[1].Text)
                            {
                                MessageBox.Show("错误：与当前目录现有项重名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                //在name字符串后补'\0'使之达到3字节长度
                for (int i = name.Length; i < 3; i++)
                {
                    name += '\0';
                }
                //在type字符串后补'\0'使之达到2字节长度
                for (int i = type.Length; i < 2; i++)
                {
                    type += '\0';
                }
                //转换成byte[]数组
                string nametype = name + type;
                byte[] nametypeByte = new byte[5];
                nametypeByte = ASCIIEncoding.ASCII.GetBytes(nametype);
                //当前目录的节点信息
                FileNode current = CurrentDirList.Last();
                //修改前的文件名
                string nameBeforeRename = mainListView.SelectedItems[0].SubItems[0].Text;
                for (int i = nameBeforeRename.Length; i < 3; i++)
                {
                    nameBeforeRename += '\0';
                }
                //修改前的类型名
                string typeBeforeRename = mainListView.SelectedItems[0].SubItems[1].Text;
                for (int i = typeBeforeRename.Length; i < 2; i++)
                {
                    typeBeforeRename += '\0';
                }
                //组合成文件名+类型名
                string nametypeBeforeRename = nameBeforeRename + typeBeforeRename;
                //根据当前目录的节点起始盘块号获取目录的盘块信息
                byte[] nodeinfo = new byte[64];
                IOClass.FileRead(ref nodeinfo, current.StartNode * 64, 64);
                string nodeinfoString = ASCIIEncoding.ASCII.GetString(nodeinfo);
                int index = 0;
                for (index = 0; index < 8; index++)
                {
                    string nametypeInNode = nodeinfoString.Substring(index * 8, 5);
                    if (nametypeBeforeRename == nametypeInNode && nodeinfo[index * 8 + 5] != 8)
                    {
                        //写入磁盘
                        IOClass.FileWrite(current.StartNode * 64 + index * 8, ref nametypeByte); //写入磁盘
                        break;
                    }
                }
                updateList();
            }
        }

        /// <summary>当菜单栏->新建->目录按钮被选中的时候发生，新建目录</summary>
        private void 目录ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //判断当前目录是否已达到8个项的限制
            if (mainListView.Items.Count == 8)
            {
                //已达到8个项的限制，创建失败
                MessageBox.Show("错误：目录已满\n", "创建失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormInputDirName tempForm = new FormInputDirName();
            tempForm.ShowDialog();  //使用ShowDialog方式打开，使该句后的代码在窗口被关闭后再执行
            string s = tempForm.Text;
            //判断输入是否为空
            if (s == "" || s == null)
            {
                return;
            }
            //判断输入是否超过3个字符限制
            if (s.Length > 3)
            {
                MessageBox.Show("错误：目录名应不超过3个字符", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Command.md(ref s);
            updateList();
        }

        /// <summary>当菜单栏->新建->文件按钮被选中的时候发生，新建文件</summary>
        private void 文件ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            文件ToolStripMenuItem_Click(sender, e);
        }

        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainListView.View = View.LargeIcon;
        }

        private void 小图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainListView.View = View.SmallIcon;
        }

        private void 平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainListView.View = View.Tile;
        }

        private void 列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainListView.View = View.List;
        }

        private void 详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainListView.View = View.Details;
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断是否达到8个项的限制
            if (mainListView.Items.Count == 8)
            {
                //已达到8个项的限制，创建失败
                MessageBox.Show("错误：目录已满\n", "创建失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            FormInputFileName form = new FormInputFileName();
            form.ShowDialog();
            //获取输入的文件名和属性
            string input = form.getFileName();//在新建文件窗口输入的文件名
            string[] inputArray = input.Split('.');//根据输入内容按照'.'的位置分割成文件名.扩展名
            string attribute = form.getFileAttribute();//获得要新建文件的属性
            bool isConfirm = form.isConfirm;//判断是否点击了“确定”按钮
            //判断输入是否为空
            if (input == "")
            {
                return;
            }
            //若直接关闭新建窗口，则不做任何处理
            if (isConfirm == false)
            {
                return;
            }
            //判断是否以正确的格式输入
            if (inputArray.Count() != 2)
            {
                MessageBox.Show("错误：文件名输入错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < 2; i++)
            {
                //判断文件名输入是否错误
                if (i == 0 && inputArray[i].Length > 3)
                {
                    MessageBox.Show("错误：文件名输入错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //判断文件类型名输入是否错误
                if (i == 1 && inputArray[i].Length > 2)
                {
                    MessageBox.Show("错误：文件名输入错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //判断输入是否为空
                if (inputArray[i].Length == 0)
                {
                    MessageBox.Show("错误：文件名输入错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //通过一系列的判断后，得到正确格式的名字和类型
            string name = inputArray[0];
            string type = inputArray[1];
            //新建文件
            Command.newFile(ref name, ref type, ref attribute);
            //若通过则建立成功
            updateList();
        }

        /// <summary>当菜单栏->关于按钮被选中的时候发生，弹出“关于”框</summary>
        private void 关于toolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }
        
        /***************************************************************
         * 
         * 以下为点击工具栏的项目后的响应事件
         * 
         ***************************************************************/
        /// <summary>点击工具栏的“返回上一级按钮”后的响应事件，返回上一级菜单</summary>
        private void buttonUpDir_Click(object sender, EventArgs e)
        {
            //判断是否已到根目录
            if (CurrentDirList.Count == 1)
            {
                //处于根目录，不用操作
                return;
            }
            else
            {
                //删除List<FileNode>最后一个元素
                CurrentDirList.RemoveAt(CurrentDirList.Count - 1);
                //重建ListView
                updateList();
                //重写Label
                labelCurrentDir.Text = null;
                foreach (FileNode i in CurrentDirList)
                {
                    labelCurrentDir.Text += i.Name;
                    if (i.Name != "/")
                    {
                        labelCurrentDir.Text += "/";
                    }
                }
            }
        }

        /// <summary>
        /// 点击工具栏的“当前目录”标签后的响应事件
        /// 弹出等待用户输入要跳转的目录绝对路径，并跳转到指定的绝对路径
        /// </summary>
        private void labelCurrentDir_Click(object sender, EventArgs e)
        {
            //获取要跳转的目录路径
            string path = Interaction.InputBox("在此处输入要跳转的目录的绝对路径\n\n示例：/[目录1]/[目录2]/[目录3]/.../[目录n]", "切换当前目录", "", -1, -1);
            if (path == "")
            {
                //没有输入，退出处理
                return;
            }
            //对输入的字符串拆分
            string[] dirArray;
            dirArray = path.Split('/');
            //若输入时第一个字符不是'/'，则证明路径格式输入错误，系统返回错误信息
            if (dirArray[0] != "")
            {
                MessageBox.Show("错误：请输入正确的路径", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //开始按照次序检索目录并进入
            List<FileNode> dirList = new List<FileNode>();//根据当前指定绝对路径的目录索引，若修改成功则用此索引替换CurrentDirList，否则不做处理
            //往dirList里加入根目录的信息
            dirList.Add(CurrentDirList[0]);
            byte currentDirNodeIndex = 2;//用于指示当前目录的起始盘块号，初始为根目录(2)
            foreach (string dir in dirArray)
            {
                if (dir == "")
                {
                    //跳过根目录，索引下一个根目录的子目录
                    continue;
                }
                //开始查找当前目录项dir是否在currentDirNodeIndex中
                currentDirNodeIndex = dirList.Last().StartNode;
                byte[] currentDirBlock = new byte[64];//当前目录的块
                IOClass.FileRead(ref currentDirBlock, currentDirNodeIndex * 64, 64);
                string currentDirBlockString = ASCIIEncoding.ASCII.GetString(currentDirBlock);
                //从获得的block里查找有没有要进入的目录项的信息，如果没有则进入失败
                int i = 0;
                for (i = 0; i < 8; i++)
                {
                    string name = currentDirBlockString.Substring(i * 8, 3);
                    for (int j = 0; j < 3; j++)
                    {
                        if (name[j] == '\0')
                        {
                            name = name.Remove(j);
                            break;
                        }
                    }
                    byte attribute = currentDirBlock[i * 8 + 5];
                    //将dir与name进行比较，若相符则该项为要进入的项
                    if (name == dir && attribute == 8)
                    {
                        //相符
                        FileNode node = new FileNode();
                        node.Name = dir;
                        node.StartNode = currentDirBlock[i * 8 + 6];
                        //添加进临时索引表中
                        dirList.Add(node);
                        //修改当前目录的盘块号，指向该块
                        currentDirNodeIndex = node.StartNode;
                        //跳出for循环，返回foreach大循环
                        break;
                    }
                }
                //如果执行到此i=8，则说明当前节点没有所要进入的目录，索引失败
                if (i == 8)
                {
                    MessageBox.Show("错误：没有找到 " + dir + " 目录\n请检查输入的目录名是否正确", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //没有出现错误，继续寻找下一个目录
            }
            //循环执行完毕，得到正确的目录索引
            CurrentDirList = dirList;//修改当前打开文件索引为修改后的索引
            updateList();//刷新List视图
            //修改当前路径显示标签为修改后的路径
            if (path == "/")
            {
                labelCurrentDir.Text = path;
            }
            else
            {
                labelCurrentDir.Text = path + '/';
            }
        }

        /***************************************************************
         * 
         * 以下为点击右键菜单按钮后的响应事件
         * 
         ***************************************************************/
        /// <summary>指定右键菜单->删除选项点击后的响应事件</summary>
        private void 删除toolStripMenuItem_Click(object sender, EventArgs e)
        {
            //弹出提示框询问是否删除
            DialogResult result = (MessageBox.Show("确认删除？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (result == DialogResult.Yes)
            {
                //删除目录或文件
                //构建要删除的项的FileNode
                FileNode node = new FileNode();
                node.Name = mainListView.SelectedItems[0].SubItems[0].Text; //名称
                node.Type = mainListView.SelectedItems[0].SubItems[1].Text; //类型
                node.Attribute = mainListView.SelectedItems[0].SubItems[2].Text;//属性
                //获得节点的起始盘块号
                byte[] startNodeNum = new byte[1];
                startNodeNum = System.Text.Encoding.ASCII.GetBytes(mainListView.SelectedItems[0].SubItems[3].Text);
                //当起始盘块号为2位以上时，正确处理startNodeNum为[十位][个位]或[百位][十位][个位]的错误，从而得出正确的byte值
                if (startNodeNum.Length == 2)
                {
                    node.StartNode = (byte)((startNodeNum[0] - 0x30) * 10 + (startNodeNum[1] - 0x30));
                }
                else if (startNodeNum.Length == 3)
                {
                    node.StartNode = (byte)((startNodeNum[0] - 0x30) * 100 + (startNodeNum[1] - 0x30) * 10 + (startNodeNum[2] - 0x30));
                }
                else
                {
                    node.StartNode = (byte)(startNodeNum[0] - 0x30); //将ASCII的字符转化为byte格式的数字
                }
                //判断要删除的对象是否为目录，若为目录则需判断目录是否为空，若不为空则删除失败
                if (node.Attribute == "目录")
                {
                    byte[] nodeValue = new byte[64];
                    IOClass.FileRead(ref nodeValue, node.StartNode * 64, 64);
                    for (int i = 0; i < 64; i++)
                    {
                        if (nodeValue[i] != 0)
                        {
                            //目录不为空，删除失败
                            MessageBox.Show("错误：要删除的目录不为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                //开始删除
                Command.delete(ref node); //对磁盘文件进行删除操作
                //删除List索引
                mainListView.Items.RemoveAt(mainListView.SelectedItems[0].Index);
                //重建索引
                updateList();
                return;
            }
            else
            {
                return;
            }
        }

        /// <summary>指定右键菜单->刷新选项点击后的响应事件</summary>
        private void 刷新toolStripMenuItem_Click(object sender, EventArgs e)
        {
            //刷新视图
            updateList();
        }

        /// <summary>指定右键菜单->视图->大图标选项点击后的响应事件</summary>
        private void 大图标ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainListView.View = View.LargeIcon;
        }

        /// <summary>指定右键菜单->视图->小图标选项点击后的响应事件</summary>
        private void 小图标ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainListView.View = View.SmallIcon;
        }

        /// <summary>指定右键菜单->视图->平铺选项点击后的响应事件</summary>
        private void 平铺ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainListView.View = View.Tile;
        }

        /// <summary>指定右键菜单->视图->列表选项点击后的响应事件</summary>
        private void 列表ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainListView.View = View.List;
        }

        /// <summary>指定右键菜单->视图->详细信息选项点击后的响应事件</summary>
        private void 详细信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainListView.View = View.Details;
        }

        /// <summary>指定右键菜单->修改文件属性选项点击后的响应事件</summary>
        private void 修改文件属性toolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = mainListView.SelectedItems[0].SubItems[0].Text;
            string filetype = mainListView.SelectedItems[0].SubItems[1].Text;
            for (int i = filename.Length; i < 3; i++)
            {
                filename += '\0';
            }
            for (int i = filetype.Length; i < 2; i++)
            {
                filetype += '\0';
            }
            FormInputFileName form = new FormInputFileName();
            form.Text = "修改文件属性";
            form.isChangeAttribute();
            form.ShowDialog();
            string attribute = form.getFileAttribute();
            if (attribute == "")
            {
                return;
            }
            //找到文件节点在目录盘块的位置
            byte[] nodeinfo = new byte[64];
            IOClass.FileRead(ref nodeinfo, CurrentDirList.Last().StartNode * 64, 64);
            string nodeinfoString = ASCIIEncoding.ASCII.GetString(nodeinfo);
            for (int i = 0; i < 8; i++)
            {
                string name = nodeinfoString.Substring(i * 8, 3);
                string type = nodeinfoString.Substring(i * 8 + 3, 2);
                //比较该节点是否为文件所在节点
                if (name == filename && type == filetype)
                {
                    //找到该节点，将属性信息写入磁盘
                    byte attributeByte = 0;
                    switch (attribute)
                    {
                        case "普通文件":
                            attributeByte = 4;
                            break;
                        case "系统文件":
                            attributeByte = 2;
                            break;
                        case "只读文件":
                            attributeByte = 1;
                            break;
                        default:
                            MessageBox.Show("错误：请选择正确的属性", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    //写入属性值
                    byte[] attributeByteArray = new byte[1] { attributeByte };
                    IOClass.FileWrite(CurrentDirList.Last().StartNode * 64 + i * 8 + 5, ref attributeByteArray);
                }
            }
            //写入成功，刷新ListView
            updateList();
        }
    }

    
}
