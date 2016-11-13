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
    class Command
    {
        /// <summary>
        /// 根据指定的目录名，新建一个子目录到当前目录下
        /// </summary>
        /// <param name="name">要新建的目录的名称的引用</param>
        public static void md(ref string name)
        {
            //临时变量
            byte[] buffer = new byte[64];//缓冲区
            char[] bufferToChar = new char[64];
            string stringFromBuffer;//将缓冲区的内容转换为字符串
            FileNode currentDirNode = Form1.CurrentDirList[Form1.CurrentDirList.Count - 1];   //获取列表的最后一个元素的节点信息
            IOClass.FileRead(ref buffer, (currentDirNode.StartNode * 64), 64);//读取节点内容
            bufferToChar = ASCIIEncoding.ASCII.GetChars(buffer);//转换bytes[]为char[]
            //判断是否重名
            for (int i = 0; i < 8; i++)
            {
                stringFromBuffer = new string(bufferToChar);
                //读入名称
                string temp = stringFromBuffer.Substring(i * 8, 3);
                //删除'\0'符号
                for (int j = 0; j < 3; j++)
                {
                    if (temp[j] == '\0')
                    {
                        //当发现了第一个'\0'就把该位置后的所有'\0'都删去
                        temp = temp.Remove(j);
                        break;
                    }
                }
                //
                if (name == temp && buffer[i * 8 + 5] == 8)
                {
                    MessageBox.Show("错误：与现有目录重名", "新建目录错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //判断block内是否有可以存放node的空间并写入
            for (int i = 0; i < 8; i++)
            {
                stringFromBuffer = new string(bufferToChar);
                //判断当前节点是否为空
                if (stringFromBuffer.Substring(i * 8 + 5, 1) == "\0")
                {
                    //若当前节点为空则录入node的信息到节点去
                    //录入节点信息
                    string s = null;//构造一个string用于存放节点信息，每个字符对应节点每个字节
                    s = s + name;//名字
                    if (name.Length < 3)
                    {
                        for (int j = name.Length; j < 3; j++)
                        {
                            s = s + '\0';
                        }
                    }
                    s = s + '\0' + '\0';//类型
                    s = s + (char)8;//属性
                    //获得空的盘块并写入起始盘块号
                    byte[] fatBytes = new byte[128];
                    IOClass.FileRead(ref fatBytes, 0, 128);
                    for (int j = 0; j < 128; j++)
                    {
                        if (fatBytes[j] == 0)
                        {
                            //找到空余盘块
                            s = s + (char)j;//起始盘块号
                            s = s + '\0';//文件大小
                            //修改FAT表
                            byte[] FATValue = new byte[1] { 0xff };
                            IOClass.FileWrite(j, ref FATValue);
                            //将节点写入块
                            byte[] byteinfo = new byte[8];
                            byteinfo = Encoding.ASCII.GetBytes(s);//将构造的string转换为byte数组，用于写入磁盘文件
                            IOClass.FileWrite((currentDirNode.StartNode * 64) + (i * 8), ref byteinfo);
                            //结束
                            return ;
                        }
                    }
                    continue;
                }
            }
        }

        /// <summary>
        /// 根据指定的文件名、文件类型、文件属性，新建文件到当前目录下
        /// </summary>
        /// <param name="name">要新建的文件的文件名的引用</param>
        /// <param name="type">要新建的文件的类型的引用</param>
        /// <param name="attribute">要新建的文件的属性的引用</param>
        public static void newFile(ref string name, ref string type, ref string attribute)
        {
            //临时变量
            byte[] buffer = new byte[64];//缓冲区
            char[] bufferToChar = new char[64];
            string stringFromBuffer;//将缓冲区的内容转换为字符串
            FileNode currentDirNode = Form1.CurrentDirList[Form1.CurrentDirList.Count - 1];   //获取列表的最后一个元素的节点信息
            IOClass.FileRead(ref buffer, (currentDirNode.StartNode * 64), 64);//读取节点内容
            bufferToChar = ASCIIEncoding.ASCII.GetChars(buffer);//转换bytes[]为char[]
            //判断是否重名
            for (int i = 0; i < 8; i++)
            {
                stringFromBuffer = new string(bufferToChar);
                //读入名称
                string tempName = stringFromBuffer.Substring(i * 8, 3);
                //读入类型
                string tempType = stringFromBuffer.Substring(i * 8 + 3, 2);
                //删除'\0'符号
                for (int j = 0; j < 3; j++)
                {
                    if (tempName[j] == '\0')
                    {
                        //当发现了第一个'\0'就把该位置后的所有'\0'都删去
                        tempName = tempName.Remove(j);
                        break;
                    }
                }
                for (int j = 0; j < 2; j++)
                {
                    if (tempType[j] == '\0')
                    {
                        //当发现了第一个'\0'就把该位置后的所有'\0'都删去
                        tempType = tempType.Remove(j);
                        break;
                    }
                }
                //比较是否重名
                if (name == tempName && type == tempType)
                {
                    MessageBox.Show("错误：与现有文件重名", "新建目录错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //没有发生重名，写入索引
            //判断block内是否有可以存放node的空间并写入
            for (int i = 0; i < 8; i++)
            {
                stringFromBuffer = new string(bufferToChar);
                //判断当前节点是否为空
                if (stringFromBuffer.Substring(i * 8 + 5, 1) == "\0")
                {
                    //若当前节点为空则录入node的信息到节点去
                    Console.WriteLine("在函数md()中: 当前目录第 " + i + " 号节点为空");
                    //录入节点信息
                    string s = null;//构造一个string用于存放节点信息，每个字符对应节点每个字节
                    s = s + name;//名字
                    if (name.Length < 3)
                    {
                        for (int j = name.Length; j < 3; j++)
                        {
                            s = s + '\0';
                        }
                    }
                    s = s + type;//类型
                    if (type.Length < 2)
                    {
                        for (int j = type.Length; j < 2; j++)
                        {
                            s = s + '\0';
                        }
                    }
                    //录入属性
                    switch (attribute)
                    {
                        case "普通文件":
                            s = s + (char)4;
                            break;
                        case "只读文件":
                            s = s + (char)1;
                            break;
                        case "系统文件":
                            s = s + (char)2;
                            break;
                        default:
                            MessageBox.Show("错误：请选择的正确的文件属性", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    //获得空的盘块并写入起始盘块号
                    byte[] fatBytes = new byte[128];
                    IOClass.FileRead(ref fatBytes, 0, 128);
                    for (int j = 0; j < 128; j++)
                    {
                        if (fatBytes[j] == 0)
                        {
                            //找到空余盘块
                            s = s + (char)j;//起始盘块号
                            s = s + (char)1;//文件大小
                            //修改FAT表
                            byte[] FATValue = new byte[1] { 0xff };
                            IOClass.FileWrite(j, ref FATValue);
                            //将节点写入块
                            byte[] byteinfo = new byte[8];
                            byteinfo = Encoding.ASCII.GetBytes(s);//将构造的string转换为byte数组，用于写入磁盘文件
                            IOClass.FileWrite((currentDirNode.StartNode * 64) + (i * 8), ref byteinfo);
                            //结束
                            return;
                        }
                    }
                    continue;
                }
            }
        }

        /// <summary>
        /// 删除当前目录内FileNode指定的子文件或子目录
        /// </summary>
        /// <param name="node">要删除的文件节点信息</param>
        public static void delete(ref FileNode node)
        {
            //获取文件所在的节点号
            byte nodeIndex = 0;
            nodeIndex = node.StartNode; //起始盘块号
            //删除当前目录的索引
            byte currentDirStartNode = Form1.CurrentDirList.Last().StartNode;
            char[] buffer = new char[64];
            byte[] bufferByte = new byte[64];
            IOClass.FileRead(ref bufferByte, (int)currentDirStartNode * 64, 64);
            buffer = ASCIIEncoding.ASCII.GetChars(bufferByte);
            string bufferString = new string(buffer);
            for (int i = 0; i < 8; i++)
            {
                string name = bufferString.Substring(i * 8, 3);
                string type = bufferString.Substring(i * 8 + 3, 2);
                for (int j = node.Name.Length; j < 3; j++)
                {
                    node.Name += '\0';
                }
                for (int j = node.Type.Length; j < 2; j++)
                {
                    node.Type += '\0';
                }
                //比较文件名是否匹配
                if (node.Name == name && node.Type == type)
                {
                    //匹配则删除该索引
                    byte[] nodeinfo = new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
                    IOClass.FileWrite(currentDirStartNode * 64 + i * 8, ref nodeinfo);
                    //删除FAT表的节点信息
                    //获得整个FAT表
                    byte[] fat = new byte[128];
                    IOClass.FileRead(ref fat, 0, 128);
                    //索引块信息
                    byte indexOfFAT = node.StartNode;//要删除节点的起始盘块号
                    if (fat[indexOfFAT] == 0xFF)
                    {
                        fat[indexOfFAT] = 0;
                        byte[] fatValue = new byte[1] { 0 };
                        IOClass.FileWrite(indexOfFAT, ref fatValue);
                        //删除整个块
                        byte[] block = new byte[64];
                        for (int j = 0; j < 64; j++)
                        {
                            block[j] = 0;
                        }
                        IOClass.FileWrite(indexOfFAT * 64, ref block);
                        //删除成功
                        MessageBox.Show("删除成功", "删除", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    while (fat[indexOfFAT] != 0xFF) //当有多个节点时迭代删除
                    {
                        byte nextIndex = fat[indexOfFAT];//防止被删除后丢失
                        byte[] fatValue = new byte[1] { 0 };
                        IOClass.FileWrite(indexOfFAT, ref fatValue);
                        //删除整个块
                        byte[] block = new byte[64];
                        for (int j = 0; j < 64; j++)
                        {
                            block[j] = 0;
                        }
                        IOClass.FileWrite(indexOfFAT * 64, ref block);
                        indexOfFAT = nextIndex;   //设置下一个节点
                        if (fat[indexOfFAT] == 0xFF)    //删除到最后一个节点
                        {
                            fat[indexOfFAT] = 0;
                            fatValue = new byte[1] { 0 };
                            IOClass.FileWrite(indexOfFAT, ref fatValue);
                            //删除整个块
                            block = new byte[64];
                            for (int j = 0; j < 64; j++)
                            {
                                block[j] = 0;
                            }
                            IOClass.FileWrite(indexOfFAT * 64, ref block);
                            //删除成功
                            MessageBox.Show("删除成功", "删除", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 读取从指定的起始盘块号开始的整个文本文件的字符串，只限于读取文本文件
        /// </summary>
        /// <param name="text">用于存放读取出的内容的字符串引用</param>
        /// <param name="startNodeNum">需要读取的文本文件的起始盘块号的引用</param>
        public static void getFileText(ref string text, ref byte startNodeNum)
        {
            //获得整个FAT表
            byte[] fat = new byte[128];
            for (int i = 0; i < 128; i++)
            {
                fat[i] = 0;
            }
            IOClass.FileRead(ref fat, 0, 128);
            //初始化string
            text = null;
            //索引块信息
            byte indexOfFAT = startNodeNum;//文件的的起始盘块号
            if (fat[indexOfFAT] == 0xFF)
            {
                //读取整个块的内容
                byte[] block = new byte[64];
                IOClass.FileRead(ref block, indexOfFAT * 64, 64);
                //将byte[]转换为string
                text += Encoding.ASCII.GetString(block);
                return;
            }
            while (fat[indexOfFAT] != 0xFF) //当有多个节点时迭代读取
            {
                //读取整个块的内容
                byte[] block = new byte[64];
                IOClass.FileRead(ref block, indexOfFAT * 64, 64);
                //将byte[]转换为string
                text += Encoding.ASCII.GetString(block);
                indexOfFAT = fat[indexOfFAT];   //设置下一个节点
            }
            if (fat[indexOfFAT] == 0xFF)    //索引到最后一个节点
            {
                //读取整个块的内容
                byte[] block = new byte[64];
                IOClass.FileRead(ref block, indexOfFAT * 64, 64);
                //将byte[]转换为string
                text += Encoding.ASCII.GetString(block);
                //读取成功
                return;
            }
        }

        /// <summary>
        /// 指定要写入的文件内容和该文件的起始盘块号，将内容写入磁盘中，并返回修改后的文件占用的盘块数量
        /// </summary>
        /// <param name="text">要写入的文本字符串的引用</param>
        /// <param name="startNodeNum">要写入的文件的起始盘块号的引用</param>
        /// <returns>返回修改后的文件占用的盘块数量</returns>
        public static byte saveFileText(ref string text, ref byte startNodeNum)
        {
            //局部变量
            byte usedBlockNum = 0; //在保存过程中统计文件使用的块数


            //删除原有文件内容
            //获得整个FAT表
            byte[] fat = new byte[128];
            byte[] temp = new byte[1];//临时变量
            IOClass.FileRead(ref fat, 0, 128);
            //索引块信息
            byte indexOfFAT = startNodeNum;//要删除节点的起始盘块号

            //当有多个节点时迭代删除，直到最后一个盘块为止（最后一个盘块未删除）
            while (fat[indexOfFAT] != 0xFF) 
            {
                byte nextIndex = fat[indexOfFAT];//防止被删除后丢失
                temp = new byte[1] { 0 };
                IOClass.FileWrite(indexOfFAT, ref temp);
                //删除整个块
                byte[] block = new byte[64];
                for (int j = 0; j < 64; j++)
                {
                    block[j] = 0;
                }
                IOClass.FileWrite(indexOfFAT * 64, ref block);
                indexOfFAT = nextIndex;  //设置下一个节点
            }
            //当到最后一个节点时直接删除
            if (fat[indexOfFAT] == 0xFF)
            {
                fat[indexOfFAT] = 0;
                temp = new byte[1] { 0 };
                IOClass.FileWrite(indexOfFAT, ref temp);
                //删除整个块
                byte[] block = new byte[64];
                for (int j = 0; j < 64; j++)
                {
                    block[j] = 0;
                }
                IOClass.FileWrite(indexOfFAT * 64, ref block);
                //删除成功
                //MessageBox.Show("删除成功", "删除", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //return;
            }

            //重新写入文件内容
            //获得空的盘块并写入起始盘块号
            indexOfFAT = startNodeNum;
            string textToWritePerBlock = null; //每一块要写入的文本内容，最多64个字节
            while (text.Length > 64)//当text长度超过一个盘块（64字节）时每分割64字节迭代存入
            {
                textToWritePerBlock = text.Substring(0, 64);//截取64个字节
                text = text.Remove(0, 64);
                //将该64字节写入块中
                byte[] textBytes = new byte[64];
                for (int i = 0; i < 64; i++)
                {
                    textBytes[i] = 0;
                }
                textBytes = ASCIIEncoding.ASCII.GetBytes(textToWritePerBlock);
                usedBlockNum++;
                //将索引写入FAT表
                IOClass.FileWrite(indexOfFAT * 64, ref textBytes);
                fat[indexOfFAT] = 0xff;
                //在FAT表找到下一个空闲块，将indexOfFat指向该块，同时把该块的信息写入磁盘的FAT表中
                for (byte i = 0; i < 128; i++)
                {
                    if (fat[i] == 0)
                    {
                        fat[indexOfFAT] = i;
                        byte[] fatvalue = new byte[1] { fat[indexOfFAT] };
                        IOClass.FileWrite(indexOfFAT, ref fatvalue);
                        indexOfFAT = i;
                        break;
                    }
                }
            }
            //当写入到最后一个盘块（即text的长度小于64字节时），此时indexOfFAT指向的是文件最后一个盘块的盘块号
            fat[indexOfFAT] = 0xFF;
            temp = new byte[1] { fat[indexOfFAT] };
            IOClass.FileWrite(indexOfFAT, ref temp);
            //写入盘块
            byte[] tempText = new byte[64];
            for (int i = 0; i < 64; i++)
            {
                tempText[i] = 0;
            }
            textToWritePerBlock = text;
            tempText = ASCIIEncoding.ASCII.GetBytes(textToWritePerBlock);
            //写入块
            IOClass.FileWrite(indexOfFAT * 64, ref tempText);
            usedBlockNum++;
            //写入结束
            //返回在写入过程中使用的块的数量
            return usedBlockNum;
        }

    }
}
