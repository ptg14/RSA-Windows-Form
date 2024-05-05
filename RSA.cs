using System.Runtime.InteropServices;

namespace RSA_WF
{
    public partial class RSA : Form
    {
        public RSA()
        {
            InitializeComponent();

            comboBox_keySize.SelectedIndex = 0;
            comboBox_format.SelectedIndex = 0;
            comboBox_enc_format.SelectedIndex = 0;
            comboBox_dec_format.SelectedIndex = 0;

            originalWidth = Width;
            originalGenKeyLocation = groupBox_genKey.Location;
            originalDecryptLocation = groupBox_decrypt.Location;

            groupBox_encrypt.Visible = false;
            groupBox_decrypt.Visible = false;
            groupBox_genKey.Location = groupBox_encrypt.Location;
            Width = groupBox_genKey.Width + 40;
            EncVisible = false;
            DecVisible = false;
        }

        [DllImport("RSA_DLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void GenerateAndSaveRSAKeys(int keySize, string format, string privateKeyFile, string publicKeyFile);

        [DllImport("RSA_DLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void RSAencrypt(string format, string publicKeyFile, string plainTextFile, string ciphertFile);

        [DllImport("RSA_DLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void RSAdecrypt(string format, string secretKeyFile, string ciphertFile, string plainTextFile);

        private bool EncVisible;
        private bool DecVisible;

        private int originalWidth;

        private Point originalGenKeyLocation;
        private Point originalDecryptLocation;

        private void button_genKey_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the key size and format
                int keySize = int.Parse(comboBox_keySize.SelectedItem.ToString());
                string format = comboBox_format.SelectedItem.ToString();

                // Get the private and public key names
                string privateKeyFile = textBox_privateKey.Text != "" ? textBox_privateKey.Text : "PrivateKey";
                string publicKeyFile = textBox_publicKey.Text != "" ? textBox_publicKey.Text : "PublicKey";

                // Generate and save the RSA keys
                try
                {
                    GenerateAndSaveRSAKeys(keySize, format, privateKeyFile, publicKeyFile);
                }
                catch (Exception ex)
                {
                    richTextBox_log.Text += "Error generating and saving RSA keys: " + ex.Message + "\n";
                }

                // Update the TextBoxes with the full paths
                string privateKeyPath = Path.Combine(Application.StartupPath, privateKeyFile);
                string publicKeyPath = Path.Combine(Application.StartupPath, publicKeyFile);
                textBox_privateKey.Text = privateKeyPath;
                textBox_publicKey.Text = privateKeyPath;

                richTextBox_log.Text += "Saved private key to file: " + privateKeyPath + "\n";
                richTextBox_log.Text += "Saved public key to file: " + publicKeyPath + "\n";
                richTextBox_log.Text += "~~RSA keys generated and saved successfully.~~\n";
            }
            catch (Exception ex)
            {
                richTextBox_log.Text += "Error generating and saving RSA keys: " + ex.Message + "\n";
            }
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            if (EncVisible && DecVisible)
            {
                groupBox_encrypt.Visible = false;
                groupBox_genKey.Location = groupBox_encrypt.Location;
                groupBox_decrypt.Location = new Point(groupBox_genKey.Width + 20, 0);
                Width = originalWidth - (groupBox_encrypt.Width + 14);
                EncVisible = false;
            }
            else if (DecVisible)
            {
                groupBox_genKey.Location = originalGenKeyLocation;
                groupBox_decrypt.Location = originalDecryptLocation;
                Width = originalWidth;
                groupBox_encrypt.Visible = true;
                EncVisible = true;
            }
            else if (EncVisible && !DecVisible)
            {
                groupBox_encrypt.Visible = false;
                groupBox_genKey.Location = groupBox_encrypt.Location;
                Width = groupBox_genKey.Width + 40;
                EncVisible = false;
            }
            else
            {
                groupBox_genKey.Location = originalGenKeyLocation;
                Width = originalWidth - (groupBox_decrypt.Width + 14);
                groupBox_encrypt.Visible = true;
                EncVisible = true;
            }
        }

        private void button_decrypt_Click(object sender, EventArgs e)
        {
            if (DecVisible && EncVisible)
            {
                Width = originalWidth - (groupBox_decrypt.Width + 14);
                groupBox_decrypt.Visible = false;
                DecVisible = false;
            }
            else if (EncVisible)
            {
                groupBox_decrypt.Location = originalDecryptLocation;
                Width = originalWidth;
                groupBox_decrypt.Visible = true;
                DecVisible = true;
            }
            else if (DecVisible && !EncVisible)
            {
                Width = groupBox_genKey.Width + 40;
                groupBox_decrypt.Visible = false;
                DecVisible = false;
            }
            else
            {
                groupBox_decrypt.Location = new Point(groupBox_genKey.Width + 20, 0);
                Width = originalWidth - (groupBox_encrypt.Width + 14);
                groupBox_decrypt.Visible = true;
                DecVisible = true;
            }
        }

        private void button_enc_plaintext_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory and filter
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            // Show the OpenFileDialog and check if a file was selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the textBox_enc_plaintext to the selected file path
                textBox_enc_plainText.Text = openFileDialog.FileName;

                // Read the contents of the file
                string fileContents = File.ReadAllText(openFileDialog.FileName);

                // Display the contents in the RichTextBox
                richTextBox_enc_plainText.Clear();
                richTextBox_enc_plainText.Text = fileContents;
            }
        }

        private void button_enc_publicKey_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory and filter
            openFileDialog.InitialDirectory = Application.StartupPath;

            // Show the OpenFileDialog and check if a file was selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the textBox_enc_publicKey to the selected file path
                textBox_enc_publicKey.Text = openFileDialog.FileName;
            }
        }

