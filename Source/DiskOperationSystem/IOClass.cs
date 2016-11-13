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


using System.IO;

namespace DiskOperationSystem
{
    /// <summary>
    /// IOClass类 包含对磁盘模拟文件disk进行读写操作的方法
    /// </summary>
    class IOClass
    {
        /// <summary>
        /// 表示磁盘文件路径的字符串
        /// </summary>
        public static string diskFilePath = "disk";

        /// <summary>
        /// 在磁盘文件disk内从指定位置开始，根据指定的缓冲区的内容，以字符为单位写入磁盘文件中
        /// </summary>
        /// <param name="offset">要写入的位置相对于磁盘开头的偏移量，从0开始，以字节为单位</param>
        /// <param name="buffer">缓冲区的引用</param>
        public static void FileWrite(int offset, ref byte[] buffer)
        {
            //使用File.OpenWrite返回一个打开方式设置为 OpenOrCreate，访问方式设置为Write的FileStream对象，并被BinaryWriter引用
            BinaryWriter writer = new BinaryWriter(File.OpenWrite(diskFilePath));
            //设置指针位置
            writer.BaseStream.Seek(offset, SeekOrigin.Begin);
            //将buffer内的数据写进文件
            writer.Write(buffer);
            //关闭流
            writer.Flush();
            writer.Close();
        }

        /// <summary>
        /// 在磁盘文件disk内从指定位置开始，以字符为单位读取多个字符，并存放进缓冲区中
        /// </summary>
        /// <param name="buffer">缓冲区的引用</param>
        /// <param name="offset">要读取的位置相对于磁盘开头的偏移量，从0开始，以字节为单位</param>
        /// <param name="numOfByte">要读取并存放进缓冲区的字节数</param>
        public static void FileRead(ref byte[] buffer, int offset, int numOfByte)
        {
            BinaryReader reader = new BinaryReader(File.OpenRead(diskFilePath));
            //设置指针位置
            reader.BaseStream.Seek(offset, SeekOrigin.Begin);
            //读取数据进入buffer
            buffer = reader.ReadBytes(numOfByte);
            //关闭流
            reader.Close();
        }
    }
}
