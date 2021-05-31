using Azure;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Xeditor
{
    public partial class Form1 : Form
    {
        Random ran = new Random();
        public string text;
        public int size;
        public bool ulozeni = false;
        public List<string> Fonty = new List<string>();
        public bool ulozeno = false;
        public Form1()
        {
            InitializeComponent();
            RightclickMenu.SuspendLayout();
            RightclickMenu.AutoSize = true;
            RightclickMenu.Visible = true;
            RightclickMenu.Name = "RightClickMenu";

        }

        private void NactiSoubor_Click(object sender, EventArgs e)
        {
            NactiSouborMetoda();
            ulozeno = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void UlozitJako_Click(object sender, EventArgs e)
        {
            UlozDoSouboru();
            ulozeno = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void Ulozit_Click(object sender, EventArgs e)
        {
            if (ulozeni == false)
            {
                UlozDoSouboru();
                ulozeno = true;
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
            }
            else if (ulozeni == true)
            {
                File.WriteAllText(text, textBox1.Text);
                ulozeno = true;
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
            }
        }

        private void stisk(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.Shift == true && e.KeyCode == Keys.S)
            {
                UlozDoSouboru();
                ulozeno = true;
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
            }
            else if (e.Control == true && e.KeyCode == Keys.S)
            {
                if (ulozeni == false)
                {
                    UlozDoSouboru();
                    ulozeno = true;
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                }
                else if (ulozeni == true)
                {
                    File.WriteAllText(text, textBox1.Text);
                    ulozeno = true;
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                }
            }
            
            else if (e.Control == true && e.KeyCode == Keys.O)
            {
                NactiSouborMetoda();
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
            }
        }
       


        /****************************Načtení funkce*********************************/
        public void NactiSouborMetoda()
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Filter = "rtf files (*.rtf)|*.rtf|txt files (*.txt)|*.txt|html files(*.html)|*html|css files(*.css)|*css|javascript files(*.js)|*js|All files (*.*)|*.*";
                if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK && op.FileName.Length > 0)
                {
                    string obsah;
                    text = op.FileName;
                    FileInfo fi = new FileInfo(text);
                    if (fi.Extension == ".rtf")
                    {
                        textBox1.LoadFile(text);
                        obsah = textBox1.Text;
                    } 
                    else 
                    {
                        obsah=File.ReadAllText(text);
                        textBox1.Text = obsah; 
                    }
                    ulozeni = true;
                }
            }
        }
        /****************************UKLÁDÁNÍ funkce*********************************/
        public void UlozDoSouboru()
        {
            using (SaveFileDialog sv = new SaveFileDialog())
            {
                sv.Filter = "rtf files (*.rtf)|*.rtf|txt files (*.txt)|*.txt|html files(*.html)|*html|css files(*.css)|*css|javascript files(*.js)|*js|All files (*.*)|*.*";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(sv.FileName);
                    if (fileInfo.Extension == ".rtf")
                        ZapisText(sv.FileName, RichTextBoxStreamType.RichText);
                    else
                        ZapisText(sv.FileName, RichTextBoxStreamType.PlainText);
                    ulozeni = true;
                    text = sv.FileName;
                }
            }
        }
        //*********************ZAPSÁNÍ DO SOUBORU metoda**********//
        public void ZapisText(string soubor, RichTextBoxStreamType r)
        {
            /*using (var sw = new StreamWriter(soubor, true))
            {
                sw.Write(s);
            }*/
            textBox1.SaveFile(soubor,r);
        }
        static Font font = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Calibri", 11);
            font = new Font("Calibri", 11);
            //button1.FlatAppearance.BorderSize = 0;
            if (Program.cesta != null)
            {
                NactiSouborMetoda();
                ulozeno = true;
            }
            
        }
      
        private void textBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            this.Controls.Remove(RightclickMenu);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            //MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = textBox1.ForeColor;
            bool vbr=false;
            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                //if (textBox1.SelectedText == null)

                if (textBox1.SelectedText != null)
                {
                    textBox1.SelectionBackColor = MyDialog.Color;
                     vbr = true;
                }
                if (vbr == false)
                {
                    textBox1.BackColor = MyDialog.Color;
                }

            }
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.ShowHelp = true;
            MyDialog.Color = textBox1.ForeColor;
            bool vbr = false;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                if (textBox1.SelectedText != null)
                {
                    textBox1.SelectionColor = MyDialog.Color;
                    vbr = true;
                }
                if (vbr == false)
                {
                    textBox1.ForeColor = MyDialog.Color;
                }

            }
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
            }
            else
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (panel2.Visible == false)
            {
                panel2.Visible = true;
                panel1.Visible = false;
                panel3.Visible = false;
            }
            else
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            bmp = new Bitmap(textBox1.Width, textBox1.Height);
            ImageFormat imageFormat = null;
            imageFormat = ImageFormat.Bmp;
            textBox1.DrawToBitmap(bmp, new Rectangle(10, 10, bmp.Width, bmp.Height));
            //bmp.Save(@"bitmap.bmp", imageFormat);


            PrintDialog pd = new PrintDialog();
            PageSetupDialog pst = new PageSetupDialog();
            PrintDocument printDocument1 = new PrintDocument();
            //printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custum", 500, 500);
            printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print(); 
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        Bitmap bmp { get; set; }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Image img = Image.FromFile("bitmap.bmp");
            
            Point loc = new Point(0, 0);
            e.Graphics.DrawImage(bmp, loc);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Text != "" && ulozeno==false)
            {
                MessageBoxButtons btn = MessageBoxButtons.YesNoCancel;
                DialogResult result;
                result = MessageBox.Show("Soubor nebyl uložen chcete ho uložit?", "uložit soubor", btn);
                if (result == DialogResult.Yes)
                {
                    UlozDoSouboru();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ulozeno = false;
        }

        private void btnfont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = font;
            DialogResult result = fd.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                if (textBox1.SelectedText != null)
                {
                    textBox1.SelectionFont = fd.Font;
                    font = fd.Font;
                }
                else
                {
                    textBox1.Font = fd.Font;
                    font = fd.Font;
                }
            }
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false)
            {
                panel3.Visible = true;
                panel1.Visible = false;
                panel2.Visible = false;
            }
            else
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
            }
        }
        private static readonly AzureKeyCredential credentials = new AzureKeyCredential("3e4bde584b61446995cba7ed2a7b1181");
        private static readonly Uri endpoint = new Uri("https://azurecup-text.cognitiveservices.azure.com/");
        private void btnKeyPhrases2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Azure.AI.TextAnalytics.TextAnalyticsClient client = new Azure.AI.TextAnalytics.TextAnalyticsClient(endpoint, credentials);
            List<string> list = client.ExtractKeyPhrases(textBox1.Text).Value.ToList();
            int[,] t = new int[list.Count, 2];
            for (int i = 0; i < list.Count; i++)
            {
                int s = textBox1.Find(list[i]);
                textBox1.Select(s, list[i].Length);
                textBox1.SelectionBackColor = Color.Lime;
            }
            Cursor = Cursors.Default;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }
        

        
        List<ValueStore<int, string, List<string>>> opravy = new List<ValueStore<int, string, List<string>>>();
        private void btnpreklepy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                return;
            Cursor = Cursors.WaitCursor;
            string alphabet = "aábcčdďeéěfghiíjklmnňoópqrřsštťuúůvwxyýzž";
            List<List<string>> opravena = new List<List<string>>();
            List<int> umisteni = new List<int>();
            List<string> slova = File.ReadAllLines(ConfigurationManager.AppSettings["cesta"]).ToList();
            List<string> naopravu = textBox1.Text.Split(' ').ToList();
            for (int i = 0; i < naopravu.Count; i++)
            {
                if (naopravu[i] == "")
                {
                    naopravu.RemoveAt(i);
                }
            }
            bool cont = false;
            for (int i = 0; i < naopravu.Count; i++)
            {
                cont = false;
                for (int j = 0; j < slova.Count; j++)
                {
                    if (naopravu[i] == slova[j])
                    {
                        cont = true;
                        break;
                    }

                }
                if (cont)
                    continue;

                List<string> spravne = new List<string>();
                for (int j = 0; j < naopravu[i].Length; j++)
                {
                    for (int k = 0; k < alphabet.Length; k++)
                    {

                        char abe = alphabet[k];
                        string oprv = naopravu[i].Insert(j, abe.ToString());
                        foreach (string slovo in slova)
                        {
                            if (oprv == slovo)
                            {
                                spravne.Add(oprv);
                            }
                        }
                        oprv = ReplaceAt(naopravu[i], j, abe);
                        foreach (string slovo in slova)
                        {
                            if (oprv == slovo)
                            {
                                spravne.Add(oprv);
                            }
                        }
                    }
                    string opr = naopravu[i].Remove(j, 1);
                    foreach (string slovo in slova)
                    {
                        if (opr == slovo)
                        {
                            spravne.Add(opr);
                        }
                    }
                }
                opravena.Add(spravne);
                umisteni.Add(i);
            }
            opravy.Clear();
            for (int j = 0; j < opravena.Count; j++)
            {
                int s = textBox1.Find(naopravu[umisteni[j]]);
                textBox1.Select(s, naopravu[umisteni[j]].Length);
                textBox1.SelectionBackColor = Color.FromArgb(245, 200, 122);
                ValueStore<int, string, List<string>> list = new ValueStore<int, string, List<string>>(s, naopravu[umisteni[j]],opravena[j]);
                opravy.Add(list);
            }
            Cursor = Cursors.Default;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }
        Panel RightclickMenu = new Panel();
        string ReplaceAt(string text,int pos,char newchar)
        {
            char[] znaky = text.ToCharArray();
            znaky[pos] = newchar;
            text = new string(znaky);
            return text;
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int t=textBox1.GetCharIndexFromPosition(e.Location);
                clickindex = t;
                for (int i = 0; i < opravy.Count; i++)
                {
                    if (t > opravy[i].Key && t <= opravy[i].Value.Length+ opravy[i].Key)
                    {
                        RightclickMenu.Controls.Clear();
                        RightclickMenu.Size = new Size(0, 0);
                        int height = 0;
                        for (int j = 0; j < opravy[i].List.Count; j++)
                        {
                            Button b = new Button();
                            b.Location = new Point(0,j * 20);
                            b.BackColor = Color.LightGray;
                            b.Text = opravy[i].List[j];
                            b.AutoSize = true;
                            b.Name= opravy[i].List[j];
                            b.Visible = true;
                            b.Click += B_Click;
                            this.RightclickMenu.Controls.Add(b);
                            height += 20;
                        }
                        RightclickMenu.Location = new Point(e.X, e.Y+50);

                        int lenght = 0;
                        foreach (Control item in RightclickMenu.Controls)
                        {
                            if (item.Size.Width > lenght)
                                lenght = item.Size.Width;
                        }
                        foreach (Button item in RightclickMenu.Controls)
                        {
                            item.Size = new Size(lenght,item.Size.Height);
                        }
                        RightclickMenu.Size= new Size(lenght, height);
                        this.Controls.Add(RightclickMenu);
                        textBox1.SendToBack();
                    }
                }
            }
        }
        int clickindex = 0;
        private void B_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            List<string> slova = textBox1.Text.Split(' ').ToList();
            int index = 0;
            for (int i = 0; i < slova.Count; i++)
            {
                index += slova[i].Length+1;
                if (clickindex < index)
                {
                    int pos = textBox1.Find(slova[i]);
                    textBox1.Select(pos, slova[i].Length);
                    string t = textBox1.Rtf.Replace(slova[i], b.Text);
                    textBox1.Rtf = t;
                    textBox1.Select(pos, b.Text.Length);
                    textBox1.SelectionBackColor = Color.White;
                    opravy.RemoveAt(find(slova[i]));
                    this.Controls.Remove(RightclickMenu);
                    break;
                }
            }
        }
        int find(string text)
        {
            int ret = -1;
            for (int i = 0; i < opravy.Count; i++)
            {
                if (opravy[i].Value == text)
                {
                    ret = i;
                    return ret;
                }
            }
            throw new Exception("specified text doesnot exist in opravy");
        }
    }
}