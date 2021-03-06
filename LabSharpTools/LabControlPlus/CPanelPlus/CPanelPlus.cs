﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Harry.LabTools.LabControlPlus
{
    /// <summary>
    /// 边框模式（无、单色、三维）
    /// </summary>
    public enum BorderMode
    {
        None,
        Single, 
        ThreeD
    }
    public partial class CPanelPlus : Panel
    {
        #region 变量定义 

        /// <summary>
        /// 
        /// </summary>
        private Color borderColor;

        /// <summary>
        /// 
        /// </summary>
        private Border3DStyle border3DStyle;

        /// <summary>
        /// 
        /// </summary>
        private ToolStripStatusLabelBorderSides borderSide;

        /// <summary>
        /// 
        /// </summary>
        private BorderMode borderMode;


        #endregion

        #region 属性定义

        [DefaultValue(BorderMode.None), Description("边框模式。可设置单色模式或三维模式")]
        public BorderMode BorderMode
        {
            get
            {
                return borderMode;
            }
            set
            {
                if (borderMode == value)
                {
                    return;
                }
                borderMode = value;
                this.Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "Black"), Description("边框颜色。仅当边框为单色模式时有效")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                if (borderColor == value)
                {
                    return;
                }
                borderColor = value;
                this.Invalidate();
            }
        }

        [DefaultValue(Border3DStyle.Etched), Description("边框三维样式。仅当边框为三维模式时有效")]
        public Border3DStyle Border3DStyle
        {
            get
            {
                return border3DStyle;
            }
            set
            {
                if (border3DStyle == value)
                {
                    return;
                }
                border3DStyle = value;
                this.Invalidate();
            }
        }

        //之所以不直接用Border3DSide是因为这货不被设计器支持，没法灵活选择位置组合
        [DefaultValue(ToolStripStatusLabelBorderSides.All), Description("边框位置。可自由启用各个方位的边框")]
        public ToolStripStatusLabelBorderSides BorderSide
        {
            get
            {
                return borderSide;
            }
            set
            {
                if (borderSide == value)
                {
                    return;
                }
                borderSide = value;
                this.Invalidate();
            }
        }

        #endregion

        #region 构造函数

        /// <summary>
        /// 
        /// </summary>
        public CPanelPlus() : base()
        {
            InitializeComponent();
            this.borderMode = BorderMode.None;
            this.borderColor = Color.Black;
            this.border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.borderSide = ToolStripStatusLabelBorderSides.All;
        }

        #endregion

        #region 析构函数

        #endregion

        #region 公共函数

        #endregion

        #region 保护函数

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (this.BorderStyle != System.Windows.Forms.BorderStyle.None
                || BorderMode == BorderMode.None
                || BorderSide == ToolStripStatusLabelBorderSides.None)
            {
                return;
            }

            using (Graphics g = e.Graphics)
            {
                //三维模式
                if (this.BorderMode == BorderMode.ThreeD)
                {
                    ControlPaint.DrawBorder3D(g, this.ClientRectangle, this.Border3DStyle, (Border3DSide)BorderSide);//这儿要将ToolStripStatusLabelBorderSides转换为Border3DSide
                }
                else //单色模式
                {
                    using (Pen pen = new Pen(BorderColor))
                    {
                        //若是四条边都启用，则直接画矩形
                        if (BorderSide == ToolStripStatusLabelBorderSides.All)
                        {
                            g.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
                        }
                        else //否则分别绘制线条
                        {
                            if ((BorderSide & ToolStripStatusLabelBorderSides.Top) == ToolStripStatusLabelBorderSides.Top)
                            {
                                g.DrawLine(pen, 0, 0, this.Width - 1, 0);
                            }

                            if ((BorderSide & ToolStripStatusLabelBorderSides.Right) == ToolStripStatusLabelBorderSides.Right)
                            {
                                g.DrawLine(pen, this.Width - 1, 0, this.Width - 1, this.Height - 1);
                            }

                            if ((BorderSide & ToolStripStatusLabelBorderSides.Bottom) == ToolStripStatusLabelBorderSides.Bottom)
                            {
                                g.DrawLine(pen, 0, this.Height - 1, this.Width - 1, this.Height - 1);
                            }

                            if ((BorderSide & ToolStripStatusLabelBorderSides.Left) == ToolStripStatusLabelBorderSides.Left)
                            {
                                g.DrawLine(pen, 0, 0, 0, this.Height - 1);
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region 私有函数

        #endregion

        #region 事件函数

        #endregion
    }
}
