using System;
using System.Diagnostics;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace klucz_polibiusza_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string alfabet = "A•BC∆DE FGHIJKL£MN—O”PQRSTUVWXVYZèØ";
        static string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Klucz.txt");
        static List<int> ints = new List<int>();
        static char[,] tablica = new char[5, 7];
        static Random random = new Random();

        private void Szyfruj_Click(object sender, EventArgs e)
        {
            
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Please generate or implement the table first.", "File with table does not exist", MessageBoxButtons.OK);
                return;
            }
            else
            {
                LoadTab();
                var text = RemoveSpaces(TekstSzyfrowany.Text.ToUpper());
                if (text.Length > 0 && !text.Any(char.IsDigit))
                {
                    if (Klucz_Z.Text.Trim().Split(' ').Length == 2)
                    {
                        int.TryParse(Klucz_Z.Text.Split(' ')[0], out int a); a -= 1; //int a
                        int.TryParse(Klucz_Z.Text.Split(' ')[1], out int b); b -= 1; //int b   
                        var z = a + 1;
                        var sb = new StringBuilder();
                        for (int x = 0; x < text.Length; x++)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 7; j++)
                                {
                                    if (text[x] == tablica[i, j])
                                    {
                                        sb.Append((i + 1).ToString() + (j + 1).ToString());
                                        break;
                                    }
                                }
                            }
                        }
                        while (a < sb.Length && b < sb.Length)
                        {
                            var temp = sb[a];
                            sb[a] = sb[b];
                            sb[b] = temp;
                            a = a + z;
                            b = b + z;
                        }
                        TekstSzyfrowany.Text = sb.ToString();
                    }else MessageBox.Show("Please enter the correct key_Z.", "Key is not correct", MessageBoxButtons.OK);
                }
            }
        }

        private void Deszyfruj_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Please generate or implement the table first.", "File with table does not exist", MessageBoxButtons.OK);
                return;
            }
            else
            {
                LoadTab();
                var text = RemoveSpaces(TekstSzyfrowany.Text.ToUpper());
                if (text.Length > 0 && !text.Any(char.IsLetter))
                {
                    if (Klucz_Z.Text.Trim().Split(' ').Length == 2)
                    {
                        int.TryParse(Klucz_Z.Text.Split(' ')[0], out int a); a -= 1; //int a
                        int.TryParse(Klucz_Z.Text.Split(' ')[1], out int b); b -= 1; //int b   
                        var z = a + 1;
                        var sb = new StringBuilder(TekstSzyfrowany.Text);
                        var newsb = new StringBuilder();
                        while (a < sb.Length && b < sb.Length)
                        {
                            var temp = sb[a];
                            sb[a] = sb[b];
                            sb[b] = temp;
                            a = a + z;
                            b = b + z;
                        }
                        for (int i = 0; i < sb.Length; i += 2)
                        {
                            var x = int.Parse(sb[i].ToString());
                            var y = int.Parse(sb[i + 1].ToString());
                            for (int h = 1; h <= 5; h++)
                            {
                                if (h == x)
                                {
                                    for (int j = 1; j <= 7; j++)
                                    {
                                        if (j == y)
                                        {
                                            newsb.Append(tablica[h - 1, j - 1]);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        TekstSzyfrowany.Text = newsb.ToString();
                    }else MessageBox.Show("Please enter the correct key_Z.", "Key is not correct", MessageBoxButtons.OK);
                }
            }
        }
        private void Open_location_keyX_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                Process.Start("explorer.exe", $"/select,{filePath}");
            }else
            {
                Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            }
        }
        private void Generuj_tablice_szyfru_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                DialogResult result = MessageBox.Show("Do you want to create new file?", "File already exists", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    File.Delete(filePath);
                    GenerateTab();
                    SaveTableToFile(tablica);
                    Process.Start("explorer.exe", $"/select,{filePath}");
                }
                else
                {
                    return;
                }
            }
            else
            {
                GenerateTab();
                SaveTableToFile(tablica);
                Process.Start("explorer.exe", $"/select,{filePath}");
            }
        }
        private static string RemoveSpaces(string inputtoremove)
        {
            return string.Concat(inputtoremove.Where(c => !char.IsWhiteSpace(c)));
        }
        private static void GenerateTab()
        {
            ints = Enumerable.Range(0, 35).ToList();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    int losindex = random.Next(ints.Count);
                    int los = ints[losindex];
                    ints.RemoveAt(losindex);
                    tablica[i, j] = alfabet[los];
                }
            }

        }
        private static void SaveTableToFile(char[,] table)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        writer.Write(table[i, j] + " ");
                    }
                    writer.WriteLine();
                }
            }
        }
        private static void LoadTab()
        {
            string[] linie = File.ReadAllLines(filePath);
            for (int i = 0; i < linie.Length; i++)
            {
                char[] znaki = linie[i].Replace(" ", "").ToCharArray();
                for (int j = 0; j < znaki.Length; j++)
                {
                    tablica[i, j] = znaki[j];
                }
            }
        }

    }
}
