namespace RSA_WF
{
    partial class RSA
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
            comboBox_keySize = new ComboBox();
            comboBox_format = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBox_privateKey = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox_publicKey = new TextBox();
            button_encrypt = new Button();
            button_decrypt = new Button();
            label5 = new Label();
            textBox_enc_plainText = new TextBox();
            richTextBox_enc_plainText = new RichTextBox();
            label6 = new Label();
            button_enc_plaintext = new Button();
            label7 = new Label();
            textBox_enc_publicKey = new TextBox();
            button_enc_publicKey = new Button();
            label8 = new Label();
            comboBox_enc_format = new ComboBox();
            button_enc_encrypt = new Button();
            richTextBox_log = new RichTextBox();
            label9 = new Label();
            button_dec_privateKey = new Button();
            label11 = new Label();
            textBox_dec_privateKey = new TextBox();
            button_dec_ciphert = new Button();
            label12 = new Label();
            richTextBox_dec_plainText = new RichTextBox();
            label13 = new Label();
            textBox_dec_ciphert = new TextBox();
            textBox_enc_ciphert = new TextBox();
            label14 = new Label();
            label10 = new Label();
            textBox_dec_plaintext = new TextBox();
            button_dec_decrypt = new Button();
            label15 = new Label();
            comboBox_dec_format = new ComboBox();
            button_genKey = new Button();
            groupBox_encrypt = new GroupBox();
            groupBox_decrypt = new GroupBox();
            groupBox_genKey = new GroupBox();
            groupBox_encrypt.SuspendLayout();
            groupBox_decrypt.SuspendLayout();
            groupBox_genKey.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_keySize
            // 
            comboBox_keySize.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_keySize.FormattingEnabled = true;
            comboBox_keySize.Items.AddRange(new object[] { "1024", "2048", "3072", "4096" });
            comboBox_keySize.SelectedIndex = 0;
            comboBox_keySize.Location = new Point(6, 46);
            comboBox_keySize.Name = "comboBox_keySize";
            comboBox_keySize.Size = new Size(142, 28);
            comboBox_keySize.TabIndex = 0;
            // 
            // comboBox_format
            // 
            comboBox_format.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_format.FormattingEnabled = true;
            comboBox_format.Items.AddRange(new object[] { "DER", "Base64" });
            comboBox_format.SelectedIndex = 0;
            comboBox_format.Location = new Point(154, 46);
            comboBox_format.Name = "comboBox_format";
            comboBox_format.Size = new Size(148, 28);
            comboBox_format.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Key Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 23);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Format";
            // 
            // textBox_privateKey
            // 
            textBox_privateKey.Location = new Point(6, 100);
            textBox_privateKey.Name = "textBox_privateKey";
            textBox_privateKey.Size = new Size(296, 27);
            textBox_privateKey.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 5;
            label3.Text = "Private Key";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 130);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 7;
            label4.Text = "Public Key";
            // 
            // textBox_publicKey
            // 
            textBox_publicKey.Location = new Point(6, 153);
            textBox_publicKey.Name = "textBox_publicKey";
            textBox_publicKey.Size = new Size(296, 27);
            textBox_publicKey.TabIndex = 6;
            // 
            // button_encrypt
            // 
            button_encrypt.Location = new Point(6, 186);
            button_encrypt.Name = "button_encrypt";
            button_encrypt.Size = new Size(94, 29);
            button_encrypt.TabIndex = 8;
            button_encrypt.Text = "< Encrypt";
            button_encrypt.UseVisualStyleBackColor = true;
            button_encrypt.Click += button_encrypt_Click;
            // 
            // button_decrypt
            // 
            button_decrypt.Location = new Point(208, 186);
            button_decrypt.Name = "button_decrypt";
            button_decrypt.Size = new Size(94, 29);
            button_decrypt.TabIndex = 9;
            button_decrypt.Text = "Decrypt >";
            button_decrypt.UseVisualStyleBackColor = true;
            button_decrypt.Click += button_decrypt_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 23);
            label5.Name = "label5";
            label5.Size = new Size(155, 20);
            label5.TabIndex = 11;
            label5.Text = "Plaintext Path or NULL";
            // 
            // textBox_enc_plainText
            // 
            textBox_enc_plainText.Location = new Point(6, 46);
            textBox_enc_plainText.Name = "textBox_enc_plainText";
            textBox_enc_plainText.Size = new Size(300, 27);
            textBox_enc_plainText.TabIndex = 10;
            // 
            // richTextBox_enc_plainText
            // 
            richTextBox_enc_plainText.Location = new Point(6, 100);
            richTextBox_enc_plainText.Name = "richTextBox_enc_plainText";
            richTextBox_enc_plainText.Size = new Size(405, 115);
            richTextBox_enc_plainText.TabIndex = 12;
            richTextBox_enc_plainText.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 76);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 13;
            label6.Text = "Plaintext";
            // 
            // button_enc_plaintext
            // 
            button_enc_plaintext.Location = new Point(312, 46);
            button_enc_plaintext.Name = "button_enc_plaintext";
            button_enc_plaintext.Size = new Size(99, 29);
            button_enc_plaintext.TabIndex = 14;
            button_enc_plaintext.Text = "Open";
            button_enc_plaintext.UseVisualStyleBackColor = true;
            button_enc_plaintext.Click += button_enc_plaintext_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 218);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 16;
            label7.Text = "Public Key Path";
            // 
            // textBox_enc_publicKey
            // 
            textBox_enc_publicKey.Location = new Point(6, 241);
            textBox_enc_publicKey.Name = "textBox_enc_publicKey";
            textBox_enc_publicKey.Size = new Size(300, 27);
            textBox_enc_publicKey.TabIndex = 15;
            // 
            // button_enc_publicKey
            // 
            button_enc_publicKey.Location = new Point(312, 241);
            button_enc_publicKey.Name = "button_enc_publicKey";
            button_enc_publicKey.Size = new Size(99, 29);
            button_enc_publicKey.TabIndex = 17;
            button_enc_publicKey.Text = "Open";
            button_enc_publicKey.UseVisualStyleBackColor = true;
            button_enc_publicKey.Click += button_enc_publicKey_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 271);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 19;
            label8.Text = "Format";
            // 
            // comboBox_enc_format
            // 
            comboBox_enc_format.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_enc_format.FormattingEnabled = true;
            comboBox_enc_format.Items.AddRange(new object[] { "DER", "Base64" });
            comboBox_enc_format.SelectedIndex = 0;
            comboBox_enc_format.Location = new Point(6, 294);
            comboBox_enc_format.Name = "comboBox_enc_format";
            comboBox_enc_format.Size = new Size(117, 28);
            comboBox_enc_format.TabIndex = 18;
            // 
            // button_enc_encrypt
            // 
            button_enc_encrypt.Location = new Point(312, 293);
            button_enc_encrypt.Name = "button_enc_encrypt";
            button_enc_encrypt.Size = new Size(99, 29);
            button_enc_encrypt.TabIndex = 20;
            button_enc_encrypt.Text = "Encrypt";
            button_enc_encrypt.UseVisualStyleBackColor = true;
            button_enc_encrypt.Click += button_enc_encrypt_Click;
            // 
            // richTextBox_log
            // 
            richTextBox_log.Location = new Point(6, 241);
            richTextBox_log.Name = "richTextBox_log";
            richTextBox_log.Size = new Size(296, 90);
            richTextBox_log.TabIndex = 21;
            richTextBox_log.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 218);
            label9.Name = "label9";
            label9.Size = new Size(34, 20);
            label9.TabIndex = 22;
            label9.Text = "Log";
            // 
            // button_dec_privateKey
            // 
            button_dec_privateKey.Location = new Point(320, 241);
            button_dec_privateKey.Name = "button_dec_privateKey";
            button_dec_privateKey.Size = new Size(96, 29);
            button_dec_privateKey.TabIndex = 30;
            button_dec_privateKey.Text = "Open";
            button_dec_privateKey.UseVisualStyleBackColor = true;
            button_dec_privateKey.Click += button_dec_privateKey_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 218);
            label11.Name = "label11";
            label11.Size = new Size(114, 20);
            label11.TabIndex = 29;
            label11.Text = "Private Key Path";
            // 
            // textBox_dec_privateKey
            // 
            textBox_dec_privateKey.Location = new Point(6, 241);
            textBox_dec_privateKey.Name = "textBox_dec_privateKey";
            textBox_dec_privateKey.Size = new Size(308, 27);
            textBox_dec_privateKey.TabIndex = 28;
            // 
            // button_dec_ciphert
            // 
            button_dec_ciphert.Location = new Point(320, 46);
            button_dec_ciphert.Name = "button_dec_ciphert";
            button_dec_ciphert.Size = new Size(96, 29);
            button_dec_ciphert.TabIndex = 27;
            button_dec_ciphert.Text = "Open";
            button_dec_ciphert.UseVisualStyleBackColor = true;
            button_dec_ciphert.Click += button_dec_ciphert_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 76);
            label12.Name = "label12";
            label12.Size = new Size(122, 20);
            label12.TabIndex = 26;
            label12.Text = "Plaintext Decrypt";
            // 
            // richTextBox_dec_plainText
            // 
            richTextBox_dec_plainText.Location = new Point(6, 100);
            richTextBox_dec_plainText.Name = "richTextBox_dec_plainText";
            richTextBox_dec_plainText.Size = new Size(410, 115);
            richTextBox_dec_plainText.TabIndex = 25;
            richTextBox_dec_plainText.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 23);
            label13.Name = "label13";
            label13.Size = new Size(89, 20);
            label13.TabIndex = 24;
            label13.Text = "Ciphert Path";
            // 
            // textBox_dec_ciphert
            // 
            textBox_dec_ciphert.Location = new Point(6, 46);
            textBox_dec_ciphert.Name = "textBox_dec_ciphert";
            textBox_dec_ciphert.Size = new Size(308, 27);
            textBox_dec_ciphert.TabIndex = 23;
            // 
            // textBox_enc_ciphert
            // 
            textBox_enc_ciphert.Location = new Point(129, 293);
            textBox_enc_ciphert.Name = "textBox_enc_ciphert";
            textBox_enc_ciphert.Size = new Size(177, 27);
            textBox_enc_ciphert.TabIndex = 34;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(129, 270);
            label14.Name = "label14";
            label14.Size = new Size(57, 20);
            label14.TabIndex = 35;
            label14.Text = "Ciphert";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(129, 270);
            label10.Name = "label10";
            label10.Size = new Size(122, 20);
            label10.TabIndex = 40;
            label10.Text = "Plaintext Decrypt";
            // 
            // textBox_dec_plaintext
            // 
            textBox_dec_plaintext.Location = new Point(129, 293);
            textBox_dec_plaintext.Name = "textBox_dec_plaintext";
            textBox_dec_plaintext.Size = new Size(185, 27);
            textBox_dec_plaintext.TabIndex = 39;
            // 
            // button_dec_decrypt
            // 
            button_dec_decrypt.Location = new Point(320, 293);
            button_dec_decrypt.Name = "button_dec_decrypt";
            button_dec_decrypt.Size = new Size(96, 29);
            button_dec_decrypt.TabIndex = 38;
            button_dec_decrypt.Text = "Decrypt";
            button_dec_decrypt.UseVisualStyleBackColor = true;
            button_dec_decrypt.Click += button_dec_decrypt_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 271);
            label15.Name = "label15";
            label15.Size = new Size(56, 20);
            label15.TabIndex = 37;
            label15.Text = "Format";
            // 
            // comboBox_dec_format
            // 
            comboBox_dec_format.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_dec_format.FormattingEnabled = true;
            comboBox_dec_format.Items.AddRange(new object[] { "DER", "Base64" });
            comboBox_dec_format.SelectedIndex = 0;
            comboBox_dec_format.Location = new Point(6, 294);
            comboBox_dec_format.Name = "comboBox_dec_format";
            comboBox_dec_format.Size = new Size(117, 28);
            comboBox_dec_format.TabIndex = 36;
            // 
            // button_genKey
            // 
            button_genKey.Location = new Point(106, 186);
            button_genKey.Name = "button_genKey";
            button_genKey.Size = new Size(96, 29);
            button_genKey.TabIndex = 41;
            button_genKey.Text = "GenKey";
            button_genKey.UseVisualStyleBackColor = true;
            button_genKey.Click += button_genKey_Click;
            // 
            // groupBox_encrypt
            // 
            groupBox_encrypt.Controls.Add(label5);
            groupBox_encrypt.Controls.Add(textBox_enc_plainText);
            groupBox_encrypt.Controls.Add(richTextBox_enc_plainText);
            groupBox_encrypt.Controls.Add(label6);
            groupBox_encrypt.Controls.Add(button_enc_plaintext);
            groupBox_encrypt.Controls.Add(textBox_enc_publicKey);
            groupBox_encrypt.Controls.Add(label7);
            groupBox_encrypt.Controls.Add(label14);
            groupBox_encrypt.Controls.Add(button_enc_publicKey);
            groupBox_encrypt.Controls.Add(textBox_enc_ciphert);
            groupBox_encrypt.Controls.Add(comboBox_enc_format);
            groupBox_encrypt.Controls.Add(label8);
            groupBox_encrypt.Controls.Add(button_enc_encrypt);
            groupBox_encrypt.Location = new Point(12, 12);
            groupBox_encrypt.Name = "groupBox_encrypt";
            groupBox_encrypt.Size = new Size(417, 337);
            groupBox_encrypt.TabIndex = 42;
            groupBox_encrypt.TabStop = false;
            groupBox_encrypt.Text = "Encrypt";
            // 
            // groupBox_decrypt
            // 
            groupBox_decrypt.Controls.Add(label13);
            groupBox_decrypt.Controls.Add(textBox_dec_ciphert);
            groupBox_decrypt.Controls.Add(richTextBox_dec_plainText);
            groupBox_decrypt.Controls.Add(label10);
            groupBox_decrypt.Controls.Add(label12);
            groupBox_decrypt.Controls.Add(textBox_dec_plaintext);
            groupBox_decrypt.Controls.Add(button_dec_ciphert);
            groupBox_decrypt.Controls.Add(button_dec_decrypt);
            groupBox_decrypt.Controls.Add(textBox_dec_privateKey);
            groupBox_decrypt.Controls.Add(label15);
            groupBox_decrypt.Controls.Add(label11);
            groupBox_decrypt.Controls.Add(comboBox_dec_format);
            groupBox_decrypt.Controls.Add(button_dec_privateKey);
            groupBox_decrypt.Location = new Point(749, 12);
            groupBox_decrypt.Name = "groupBox_decrypt";
            groupBox_decrypt.Size = new Size(422, 337);
            groupBox_decrypt.TabIndex = 43;
            groupBox_decrypt.TabStop = false;
            groupBox_decrypt.Text = "Decypt";
            // 
            // groupBox_genKey
            // 
            groupBox_genKey.Controls.Add(label1);
            groupBox_genKey.Controls.Add(comboBox_keySize);
            groupBox_genKey.Controls.Add(comboBox_format);
            groupBox_genKey.Controls.Add(button_genKey);
            groupBox_genKey.Controls.Add(label2);
            groupBox_genKey.Controls.Add(label9);
            groupBox_genKey.Controls.Add(textBox_privateKey);
            groupBox_genKey.Controls.Add(richTextBox_log);
            groupBox_genKey.Controls.Add(label3);
            groupBox_genKey.Controls.Add(button_decrypt);
            groupBox_genKey.Controls.Add(textBox_publicKey);
            groupBox_genKey.Controls.Add(button_encrypt);
            groupBox_genKey.Controls.Add(label4);
            groupBox_genKey.Location = new Point(435, 12);
            groupBox_genKey.Name = "groupBox_genKey";
            groupBox_genKey.Size = new Size(308, 337);
            groupBox_genKey.TabIndex = 44;
            groupBox_genKey.TabStop = false;
            groupBox_genKey.Text = "GenKey";
            // 
            // RSA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 360);
            Controls.Add(groupBox_genKey);
            Controls.Add(groupBox_decrypt);
            Controls.Add(groupBox_encrypt);
            Name = "RSA";
            Text = "RSA";
            groupBox_encrypt.ResumeLayout(false);
            groupBox_encrypt.PerformLayout();
            groupBox_decrypt.ResumeLayout(false);
            groupBox_decrypt.PerformLayout();
            groupBox_genKey.ResumeLayout(false);
            groupBox_genKey.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox_keySize;
        private ComboBox comboBox_format;
        private Label label1;
        private Label label2;
        private TextBox textBox_privateKey;
        private Label label3;
        private Label label4;
        private TextBox textBox_publicKey;
        private Button button_encrypt;
        private Button button_decrypt;
        private Label label5;
        private TextBox textBox_enc_plainText;
        private RichTextBox richTextBox_enc_plainText;
        private Label label6;
        private Button button_enc_plaintext;
        private Label label7;
        private TextBox textBox_enc_publicKey;
        private Button button_enc_publicKey;
        private Label label8;
        private ComboBox comboBox_enc_format;
        private Button button_enc_encrypt;
        private RichTextBox richTextBox_log;
        private Label label9;
        private Button button_dec_privateKey;
        private Label label11;
        private TextBox textBox_dec_privateKey;
        private Button button_dec_ciphert;
        private Label label12;
        private RichTextBox richTextBox_dec_plainText;
        private Label label13;
        private TextBox textBox_dec_ciphert;
        private TextBox textBox_enc_ciphert;
        private Label label14;
        private Label label10;
        private TextBox textBox_dec_plaintext;
        private Button button_dec_decrypt;
        private Label label15;
        private ComboBox comboBox_dec_format;
        private Button button_genKey;
        private GroupBox groupBox_encrypt;
        private GroupBox groupBox_decrypt;
        private GroupBox groupBox_genKey;
    }
}
