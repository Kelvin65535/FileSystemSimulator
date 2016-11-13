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

namespace DiskOperationSystem
{
    partial class FormInputFileName
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.文件名label = new System.Windows.Forms.Label();
            this.checkBox普通 = new System.Windows.Forms.CheckBox();
            this.checkBox只读 = new System.Windows.Forms.CheckBox();
            this.checkBox系统 = new System.Windows.Forms.CheckBox();
            this.label属性 = new System.Windows.Forms.Label();
            this.label提示 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button确定 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 文件名label
            // 
            this.文件名label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.文件名label.AutoSize = true;
            this.文件名label.Location = new System.Drawing.Point(58, 101);
            this.文件名label.Name = "文件名label";
            this.文件名label.Size = new System.Drawing.Size(80, 18);
            this.文件名label.TabIndex = 0;
            this.文件名label.Text = "文件名：";
            // 
            // checkBox普通
            // 
            this.checkBox普通.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox普通.AutoSize = true;
            this.checkBox普通.Location = new System.Drawing.Point(151, 149);
            this.checkBox普通.Name = "checkBox普通";
            this.checkBox普通.Size = new System.Drawing.Size(106, 22);
            this.checkBox普通.TabIndex = 3;
            this.checkBox普通.Text = "普通文件";
            this.checkBox普通.UseVisualStyleBackColor = true;
            this.checkBox普通.CheckedChanged += new System.EventHandler(this.checkBox普通_CheckedChanged);
            // 
            // checkBox只读
            // 
            this.checkBox只读.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox只读.AutoSize = true;
            this.checkBox只读.Location = new System.Drawing.Point(151, 177);
            this.checkBox只读.Name = "checkBox只读";
            this.checkBox只读.Size = new System.Drawing.Size(106, 22);
            this.checkBox只读.TabIndex = 4;
            this.checkBox只读.Text = "只读文件";
            this.checkBox只读.UseVisualStyleBackColor = true;
            this.checkBox只读.CheckedChanged += new System.EventHandler(this.checkBox只读_CheckedChanged);
            // 
            // checkBox系统
            // 
            this.checkBox系统.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox系统.AutoSize = true;
            this.checkBox系统.Location = new System.Drawing.Point(151, 206);
            this.checkBox系统.Name = "checkBox系统";
            this.checkBox系统.Size = new System.Drawing.Size(106, 22);
            this.checkBox系统.TabIndex = 5;
            this.checkBox系统.Text = "系统文件";
            this.checkBox系统.UseVisualStyleBackColor = true;
            this.checkBox系统.CheckedChanged += new System.EventHandler(this.checkBox系统_CheckedChanged);
            // 
            // label属性
            // 
            this.label属性.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label属性.AutoSize = true;
            this.label属性.Location = new System.Drawing.Point(40, 149);
            this.label属性.Name = "label属性";
            this.label属性.Size = new System.Drawing.Size(98, 18);
            this.label属性.TabIndex = 6;
            this.label属性.Text = "文件属性：";
            // 
            // label提示
            // 
            this.label提示.AutoSize = true;
            this.label提示.Location = new System.Drawing.Point(40, 49);
            this.label提示.Name = "label提示";
            this.label提示.Size = new System.Drawing.Size(260, 18);
            this.label提示.TabIndex = 7;
            this.label提示.Text = "请输入要新建的文件名和属性：";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(151, 98);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(149, 29);
            this.textBoxName.TabIndex = 8;
            // 
            // button确定
            // 
            this.button确定.Location = new System.Drawing.Point(139, 245);
            this.button确定.Name = "button确定";
            this.button确定.Size = new System.Drawing.Size(83, 30);
            this.button确定.TabIndex = 9;
            this.button确定.Text = "确定";
            this.button确定.UseVisualStyleBackColor = true;
            this.button确定.Click += new System.EventHandler(this.button确定_Click);
            // 
            // FormInputFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 302);
            this.Controls.Add(this.button确定);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label提示);
            this.Controls.Add(this.label属性);
            this.Controls.Add(this.checkBox系统);
            this.Controls.Add(this.checkBox只读);
            this.Controls.Add(this.checkBox普通);
            this.Controls.Add(this.文件名label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInputFileName";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新建文件";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 文件名label;
        private System.Windows.Forms.CheckBox checkBox普通;
        private System.Windows.Forms.CheckBox checkBox只读;
        private System.Windows.Forms.CheckBox checkBox系统;
        private System.Windows.Forms.Label label属性;
        private System.Windows.Forms.Label label提示;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button确定;
    }
}