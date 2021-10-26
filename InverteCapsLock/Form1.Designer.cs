namespace InverteCapsLock
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnInverter = new System.Windows.Forms.Button();
            this.pnlCaioBarbosa = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblBarbosa = new System.Windows.Forms.Label();
            this.lblCaio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInverterSeNecessario = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnInverterSeNecessarioEmSegundoPlano = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.nfiIconeBandeja = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnParar = new System.Windows.Forms.Button();
            this.pnlCaioBarbosa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInverter
            // 
            this.btnInverter.Location = new System.Drawing.Point(176, 63);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(78, 31);
            this.btnInverter.TabIndex = 0;
            this.btnInverter.Text = "Executar!";
            this.btnInverter.UseVisualStyleBackColor = true;
            this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
            // 
            // pnlCaioBarbosa
            // 
            this.pnlCaioBarbosa.Controls.Add(this.pbxLogo);
            this.pnlCaioBarbosa.Controls.Add(this.lblBarbosa);
            this.pnlCaioBarbosa.Controls.Add(this.lblCaio);
            this.pnlCaioBarbosa.Cursor = System.Windows.Forms.Cursors.Help;
            this.pnlCaioBarbosa.Location = new System.Drawing.Point(12, 341);
            this.pnlCaioBarbosa.Name = "pnlCaioBarbosa";
            this.pnlCaioBarbosa.Size = new System.Drawing.Size(80, 32);
            this.pnlCaioBarbosa.TabIndex = 10;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::InverteCapsLock.Properties.Resources.logo;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(27, 32);
            this.pbxLogo.TabIndex = 6;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.pbxLogo_Click);
            // 
            // lblBarbosa
            // 
            this.lblBarbosa.AutoSize = true;
            this.lblBarbosa.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarbosa.Location = new System.Drawing.Point(29, 15);
            this.lblBarbosa.Name = "lblBarbosa";
            this.lblBarbosa.Size = new System.Drawing.Size(50, 14);
            this.lblBarbosa.TabIndex = 8;
            this.lblBarbosa.Text = "Barbosa";
            this.lblBarbosa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBarbosa.Click += new System.EventHandler(this.lblBarbosa_Click);
            // 
            // lblCaio
            // 
            this.lblCaio.AutoSize = true;
            this.lblCaio.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaio.Location = new System.Drawing.Point(29, 3);
            this.lblCaio.Name = "lblCaio";
            this.lblCaio.Size = new System.Drawing.Size(30, 14);
            this.lblCaio.TabIndex = 7;
            this.lblCaio.Text = "Caio";
            this.lblCaio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCaio.Click += new System.EventHandler(this.lblCaio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInverter);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simplesmente Inverter";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(15, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(230, 55);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "Escolha esta opção se deseja apenas inverter a tecla Caps Lock, sem levar em cons" +
    "ideração o correto status do LED, em relação a tecla Caps Lock.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInverterSeNecessario);
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inverter se Necessário";
            // 
            // btnInverterSeNecessario
            // 
            this.btnInverterSeNecessario.Location = new System.Drawing.Point(176, 63);
            this.btnInverterSeNecessario.Name = "btnInverterSeNecessario";
            this.btnInverterSeNecessario.Size = new System.Drawing.Size(78, 31);
            this.btnInverterSeNecessario.TabIndex = 0;
            this.btnInverterSeNecessario.Text = "Executar!";
            this.btnInverterSeNecessario.UseVisualStyleBackColor = true;
            this.btnInverterSeNecessario.Click += new System.EventHandler(this.btnInverterSeNecessario_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(12, 19);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(230, 55);
            this.richTextBox2.TabIndex = 13;
            this.richTextBox2.Text = "Escolha esta opção se deseja inverter caso necessário, ou seja, se o LED não coni" +
    "ncidir com o status do Caps Lock.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnParar);
            this.groupBox3.Controls.Add(this.lblStatus);
            this.groupBox3.Controls.Add(this.btnInverterSeNecessarioEmSegundoPlano);
            this.groupBox3.Controls.Add(this.richTextBox3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inverter se Necessário em Segundo Plano";
            // 
            // btnInverterSeNecessarioEmSegundoPlano
            // 
            this.btnInverterSeNecessarioEmSegundoPlano.Location = new System.Drawing.Point(176, 63);
            this.btnInverterSeNecessarioEmSegundoPlano.Name = "btnInverterSeNecessarioEmSegundoPlano";
            this.btnInverterSeNecessarioEmSegundoPlano.Size = new System.Drawing.Size(78, 31);
            this.btnInverterSeNecessarioEmSegundoPlano.TabIndex = 0;
            this.btnInverterSeNecessarioEmSegundoPlano.Text = "Executar!";
            this.btnInverterSeNecessarioEmSegundoPlano.UseVisualStyleBackColor = true;
            this.btnInverterSeNecessarioEmSegundoPlano.Click += new System.EventHandler(this.btnInverterSeNecessarioEmSegundoPlano_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox3.Enabled = false;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(12, 19);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox3.Size = new System.Drawing.Size(230, 55);
            this.richTextBox3.TabIndex = 13;
            this.richTextBox3.Text = "Escolha esta opção se deseja inverter caso necessário, ou seja, se o LED não coni" +
    "ncidir com o status do Caps Lock. Entretanto, em segundo plano.";
            // 
            // nfiIconeBandeja
            // 
            this.nfiIconeBandeja.BalloonTipText = "Inverter Caps Lock agora se encontra aqui, pois está trabalhando em segundo plano" +
    ".";
            this.nfiIconeBandeja.BalloonTipTitle = "ATENÇÃO";
            this.nfiIconeBandeja.Icon = ((System.Drawing.Icon)(resources.GetObject("nfiIconeBandeja.Icon")));
            this.nfiIconeBandeja.Text = "Inverter Caps Lock";
            this.nfiIconeBandeja.Visible = true;
            this.nfiIconeBandeja.DoubleClick += new System.EventHandler(this.nfiIconeBandeja_DoubleClick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(9, 81);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 13);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Executando!";
            this.lblStatus.Visible = false;
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(93, 63);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(78, 31);
            this.btnParar.TabIndex = 15;
            this.btnParar.Text = "Parar!";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Visible = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 378);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnlCaioBarbosa);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Inverter Caps Lock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.pnlCaioBarbosa.ResumeLayout(false);
            this.pnlCaioBarbosa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Panel pnlCaioBarbosa;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblBarbosa;
        private System.Windows.Forms.Label lblCaio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInverterSeNecessario;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnInverterSeNecessarioEmSegundoPlano;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.NotifyIcon nfiIconeBandeja;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnParar;
    }
}

