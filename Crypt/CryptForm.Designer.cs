namespace Crypt
{
    partial class CryptForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectArchiveButton = new System.Windows.Forms.Button();
            this.generateKeysButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.savePublicKey = new System.Windows.Forms.Button();
            this.importPublicKey = new System.Windows.Forms.Button();
            this.importPrivateKey = new System.Windows.Forms.Button();
            this.savePrivateKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectArchiveButton
            // 
            this.selectArchiveButton.Location = new System.Drawing.Point(12, 12);
            this.selectArchiveButton.Name = "selectArchiveButton";
            this.selectArchiveButton.Size = new System.Drawing.Size(165, 23);
            this.selectArchiveButton.TabIndex = 0;
            this.selectArchiveButton.Text = "Selecionar Arquivo";
            this.selectArchiveButton.UseVisualStyleBackColor = true;
            this.selectArchiveButton.Click += new System.EventHandler(this.selectArchiveButton_Click);
            // 
            // generateKeysButton
            // 
            this.generateKeysButton.Location = new System.Drawing.Point(12, 41);
            this.generateKeysButton.Name = "generateKeysButton";
            this.generateKeysButton.Size = new System.Drawing.Size(165, 23);
            this.generateKeysButton.TabIndex = 1;
            this.generateKeysButton.Text = "Gerar Chaves";
            this.generateKeysButton.UseVisualStyleBackColor = true;
            this.generateKeysButton.Click += new System.EventHandler(this.generateKeysButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(12, 70);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(165, 23);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Criptografar";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(12, 99);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(165, 23);
            this.DecryptButton.TabIndex = 3;
            this.DecryptButton.Text = "Descriptografar";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // savePublicKey
            // 
            this.savePublicKey.Location = new System.Drawing.Point(12, 128);
            this.savePublicKey.Name = "savePublicKey";
            this.savePublicKey.Size = new System.Drawing.Size(165, 23);
            this.savePublicKey.TabIndex = 4;
            this.savePublicKey.Text = "Salvar chave pública";
            this.savePublicKey.UseVisualStyleBackColor = true;
            this.savePublicKey.Click += new System.EventHandler(this.savePublicKey_Click);
            // 
            // importPublicKey
            // 
            this.importPublicKey.Location = new System.Drawing.Point(12, 157);
            this.importPublicKey.Name = "importPublicKey";
            this.importPublicKey.Size = new System.Drawing.Size(165, 23);
            this.importPublicKey.TabIndex = 5;
            this.importPublicKey.Text = "Importar chave Pública";
            this.importPublicKey.UseVisualStyleBackColor = true;
            this.importPublicKey.Click += new System.EventHandler(this.importPublicKey_Click);
            // 
            // importPrivateKey
            // 
            this.importPrivateKey.Location = new System.Drawing.Point(12, 215);
            this.importPrivateKey.Name = "importPrivateKey";
            this.importPrivateKey.Size = new System.Drawing.Size(165, 23);
            this.importPrivateKey.TabIndex = 7;
            this.importPrivateKey.Text = "Importar chave Privada";
            this.importPrivateKey.UseVisualStyleBackColor = true;
            this.importPrivateKey.Click += new System.EventHandler(this.importPrivateKey_Click);
            // 
            // savePrivateKey
            // 
            this.savePrivateKey.Location = new System.Drawing.Point(12, 186);
            this.savePrivateKey.Name = "savePrivateKey";
            this.savePrivateKey.Size = new System.Drawing.Size(165, 23);
            this.savePrivateKey.TabIndex = 6;
            this.savePrivateKey.Text = "Salvar chave Privada";
            this.savePrivateKey.UseVisualStyleBackColor = true;
            this.savePrivateKey.Click += new System.EventHandler(this.savePrivateKey_Click);
            // 
            // CryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 253);
            this.Controls.Add(this.importPrivateKey);
            this.Controls.Add(this.savePrivateKey);
            this.Controls.Add(this.importPublicKey);
            this.Controls.Add(this.savePublicKey);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.generateKeysButton);
            this.Controls.Add(this.selectArchiveButton);
            this.Name = "CryptForm";
            this.Text = "Crypt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectArchiveButton;
        private System.Windows.Forms.Button generateKeysButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button savePublicKey;
        private System.Windows.Forms.Button importPublicKey;
        private System.Windows.Forms.Button importPrivateKey;
        private System.Windows.Forms.Button savePrivateKey;
    }
}

