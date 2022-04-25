using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace FormAnh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdOpenFile.ShowDialog();
            string file = ofdOpenFile.FileName;
            if (string.IsNullOrEmpty(file))
                return;
            Image myImage = Image.FromFile(file);
            pictureBoxSource.Image = myImage;
        }

        private void ofdOpenFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureBoxSource.Image.Save(stream,ImageFormat.Jpeg);
            MyDbContextDataContext myDb = new MyDbContextDataContext();
            Anh anh = new Anh();
            anh.NAME = "My name";
            anh.MAANH = stream.ToArray();
            myDb.Anhs.InsertOnSubmit(anh);
            myDb.SubmitChanges();

        }

        private void buttonLoadImageFromDatabase_Click(object sender, EventArgs e)
        {
            MyDbContextDataContext myDb = new MyDbContextDataContext();
            Anh anh = myDb.Anhs.Where(em => em.NAME == "My name").FirstOrDefault();
            if (anh == null) 
                return;
            MemoryStream memoryStream = new MemoryStream(anh.MAANH.ToArray());
            Image img = Image.FromStream(memoryStream);
            if (img == null)
                return;
            pictureBoxDes.Image = img;  
        }
    }
}