        private void button_enc_encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox_enc_publicKey.Text))
                {
                    richTextBox_log.Text += "Error: Please select a public key.\n";
                    return;
                }

                string ciphertFile = textBox_enc_ciphert.Text != "" ? textBox_enc_ciphert.Text : "Ciphert";

                if (string.IsNullOrEmpty(richTextBox_enc_plainText.Text))
                {
                    if (string.IsNullOrEmpty(textBox_enc_plainText.Text))
                    {
                        richTextBox_log.Text += "Error: Please select or enter a plaintext.\n";
                        return;
                    }
                    else
                    {
                        // Check if the file exists
                        if (!File.Exists(textBox_enc_plainText.Text))
                        {
                            richTextBox_log.Text += "Error: Plaintext file not found.\n";
                            return;
                        }
                        if (!File.Exists(textBox_enc_publicKey.Text))
                        {
                            richTextBox_log.Text += "Error: Public key file not found.\n";
                            return;
                        }

                        RSAencrypt(comboBox_enc_format.SelectedItem.ToString(), textBox_enc_publicKey.Text, textBox_enc_plainText.Text, ciphertFile);
                    }
                }
                else
                {
                    // Generate a random file name
                    string fileName = Path.GetRandomFileName() + ".txt";

                    // Get the full path of the file
                    string filePath = Path.Combine(Application.StartupPath, fileName);

                    // Save the contents of the RichTextBox to the file
                    File.WriteAllText(filePath, richTextBox_enc_plainText.Text);

                    // Log the file path
                    richTextBox_log.Text += "Saved plaintext to file: " + filePath + "\n";

                    // Check if the file exists
                    if (!File.Exists(filePath))
                    {
                        richTextBox_log.Text += "Error: The newly created plaintext file was not found.\n";
                        return;
                    }
                    if (!File.Exists(textBox_enc_publicKey.Text))
                    {
                        richTextBox_log.Text += "Error: Public key file not found.\n";
                        return;
                    }

                    RSAencrypt(comboBox_enc_format.SelectedItem.ToString(), textBox_enc_publicKey.Text, filePath, ciphertFile);
                }

                textBox_enc_ciphert.Text = Path.Combine(Application.StartupPath, ciphertFile);

                richTextBox_log.Text += "~~Encrypt successfully.~~\n";
            }
            catch (Exception ex)
            {
                richTextBox_log.Text += "Error encrypt: " + ex.Message + "\n";
            }
        }

        private void button_dec_ciphert_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory and filter
            openFileDialog.InitialDirectory = Application.StartupPath;

            // Show the OpenFileDialog and check if a file was selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the textBox_enc_publicKey to the selected file path
                textBox_dec_ciphert.Text = openFileDialog.FileName;
            }
        }

        private void button_dec_privateKey_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory and filter
            openFileDialog.InitialDirectory = Application.StartupPath;

            // Show the OpenFileDialog and check if a file was selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the textBox_enc_publicKey to the selected file path
                textBox_dec_privateKey.Text = openFileDialog.FileName;
            }
        }

        private void button_dec_decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox_dec_privateKey.Text))
                {
                    richTextBox_log.Text += "Error: Please select a private key.\n";
                    return;
                }
                if (string.IsNullOrEmpty(textBox_dec_ciphert.Text))
                {
                    richTextBox_log.Text += "Error: Please select a ciphert file.\n";
                    return;
                }

                // Check if the file exists
                if (!File.Exists(textBox_dec_privateKey.Text))
                {
                    richTextBox_log.Text += "Error: Private key file not found.\n";
                    return;
                }
                if (!File.Exists(textBox_dec_ciphert.Text))
                {
                    richTextBox_log.Text += "Error: Ciphert file not found.\n";
                    return;
                }

                string plaintextFile = textBox_dec_plaintext.Text != "" ? textBox_dec_plaintext.Text : "PlaintextDecrypt.txt";

                RSAdecrypt(comboBox_dec_format.SelectedItem.ToString(), textBox_dec_privateKey.Text, textBox_dec_ciphert.Text, plaintextFile);

                // Read the contents of the plaintextFile
                string fileContents = File.ReadAllText(plaintextFile);

                // Display the contents in the RichTextBox
                richTextBox_dec_plainText.Text = fileContents;

                string plaintextFilePath = Path.Combine(Application.StartupPath, plaintextFile);
                textBox_dec_plaintext.Text = plaintextFilePath;

                richTextBox_log.Text += "Saved plaintext decrypt to file: " + plaintextFilePath + "\n";

                richTextBox_log.Text += "~~Decrypt successfully.~~\n";
            }
            catch (Exception ex)
            {
                richTextBox_log.Text += "Error decrypt: " + ex.Message + "\n";
            }
        }
    }
}
