using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
namespace Tetris
{
    public partial class SuperButton : UserControl
    {
        //public Image PressedBackgroundImage { get; set; }
        //private Image originalBackgroundImage;

        public SuperButton()
        {
            InitializeComponent();
            //MouseDown += OnMouseDown;
            //MouseUp += OnMouseUp;
        }

        //private void OnMouseDown(object sender, MouseEventArgs e)
        //{
        //    if (BackgroundImage != null && PressedBackgroundImage != null)
        //    {
        //        originalBackgroundImage = BackgroundImage;
        //        BackgroundImage = PressedBackgroundImage;
        //    }
        //}

        //private void OnMouseUp(object sender, MouseEventArgs e)
        //{
        //    if (BackgroundImage != null && PressedBackgroundImage != null)
        //    {
        //        BackgroundImage = originalBackgroundImage;
        //    }
        //}
    }
}
