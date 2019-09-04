using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SautinSoft.Document;

namespace FileSaveAndOpen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Equals("") || txtFile.Text.Trim().Equals(""))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }

            byte[] file = null;
            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }

            using (Model.PQSEntities1 db = new Model.PQSEntities1())
            {
                Model.documents oDocument = new Model.documents();
                oDocument.name = txtName.Text.Trim();
                oDocument.doc = file;
                oDocument.realName = openFileDialog1.SafeFileName;

                db.documents.Add(oDocument);
                db.SaveChanges();
            }

            Refresh();
        }

        
        private void Refresh()
        {

            using (Model.PQSEntities1 db = new Model.PQSEntities1())
            {
                var lst = from d in db.documents
                          select new {d.id,d.name };
                dgvLista.DataSource = lst.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count > 0)
            {
                int id = int.Parse(dgvLista.Rows[dgvLista.CurrentRow.Index].Cells[0].Value.ToString());

                using (Model.PQSEntities1 db = new Model.PQSEntities1())
                {
                    var oDocument = db.documents.Find(id);

                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    string folder = path + "/temp/";
                    string fullFilePath = folder + oDocument.realName;

                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);

                    if (File.Exists(fullFilePath))
                        Directory.Delete(fullFilePath);

                    File.WriteAllBytes(fullFilePath, oDocument.doc);

                    Process.Start(fullFilePath);
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DocumentCore dc = DocumentCore.Load(@"C:\prueba\Manual.docx");
            dc.Save(@"C:\prueba\Manual.pdf");
        }
    }
}
