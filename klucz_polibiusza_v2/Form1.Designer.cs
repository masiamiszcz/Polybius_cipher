namespace klucz_polibiusza_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TekstSzyfrowany = new TextBox();
            Szyfruj = new Button();
            Deszyfruj = new Button();
            Klucz_Z = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Generuj_tablice_szyfru = new Button();
            Open_location_keyX = new Button();
            SuspendLayout();
            // 
            // TekstSzyfrowany
            // 
            TekstSzyfrowany.Location = new Point(12, 38);
            TekstSzyfrowany.Multiline = true;
            TekstSzyfrowany.Name = "TekstSzyfrowany";
            TekstSzyfrowany.Size = new Size(468, 151);
            TekstSzyfrowany.TabIndex = 0;
            // 
            // Szyfruj
            // 
            Szyfruj.Location = new Point(497, 38);
            Szyfruj.Name = "Szyfruj";
            Szyfruj.Size = new Size(114, 52);
            Szyfruj.TabIndex = 1;
            Szyfruj.Text = "Szyfruj";
            Szyfruj.UseVisualStyleBackColor = true;
            Szyfruj.Click += Szyfruj_Click;
            // 
            // Deszyfruj
            // 
            Deszyfruj.Location = new Point(497, 96);
            Deszyfruj.Name = "Deszyfruj";
            Deszyfruj.Size = new Size(114, 52);
            Deszyfruj.TabIndex = 2;
            Deszyfruj.Text = "Deszyfruj";
            Deszyfruj.UseVisualStyleBackColor = true;
            Deszyfruj.Click += Deszyfruj_Click;
            // 
            // Klucz_Z
            // 
            Klucz_Z.Location = new Point(629, 56);
            Klucz_Z.Multiline = true;
            Klucz_Z.Name = "Klucz_Z";
            Klucz_Z.Size = new Size(114, 34);
            Klucz_Z.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 4;
            label1.Text = "Tekst";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(629, 38);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Klucz Z";
            // 
            // Generuj_tablice_szyfru
            // 
            Generuj_tablice_szyfru.Location = new Point(629, 96);
            Generuj_tablice_szyfru.Name = "Generuj_tablice_szyfru";
            Generuj_tablice_szyfru.Size = new Size(114, 52);
            Generuj_tablice_szyfru.TabIndex = 6;
            Generuj_tablice_szyfru.Text = "Generuj nową tablice szyfru";
            Generuj_tablice_szyfru.UseVisualStyleBackColor = true;
            Generuj_tablice_szyfru.Click += Generuj_tablice_szyfru_Click;
            // 
            // Open_location_keyX
            // 
            Open_location_keyX.Location = new Point(497, 154);
            Open_location_keyX.Name = "Open_location_keyX";
            Open_location_keyX.Size = new Size(246, 35);
            Open_location_keyX.TabIndex = 7;
            Open_location_keyX.Text = "Otwórz lokalizacje klucza X";
            Open_location_keyX.UseVisualStyleBackColor = true;
            Open_location_keyX.Click += Open_location_keyX_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Open_location_keyX);
            Controls.Add(Generuj_tablice_szyfru);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Klucz_Z);
            Controls.Add(Deszyfruj);
            Controls.Add(Szyfruj);
            Controls.Add(TekstSzyfrowany);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TekstSzyfrowany;
        private Button Szyfruj;
        private Button Deszyfruj;
        private TextBox Klucz_Z;
        private Label label1;
        private Label label2;
        private Button Generuj_tablice_szyfru;
        private Button Open_location_keyX;
    }
}
