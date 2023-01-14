using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Filespec;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Image = iText.Layout.Element.Image;

namespace Projektki
{


    public partial class FizioCentarKopett : Form
    {
        DataSet ds;
        SqlConnection con;
        SqlDataReader dr;
        SqlDataAdapter adap;
        int asd = 0;

        public int qwe;
        public static string FONT = @"C:\Windows\Fonts\arial.ttf";
        public static string konekcija = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ivan\source\repos\Projektki\Projektki\Database1.mdf;Integrated Security=True";
        iText.Kernel.Font.PdfFont font1250 = PdfFontFactory.CreateFont(FONT, iText.IO.Font.PdfEncodings.CP1250);

        public FizioCentarKopett()
        {
            InitializeComponent();
            Fillcombo1();

        }
        void Fillcombo1()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                comboBox1.Items.Clear();
                conn = new SqlConnection(konekcija);
                string query = "select * from pacjenti";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandText = query;
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["Ime"].ToString());
                    comboBox1.ValueMember = dr["OIB"].ToString();
                    comboBox1.DisplayMember = dr["Prezime"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error neuspjela konekcija na bazu");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {/*
            // TODO: This line of code loads data into the 'database1DataSet1.povjest' table. You can move, or remove it, as needed.
            this.povjestTableAdapter.Fill(this.database1DataSet1.povjest);
            // TODO: This line of code loads data into the 'database1DataSet1.povjest' table. You can move, or remove it, as needed.
            this.povjestTableAdapter.Fill(this.database1DataSet1.povjest);
            // TODO: This line of code loads data into the 'database1DataSet1.povjest' table. You can move, or remove it, as needed.
            this.povjestTableAdapter.Fill(this.database1DataSet1.povjest);
            // TODO: This line of code loads data into the 'database1DataSet1.Pacjenti' table. You can move, or remove it, as needed.

    //        database1DataSet1.EnforceConstraints = false;

            // Perform some operations on the dataset
            
            this.pacjentiTableAdapter.Fill(this.database1DataSet1.Pacjenti);
            
           // database1DataSet1.EnforceConstraints = true;*/
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //MessageBox.Show("asd");
            int k;
            SqlConnection conn = new SqlConnection();
            conn = new SqlConnection(konekcija);
            string query = "select * from pacjenti WHERE Ime='" + comboBox1.Text + "';";
            //string queryy = "select * from povjest WHERE OIB='" + oIBTextBox.Text + "';";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandText = query;
            conn.Open();
            SqlDataReader drd = cmd.ExecuteReader();
            int columnn = drd.GetOrdinal("Ime");

            while (drd.Read())
            {
                imeTextBox.Text = drd.GetString(columnn);
                mobTextBox.Text = drd.GetString(columnn + 1);
                adresaTextBox.Text = drd.GetString(columnn + 2);
                brojTextBox.Text = drd.GetString(columnn + 3);
                DatumTextBox.Text = drd.GetString(columnn + 5);
                MailtextBox.Text = drd.GetString(columnn + 6);
                //k= drd.GetString(columnn + 4);      
                k = drd.GetInt32(columnn + 4);
                oIBTextBox.Text = k.ToString();
            }

            con = new SqlConnection();
            con.ConnectionString = (konekcija);
            con.Open();
            adap = new SqlDataAdapter("select * from povjest WHERE Imee='" + comboBox1.Text + "';", con);
            ds = new System.Data.DataSet();
            adap.Fill(ds, "povjest");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;// DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            con.Close();
            if (asd == 0)
            {
                asd = 1;
                dataGridView1.CurrentCell = dataGridView1[1, 0];
                dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
                dataGridView1.BeginEdit(true);
            }
        }


