using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_futbol
{
    public partial class QRview : Form
    {
        public QRview()
        {
            InitializeComponent();
        }
        public QRview(Bitmap qr_code)
        {
            InitializeComponent();
            pictureBox1.Image = qr_code;
        }
    }
}
