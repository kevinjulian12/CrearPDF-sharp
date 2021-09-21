using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CrearPDF_Click(object sender, EventArgs e)
        {
            CreadoPDF();
        }
        private void CreadoPDF()
        {  
            PdfWriter PdfWriter = new PdfWriter("Documento.pdf");
            PdfDocument pdf = new PdfDocument(PdfWriter);
                                     
            // Se crea el documento con el tamaño de página tradicional
            Document doc = new Document(pdf,PageSize.LETTER);

            // Se le coloca margen
            doc.SetMargins(20, 20, 20, 20);
          
            // Se escribe el encabezamiento en el documento
            doc.Add(new Paragraph("Mi primer documento PDF"));
            string Nombre = Convert.ToString(textBox1.Text);
            var parrafo = new Paragraph("Nombre: "+Nombre);
            doc.Add(parrafo);
            string Apellido = Convert.ToString(textBox2.Text);
            parrafo = new Paragraph("Apellido: " + Apellido);
            doc.Add(parrafo);
            string Direccion = Convert.ToString(textBox3.Text);
            parrafo = new Paragraph("Direccion: "+Direccion);
            doc.Add(parrafo);
            string Telefono = Convert.ToString(textBox4.Text);
            parrafo = new Paragraph("Telefono: " + Telefono);
            doc.Add(parrafo);
            string Email= Convert.ToString(textBox5.Text);
            parrafo = new Paragraph("Email: " + Email);
            doc.Add(parrafo);
            string localidad = Convert.ToString(textBox6.Text);
            parrafo = new Paragraph("Localidad: " + localidad);
            doc.Add(parrafo);
            doc.Close();
           
        }

    }
}