        private void pacjentiBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.pacjentiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1 != null)
            {
                Point point1 = dataGridView1.CurrentCellAddress;
                if (point1.X == 5 && point1.Y == e.RowIndex)
                {
                    dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                    int stup = e.ColumnIndex;
                    int red = e.RowIndex;

                    var value = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    //MessageBox.Show(value.ToString());
                    string aa = value.ToString();
                    MessageBox.Show(aa.ToString());
                    ispis(aa);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into pacjenti(Ime,Prezime,adresa,broj,oib,Datum,Mail)values('" + imeTextBox.Text + "','" + mobTextBox.Text + "','" + adresaTextBox.Text + "','" + brojTextBox.Text + "','" + oIBTextBox.Text + "','" + DatumTextBox.Text + "','" + MailtextBox.Text + "'); ";
            using (SqlConnection connection = new SqlConnection(konekcija))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string queryy = "select max(oib) from povjest";
            using (SqlConnection connection = new SqlConnection(konekcija))
            {
                using (SqlCommand command = new SqlCommand(queryy, connection))
                {
                    connection.Open();
                    qwe = Convert.ToInt32(command.ExecuteScalar());
                    qwe = qwe + 1;
                }
            }

            DateTime dt = DateTime.Now;              // Use current time
            //MessageBox.Show(qwe.ToString());
            string query = "insert into povjest(Imee,anamneza,terapija,zakljucak,oib,datm)values('" + imeTextBox.Text + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "','" + (qwe) + "','" + dt.ToString("yyyy-MM-dd HH:mm:ss") + "');";
            using (SqlConnection connection = new SqlConnection(konekcija))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                con = new SqlConnection();
                con.ConnectionString = (konekcija);
                con.Open();
                adap = new SqlDataAdapter("select * from povjest WHERE Imee='" + comboBox1.Text + "';", con);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "povjest");
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;// DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                con.Close();
            }
        }
        private void ispis(string reed)
        {

            String[] logoFilePaths = { "D:\\a\\asd.png" };
            String[] foot = { "D:\\a\\fo.png" };
            PdfWriter writer = new PdfWriter("D:\\a\\" + reed + ".pdf", new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0));
            PdfDocument pdfDocument = new PdfDocument(writer);
            Document document = new Document(pdfDocument);

            for (int x = 0; x < logoFilePaths.Length; x++)
            {


                //document.SetFont(font1250);
                document.SetLeftMargin(5);
                document.SetRightMargin(5);
                String path = logoFilePaths[x];
                Image image = new Image(ImageDataFactory.Create(path)).SetAutoScaleWidth(true);
                document.Add(image);
                Paragraph p = new Paragraph();
                p.SetMarginLeft(50);
                p.SetMarginRight(50);

                Paragraph pa = new Paragraph();
                pa.SetMarginLeft(50);
                pa.SetMarginRight(50);
                String dess = imeTextBox.Text.ToString()+", "+ DatumTextBox.Text.ToString()+"\n"+adresaTextBox.Text.ToString();
                pa.Add(new Paragraph(dess));
                document.Add(pa);

                //  MessageBox.Show(reed);
                string queryy = "select anamneza from povjest where oib='" + reed + "'";
                using (SqlConnection connection = new SqlConnection(konekcija))
                {
                    using (SqlCommand command = new SqlCommand(queryy, connection))
                    {
                        p.SetMultipliedLeading(1);
                        connection.Open();

                        string anamneza = Convert.ToString(command.ExecuteScalar());
                        //MessageBox.Show(anamneza);
                        String des = "\n\n\n Anamneza:";
                        p.Add(new Paragraph(des));
                        String description = anamneza;
                        p.Add(new Paragraph(description));
                        document.Add(p);
                    }

                }

                Paragraph q = new Paragraph();
                q.SetMarginLeft(50);
                q.SetMarginRight(50);
                string terap = "select terapija from povjest where oib='" + reed + "'";
                using (SqlConnection connection = new SqlConnection(konekcija))
                {
                    using (SqlCommand command = new SqlCommand(terap, connection))
                    {
                        q.SetMultipliedLeading(1);
                        connection.Open();
                        string anamneza = Convert.ToString(command.ExecuteScalar());
                        String des = "\n Terapija:";
                        q.Add(new Paragraph(des));
                        String description = anamneza;
                        q.Add(new Paragraph(description));
                        document.Add(q);
                    }

                }
                Paragraph w = new Paragraph();
                w.SetMarginLeft(50);
                w.SetMarginRight(50);
                string zak = "select zakljucak from povjest where oib='" + reed + "'";
                using (SqlConnection connection = new SqlConnection(konekcija))
                {
                    using (SqlCommand command = new SqlCommand(zak, connection))
                    {
                        w.SetMultipliedLeading(1);
                        connection.Open();
                        string anamneza = Convert.ToString(command.ExecuteScalar());
                        String des = "\n Zaključak:";

                        w.Add(new Paragraph(des).SetFont(PdfFontFactory.CreateFont(FONT, iText.IO.Font.PdfEncodings.CP1250)));
                        String description = anamneza;
                        w.Add(new Paragraph(description));
                        document.Add(w);
                    }

                }
                Paragraph t = new Paragraph();
                String imageFile = "D:\\a\\fo.png";
                ImageData data = ImageDataFactory.Create(imageFile);
                Image img = new Image(data);
                img.SetFixedPosition(60, 10);
                document.Add(img);
                PdfFileSpec fileSpec = PdfFileSpec.CreateEmbeddedFileSpec(pdfDocument, path, "logo_v" + (x + 1) + ".png", PdfName.ApplicationOctetStream);
                pdfDocument.GetPage(x + 1).AddAssociatedFile(fileSpec);

                if (x != logoFilePaths.Length - 1)
                {
                    document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));
                }

            }
            document.Close();
            System.Diagnostics.Process.Start(@"D:\\a\\" + reed + ".pdf");

        }
        private void imeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "update pacjenti set Ime='" + imeTextBox.Text + "',Prezime='" + mobTextBox.Text + "', adresa='" + adresaTextBox.Text + "',broj='" + brojTextBox.Text + "',oib='" + oIBTextBox.Text + "', Datum='" + DatumTextBox.Text + "', Mail='" + MailtextBox.Text + "'where oib='" + oIBTextBox.Text + "';";
            using (SqlConnection connection = new SqlConnection(konekcija))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Fillcombo1();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "update povjest set Anamneza='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "',Terapija='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "', Zakljucak='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "'where Imee='" + imeTextBox.Text + "'and oib='"+dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'; ";
            using (SqlConnection connection = new SqlConnection(konekcija))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Fillcombo1();
                }
            }
        }

        private void oIBLabel_Click(object sender, EventArgs e)
        {

        }

        private void brojLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            string queryy = "delete from povjest where oib='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "';";
            using (SqlConnection connection = new SqlConnection(konekcija))
            {
                using (SqlCommand command = new SqlCommand(queryy, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string queryy = "delete from Pacjenti where oib='" + oIBTextBox.Text + "';";
            using (SqlConnection connection = new SqlConnection(konekcija))
            {
                using (SqlCommand command = new SqlCommand(queryy, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

