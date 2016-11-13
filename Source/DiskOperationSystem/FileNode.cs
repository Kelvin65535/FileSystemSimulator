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
    /// <summary>
    /// FileNode类 定义了一个存储目录项/文件项的基本信息的节点
    /// </summary>
    public class FileNode
    {
        /******************************************
         * 
         * 以下定义了FileNode类的成员变量及器修改器/访问器
         * 
         ******************************************/

        /// <summary>
        /// 名称
        /// </summary>
        private string name;
        /// <summary>
        /// 名称的访问器和修改器
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        /// <summary>
        /// 类型名
        /// </summary>
        private string type;
        /// <summary>
        /// 类型名的访问器和修改器
        /// </summary>
        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        /// <summary>
        /// 属性
        /// </summary>
        private string attribute;
        /// <summary>
        /// 属性的访问器和修改器
        /// </summary>
        public string Attribute
        {
            get
            {
                return attribute;
            }
            set
            {
                attribute = value;
            }
        }
        
        /// <summary>
        /// 起始盘块号
        /// </summary>
        private byte startNode;
        /// <summary>
        /// 起始盘块号的访问器和修改器
        /// </summary>
        public byte StartNode
        {
            get
            {
                return startNode;
            }
            set
            {
                startNode = value;
            }
        }

        /// <summary>
        /// 大小
        /// </summary>
        private byte length;
        /// <summary>
        /// 大小的访问器和修改器
        /// </summary>
        public byte Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        /******************************************
         * 
         * 以下为构造方法
         * 
         ******************************************/

        /// <summary>
        /// 无参构造方法，构建一个默认节点内容为空的节点对象
        /// </summary>
        public FileNode()
        {

        }

        /// <summary>
        /// 有参构造方法，传入节点内容，构造对应的节点对象
        /// </summary>
        /// <param name="_name">名称</param>
        /// <param name="_type">类型名</param>
        /// <param name="_attribute">属性</param>
        /// <param name="_startnode">起始盘块号</param>
        public FileNode(ref string _name, ref string _type, ref string _attribute, ref byte _startnode)
        {
            name = _name;
            type = _type;
            attribute = _attribute;
            startNode = _startnode;
        }
    }
}
