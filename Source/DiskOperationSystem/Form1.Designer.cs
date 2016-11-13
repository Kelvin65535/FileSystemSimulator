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
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.目录ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详细信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainListView = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAttribute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStartblock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.视图toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.大图标ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.平铺ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.列表ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.详细信息ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改文件属性toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.刷新toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelShowCurrentDir = new System.Windows.Forms.Label();
            this.labelCurrentDir = new System.Windows.Forms.Label();
            this.toolTipBtnDirUp = new System.Windows.Forms.ToolTip(this.components);
            this.buttonUpDir = new System.Windows.Forms.Button();
            this.iconListonListView = new System.Windows.Forms.ImageList(this.components);
            this.mainMenuStrip.SuspendLayout();
            this.mainContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem1,
            this.视图ToolStripMenuItem,
            this.关于toolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mainMenuStrip.Size = new System.Drawing.Size(574, 35);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem1
            // 
            this.文件ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem1});
            this.文件ToolStripMenuItem1.Name = "文件ToolStripMenuItem1";
            this.文件ToolStripMenuItem1.Size = new System.Drawing.Size(62, 29);
            this.文件ToolStripMenuItem1.Text = "文件";
            // 
            // 新建ToolStripMenuItem1
            // 
            this.新建ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.目录ToolStripMenuItem1,
            this.文件ToolStripMenuItem2});
            this.新建ToolStripMenuItem1.Name = "新建ToolStripMenuItem1";
            this.新建ToolStripMenuItem1.Size = new System.Drawing.Size(135, 30);
            this.新建ToolStripMenuItem1.Text = "新建";
            // 
            // 目录ToolStripMenuItem1
            // 
            this.目录ToolStripMenuItem1.Name = "目录ToolStripMenuItem1";
            this.目录ToolStripMenuItem1.Size = new System.Drawing.Size(135, 30);
            this.目录ToolStripMenuItem1.Text = "目录";
            this.目录ToolStripMenuItem1.Click += new System.EventHandler(this.目录ToolStripMenuItem1_Click);
            // 
            // 文件ToolStripMenuItem2
            // 
            this.文件ToolStripMenuItem2.Name = "文件ToolStripMenuItem2";
            this.文件ToolStripMenuItem2.Size = new System.Drawing.Size(135, 30);
            this.文件ToolStripMenuItem2.Text = "文件";
            this.文件ToolStripMenuItem2.Click += new System.EventHandler(this.文件ToolStripMenuItem2_Click);
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大图标ToolStripMenuItem,
            this.小图标ToolStripMenuItem,
            this.平铺ToolStripMenuItem,
            this.列表ToolStripMenuItem,
            this.详细信息ToolStripMenuItem});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 大图标ToolStripMenuItem
            // 
            this.大图标ToolStripMenuItem.Name = "大图标ToolStripMenuItem";
            this.大图标ToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.大图标ToolStripMenuItem.Text = "大图标";
            this.大图标ToolStripMenuItem.Click += new System.EventHandler(this.大图标ToolStripMenuItem_Click);
            // 
            // 小图标ToolStripMenuItem
            // 
            this.小图标ToolStripMenuItem.Name = "小图标ToolStripMenuItem";
            this.小图标ToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.小图标ToolStripMenuItem.Text = "小图标";
            this.小图标ToolStripMenuItem.Click += new System.EventHandler(this.小图标ToolStripMenuItem_Click);
            // 
            // 平铺ToolStripMenuItem
            // 
            this.平铺ToolStripMenuItem.Name = "平铺ToolStripMenuItem";
            this.平铺ToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.平铺ToolStripMenuItem.Text = "平铺";
            this.平铺ToolStripMenuItem.Click += new System.EventHandler(this.平铺ToolStripMenuItem_Click);
            // 
            // 列表ToolStripMenuItem
            // 
            this.列表ToolStripMenuItem.Name = "列表ToolStripMenuItem";
            this.列表ToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.列表ToolStripMenuItem.Text = "列表";
            this.列表ToolStripMenuItem.Click += new System.EventHandler(this.列表ToolStripMenuItem_Click);
            // 
            // 详细信息ToolStripMenuItem
            // 
            this.详细信息ToolStripMenuItem.Name = "详细信息ToolStripMenuItem";
            this.详细信息ToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.详细信息ToolStripMenuItem.Text = "详细信息";
            this.详细信息ToolStripMenuItem.Click += new System.EventHandler(this.详细信息ToolStripMenuItem_Click);
            // 
            // 关于toolStripMenuItem
            // 
            this.关于toolStripMenuItem.Name = "关于toolStripMenuItem";
            this.关于toolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.关于toolStripMenuItem.Text = "关于";
            this.关于toolStripMenuItem.Click += new System.EventHandler(this.关于toolStripMenuItem_Click);
            // 
            // mainListView
            // 
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderType,
            this.columnHeaderAttribute,
            this.columnHeaderStartblock,
            this.columnHeaderLength});
            this.mainListView.ContextMenuStrip = this.mainContextMenuStrip;
            this.mainListView.Location = new System.Drawing.Point(0, 81);
            this.mainListView.Margin = new System.Windows.Forms.Padding(4);
            this.mainListView.Name = "mainListView";
            this.mainListView.Size = new System.Drawing.Size(572, 418);
            this.mainListView.TabIndex = 1;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.View = System.Windows.Forms.View.Details;
            this.mainListView.DoubleClick += new System.EventHandler(this.mainListView_DoubleClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "名称";
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "类型";
            // 
            // columnHeaderAttribute
            // 
            this.columnHeaderAttribute.Text = "属性";
            // 
            // columnHeaderStartblock
            // 
            this.columnHeaderStartblock.Text = "起始块";
            // 
            // columnHeaderLength
            // 
            this.columnHeaderLength.Text = "长度";
            // 
            // mainContextMenuStrip
            // 
            this.mainContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.视图toolStripMenuItem1,
            this.toolStripSeparator2,
            this.新建ToolStripMenuItem,
            this.重命名toolStripMenuItem,
            this.删除toolStripMenuItem,
            this.修改文件属性toolStripMenuItem,
            this.toolStripSeparator1,
            this.刷新toolStripMenuItem,
            this.属性ToolStripMenuItem});
            this.mainContextMenuStrip.Name = "mainContextMenuStrip";
            this.mainContextMenuStrip.Size = new System.Drawing.Size(212, 259);
            this.mainContextMenuStrip.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.mainContextMenuStrip_Closed);
            this.mainContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.mainContextMenuStrip_Opening);
            // 
            // 视图toolStripMenuItem1
            // 
            this.视图toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大图标ToolStripMenuItem1,
            this.小图标ToolStripMenuItem1,
            this.平铺ToolStripMenuItem1,
            this.列表ToolStripMenuItem1,
            this.详细信息ToolStripMenuItem1});
            this.视图toolStripMenuItem1.Name = "视图toolStripMenuItem1";
            this.视图toolStripMenuItem1.Size = new System.Drawing.Size(211, 30);
            this.视图toolStripMenuItem1.Text = "视图";
            // 
            // 大图标ToolStripMenuItem1
            // 
            this.大图标ToolStripMenuItem1.Name = "大图标ToolStripMenuItem1";
            this.大图标ToolStripMenuItem1.Size = new System.Drawing.Size(173, 30);
            this.大图标ToolStripMenuItem1.Text = "大图标";
            this.大图标ToolStripMenuItem1.Click += new System.EventHandler(this.大图标ToolStripMenuItem1_Click);
            // 
            // 小图标ToolStripMenuItem1
            // 
            this.小图标ToolStripMenuItem1.Name = "小图标ToolStripMenuItem1";
            this.小图标ToolStripMenuItem1.Size = new System.Drawing.Size(173, 30);
            this.小图标ToolStripMenuItem1.Text = "小图标";
            this.小图标ToolStripMenuItem1.Click += new System.EventHandler(this.小图标ToolStripMenuItem1_Click);
            // 
            // 平铺ToolStripMenuItem1
            // 
            this.平铺ToolStripMenuItem1.Name = "平铺ToolStripMenuItem1";
            this.平铺ToolStripMenuItem1.Size = new System.Drawing.Size(173, 30);
            this.平铺ToolStripMenuItem1.Text = "平铺";
            this.平铺ToolStripMenuItem1.Click += new System.EventHandler(this.平铺ToolStripMenuItem1_Click);
            // 
            // 列表ToolStripMenuItem1
            // 
            this.列表ToolStripMenuItem1.Name = "列表ToolStripMenuItem1";
            this.列表ToolStripMenuItem1.Size = new System.Drawing.Size(173, 30);
            this.列表ToolStripMenuItem1.Text = "列表";
            this.列表ToolStripMenuItem1.Click += new System.EventHandler(this.列表ToolStripMenuItem1_Click);
            // 
            // 详细信息ToolStripMenuItem1
            // 
            this.详细信息ToolStripMenuItem1.Name = "详细信息ToolStripMenuItem1";
            this.详细信息ToolStripMenuItem1.Size = new System.Drawing.Size(173, 30);
            this.详细信息ToolStripMenuItem1.Text = "详细信息";
            this.详细信息ToolStripMenuItem1.Click += new System.EventHandler(this.详细信息ToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(208, 6);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.目录ToolStripMenuItem,
            this.文件ToolStripMenuItem});
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.新建ToolStripMenuItem.Text = "新建...";
            // 
            // 目录ToolStripMenuItem
            // 
            this.目录ToolStripMenuItem.Name = "目录ToolStripMenuItem";
            this.目录ToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.目录ToolStripMenuItem.Text = "目录";
            this.目录ToolStripMenuItem.Click += new System.EventHandler(this.目录ToolStripMenuItem_Click);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.文件ToolStripMenuItem.Text = "文件";
            this.文件ToolStripMenuItem.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
            // 
            // 重命名toolStripMenuItem
            // 
            this.重命名toolStripMenuItem.Name = "重命名toolStripMenuItem";
            this.重命名toolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.重命名toolStripMenuItem.Text = "重命名";
            this.重命名toolStripMenuItem.Click += new System.EventHandler(this.重命名toolStripMenuItem_Click);
            // 
            // 删除toolStripMenuItem
            // 
            this.删除toolStripMenuItem.Name = "删除toolStripMenuItem";
            this.删除toolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.删除toolStripMenuItem.Text = "删除";
            this.删除toolStripMenuItem.Click += new System.EventHandler(this.删除toolStripMenuItem_Click);
            // 
            // 修改文件属性toolStripMenuItem
            // 
            this.修改文件属性toolStripMenuItem.Name = "修改文件属性toolStripMenuItem";
            this.修改文件属性toolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.修改文件属性toolStripMenuItem.Text = "修改文件属性";
            this.修改文件属性toolStripMenuItem.Click += new System.EventHandler(this.修改文件属性toolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // 刷新toolStripMenuItem
            // 
            this.刷新toolStripMenuItem.Name = "刷新toolStripMenuItem";
            this.刷新toolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.刷新toolStripMenuItem.Text = "刷新";
            this.刷新toolStripMenuItem.Click += new System.EventHandler(this.刷新toolStripMenuItem_Click);
            // 
            // 属性ToolStripMenuItem
            // 
            this.属性ToolStripMenuItem.Name = "属性ToolStripMenuItem";
            this.属性ToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.属性ToolStripMenuItem.Text = "属性";
            this.属性ToolStripMenuItem.Click += new System.EventHandler(this.属性ToolStripMenuItem_Click);
            // 
            // labelShowCurrentDir
            // 
            this.labelShowCurrentDir.AutoSize = true;
            this.labelShowCurrentDir.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelShowCurrentDir.Location = new System.Drawing.Point(62, 45);
            this.labelShowCurrentDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowCurrentDir.Name = "labelShowCurrentDir";
            this.labelShowCurrentDir.Size = new System.Drawing.Size(134, 31);
            this.labelShowCurrentDir.TabIndex = 2;
            this.labelShowCurrentDir.Text = "当前目录：";
            // 
            // labelCurrentDir
            // 
            this.labelCurrentDir.AutoSize = true;
            this.labelCurrentDir.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCurrentDir.Location = new System.Drawing.Point(192, 45);
            this.labelCurrentDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentDir.Name = "labelCurrentDir";
            this.labelCurrentDir.Size = new System.Drawing.Size(206, 31);
            this.labelCurrentDir.TabIndex = 3;
            this.labelCurrentDir.Text = "（显示当前路径）";
            this.toolTipBtnDirUp.SetToolTip(this.labelCurrentDir, "点击此处输入绝对路径并跳转");
            this.labelCurrentDir.Click += new System.EventHandler(this.labelCurrentDir_Click);
            // 
            // buttonUpDir
            // 
            this.buttonUpDir.BackColor = System.Drawing.SystemColors.Control;
            this.buttonUpDir.BackgroundImage = global::DiskOperationSystem.Properties.Resources.left;
            this.buttonUpDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpDir.FlatAppearance.BorderSize = 0;
            this.buttonUpDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpDir.Location = new System.Drawing.Point(18, 42);
            this.buttonUpDir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpDir.Name = "buttonUpDir";
            this.buttonUpDir.Size = new System.Drawing.Size(34, 34);
            this.buttonUpDir.TabIndex = 4;
            this.toolTipBtnDirUp.SetToolTip(this.buttonUpDir, "返回上一级目录");
            this.buttonUpDir.UseVisualStyleBackColor = false;
            this.buttonUpDir.Click += new System.EventHandler(this.buttonUpDir_Click);
            // 
            // iconListonListView
            // 
            this.iconListonListView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconListonListView.ImageStream")));
            this.iconListonListView.TransparentColor = System.Drawing.Color.Transparent;
            this.iconListonListView.Images.SetKeyName(0, "file.png");
            this.iconListonListView.Images.SetKeyName(1, "folder.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 519);
            this.Controls.Add(this.buttonUpDir);
            this.Controls.Add(this.labelCurrentDir);
            this.Controls.Add(this.labelShowCurrentDir);
            this.Controls.Add(this.mainListView);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "磁盘文件系统";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ListView mainListView;

        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderType;
        private ColumnHeader columnHeaderAttribute;
        private ColumnHeader columnHeaderStartblock;
        private ColumnHeader columnHeaderLength;

        private ContextMenuStrip mainContextMenuStrip;
        private ToolStripMenuItem 新建ToolStripMenuItem;
        private ToolStripMenuItem 目录ToolStripMenuItem;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private Label labelShowCurrentDir;
        private Label labelCurrentDir;
        private ToolStripMenuItem 属性ToolStripMenuItem;
        private ToolStripMenuItem 重命名toolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 文件ToolStripMenuItem1;
        private ToolStripMenuItem 新建ToolStripMenuItem1;
        private ToolStripMenuItem 目录ToolStripMenuItem1;
        private ToolStripMenuItem 文件ToolStripMenuItem2;
        private ToolStripMenuItem 视图ToolStripMenuItem;
        private ToolStripMenuItem 大图标ToolStripMenuItem;
        private ToolStripMenuItem 小图标ToolStripMenuItem;
        private ToolStripMenuItem 平铺ToolStripMenuItem;
        private ToolStripMenuItem 列表ToolStripMenuItem;
        private ToolStripMenuItem 详细信息ToolStripMenuItem;
        private Button buttonUpDir;
        private ToolTip toolTipBtnDirUp;
        private ImageList iconListonListView;
        private ToolStripMenuItem 删除toolStripMenuItem;

        /// <summary>
        /// 根据当前目录更新ListView里的内容
        /// </summary>
        public void updateList()
        {
            //开始List的数据更新，UI暂时挂起
            mainListView.BeginUpdate();
            //清除List内的所有元素以重新写入
            mainListView.Items.Clear();
            //设定List内元素要引用的图标集
            mainListView.LargeImageList = iconListonListView;
            mainListView.SmallImageList = iconListonListView;
            //临时变量
            char[] buffer = new char[64];//缓冲区
            byte[] bufferBytes = new byte[64];
            string stringFromBuffer;//将缓冲区的内容转换为字符串
            string temp;//可重复使用的用于临时的字符串变量

            //根据当前目录的信息读取目录的节点
            FileNode node = CurrentDirList[CurrentDirList.Count - 1];   //获取列表的最后一个元素的节点信息
            IOClass.FileRead(ref bufferBytes, (node.StartNode * 64), 64);
            buffer = System.Text.Encoding.ASCII.GetChars(bufferBytes);
            //新建项
            ListViewItem item = new ListViewItem();
            for (int i = 0; i < 8; i++)
            {
                item = new ListViewItem();  //重置项
                stringFromBuffer = new string(buffer);
                //判断当前节点是否为空
                if (stringFromBuffer.Substring(i * 8 + 5, 1) == "\0")
                {
                    //若当前节点为空则跳过录入当前节点信息
                    //Console.WriteLine("在函数updateList()中: 当前目录第 " + i + " 号节点为空");
                    continue;
                }
                //修改主项为名称
                temp = stringFromBuffer.Substring(i * 8, 3);
                string name = null;//保存排除'\0'后的字符串
                for (int j = 0; j < 3; j++)
                {
                    if (temp[j] == '\0')
                    {
                        break;  //跳过为0的字节，避免录入结束符'\0'
                    }
                    name += temp[j];
                }
                item.Text = name;
                //添加子项-类型
                temp = stringFromBuffer.Substring(i * 8 + 3, 2);
                string type = null;//保存排除'\0'后的字符串
                for (int j = 0; j < 2; j++)
                {
                    if (temp[j] == '\0')
                    {
                        break;  //跳过为0的字节，避免录入结束符'\0'
                    }
                    type += temp[j];
                }
                item.SubItems.Add(type);
                //添加子项-属性
                System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();
                int AttributeCode = ascii.GetBytes(stringFromBuffer.Substring(i * 8 + 5, 1))[0];
                if (AttributeCode == 8)
                {
                    item.SubItems.Add("目录");
                    item.ImageIndex = 1;//根据属性设置图标
                }
                else if (AttributeCode == 4)
                {
                    item.SubItems.Add("普通文件");
                    item.ImageIndex = 0;//根据属性设置图标
                }
                else if (AttributeCode == 2)
                {
                    item.SubItems.Add("系统文件");
                    item.ImageIndex = 0;//根据属性设置图标
                }
                else if (AttributeCode == 1)
                {
                    item.SubItems.Add("只读文件");
                    item.ImageIndex = 0;//根据属性设置图标
                }
                else
                {
                    //为空
                }
                //添加子项-起始块
                item.SubItems.Add(((int)(buffer[i * 8 + 6])).ToString());
                //添加子项-大小
                item.SubItems.Add((buffer[i * 8 + 7] * 64).ToString());
                //将项添加进List
                mainListView.Items.Add(item);
            }
            

            //结束数据处理
            mainListView.EndUpdate();
        }

        /// <summary>
        /// 双击List内项目时触发以下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainListView_DoubleClick(object sender, EventArgs e)
        {
            if (mainListView.SelectedItems.Count == 1)
            {
                //判断是否为目录，如果为目录则跳转到目录内
                if (mainListView.SelectedItems[0].SubItems[2].Text == "目录")
                {
                    //获取选择目录的节点信息
                    FileNode dir = new FileNode();
                    dir.Name = mainListView.SelectedItems[0].SubItems[0].Text;
                    byte[] startNodeNum = new byte[1];
                    startNodeNum = System.Text.Encoding.ASCII.GetBytes(mainListView.SelectedItems[0].SubItems[3].Text);
                    //当起始盘块号为2位以上时，正确处理startNodeNum为[十位][个位]或[百位][十位][个位]的错误，从而得出正确的byte值
                    if (startNodeNum.Length == 2)
                    {
                        dir.StartNode = (byte)((startNodeNum[0] - 0x30) * 10 + (startNodeNum[1] - 0x30));
                    }else if (startNodeNum.Length == 3)
                    {
                        dir.StartNode = (byte)((startNodeNum[0] - 0x30) * 100 + (startNodeNum[1] - 0x30) * 10 + (startNodeNum[2] - 0x30));
                    }
                    else
                    {
                        dir.StartNode = (byte)(startNodeNum[0] - 0x30); //将ASCII的字符转化为byte格式的数字
                    }
                    
                    //往List<当前打开目录节点>内添加节点
                    CurrentDirList.Add(dir);
                    //刷新指示当前目录位置的label
                    labelCurrentDir.Text = null;
                    foreach (FileNode i in CurrentDirList)
                    {
                        labelCurrentDir.Text += i.Name;
                        if (i.Name != "/")
                        {
                            labelCurrentDir.Text += "/";//补充目录分割符
                        }
                    }
                    //刷新ListView
                    updateList();
                }
                else
                {
                    //双击文件时进行以下操作：
                    //构建当前选择文件的FileNode信息
                    string name = mainListView.SelectedItems[0].SubItems[0].Text;
                    string type = mainListView.SelectedItems[0].SubItems[1].Text;
                    string attribute = mainListView.SelectedItems[0].SubItems[2].Text;
                    byte startNode;
                    byte[] startNodeNumArray = new byte[1];
                    startNodeNumArray = System.Text.Encoding.ASCII.GetBytes(mainListView.SelectedItems[0].SubItems[3].Text);
                    //当起始盘块号为2位以上时，正确处理startNodeNum为[十位][个位]或[百位][十位][个位]的错误，从而得出正确的byte值
                    if (startNodeNumArray.Length == 2)
                    {
                        startNode = (byte)((startNodeNumArray[0] - 0x30) * 10 + (startNodeNumArray[1] - 0x30));
                    }
                    else if (startNodeNumArray.Length == 3)
                    {
                        startNode = (byte)((startNodeNumArray[0] - 0x30) * 100 + (startNodeNumArray[1] - 0x30) * 10 + (startNodeNumArray[2] - 0x30));
                    }
                    else
                    {
                        startNode = (byte)(startNodeNumArray[0] - 0x30); //将ASCII的字符转化为byte格式的数字
                    }
                    FileNode node = new FileNode(ref name, ref type, ref attribute, ref startNode);

                    //判断文件是否已在已打开文件表中，若存在则提示已打开错误
                    foreach (FileNode item in OpenFileTable)
                    {
                        if (item.Name == name && item.Type == type)
                        {
                            //文件信息已存在已打开文件表中，打开失败
                            MessageBox.Show("错误：文件已打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    //将文件节点信息加入到已打开文件表中
                    OpenFileTable.Add(node);

                    //继续打开文件
                    //获取文件内容到字符串中
                    string s = null;//保存文件内容的字符串
                    Command.getFileText(ref s, ref startNode);
                    FormShowFileText form = new FormShowFileText();
                    form.Text = "文件 " + node.Name + "." + node.Type;
                    form.setCurrentNode(ref node);//将当前打开文件的节点信息传入Form中
                    //根据打开文件的属性设置TextBox是否允许修改
                    if (node.Attribute == "只读文件")
                    {
                        form.Text += " (只读）";
                        form.setTextBoxReadOnly(true);
                    }
                    form.setText(ref s);//将文件内容传入Form中
                    form.Show();
                }
            }
        }

        private ToolStripMenuItem 刷新toolStripMenuItem;
        private ToolStripMenuItem 视图toolStripMenuItem1;
        private ToolStripMenuItem 大图标ToolStripMenuItem1;
        private ToolStripMenuItem 小图标ToolStripMenuItem1;
        private ToolStripMenuItem 平铺ToolStripMenuItem1;
        private ToolStripMenuItem 列表ToolStripMenuItem1;
        private ToolStripMenuItem 详细信息ToolStripMenuItem1;
        private ToolStripMenuItem 关于toolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 修改文件属性toolStripMenuItem;
    }
}

