﻿using System;
using Bing.Offices.Enums;

namespace Bing.Offices.Attributes
{
    /// <summary>
    /// 表头
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class HeaderAttribute : Attribute
    {
        /// <summary>
        /// 颜色
        /// </summary>
        public Color Color { get; set; } = Color.Black;

        /// <summary>
        /// 字体名称
        /// </summary>
        public string FontName { get; set; } = "微软雅黑";

        /// <summary>
        /// 字体大小
        /// </summary>
        public int FontSize { get; set; } = 12;

        /// <summary>
        /// 是否加粗
        /// </summary>
        public bool IsBold { get; set; } = true;
    }
}
