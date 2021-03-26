using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            propertyGrid1.SelectedObject = new Setting();
        }

    }

    public class Setting
    {
        [Category("Camera")]
        [Description("Set the name of the camera.")]
        public string Name { get; set; } = "Camera";

        [Category("Camera")]
        [Description("Set the width of the image.")]
        public int Width { get; set; } = 640;

        [Category("Camera")]
        [Description("Set the height of the image.")]
        public int Height { get; set; } = 480;

        [Category("Camera")]
        [Description("Set the bit of the image.")]
        public int Bit { get; set; } = 8;
    }
}
