﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.JTActiveSafety.Metadata
{
    /// <summary>
    /// 附件信息
    /// </summary>
    public class AttachProperty
    {
        /// <summary>
        /// 文件名称长度
        /// </summary>
        public byte FileNameLength
        {
            get
            {
                return Convert.ToByte(FileName?.Length ?? 0);
            }

            set
            {
            }

        }
        /// <summary>
        /// 文件名称
        /// <文件类型>_<通道号>_<报警类型>_<序号>_<报警编号>.<后缀名>
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 文件大小
        /// </summary>
        public uint FileSize { get; set; }
    }
}
