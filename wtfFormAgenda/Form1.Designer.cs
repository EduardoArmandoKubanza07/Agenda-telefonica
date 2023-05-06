namespace wtfFormAgenda
{
    partial class formAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAgenda));
            this.btnGravar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.txtNomeCompleto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNomeCompleto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTelemovel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbDataNascimento = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGenero = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTelemovel = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboxGenero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpDataNascimento = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.BorderRadius = 8;
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGravar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGravar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGravar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGravar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(9, 338);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(160, 40);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BorderRadius = 8;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(178, 338);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(160, 40);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 8;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(344, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 40);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.BorderRadius = 8;
            this.txtNomeCompleto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeCompleto.DefaultText = "";
            this.txtNomeCompleto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomeCompleto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomeCompleto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeCompleto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeCompleto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeCompleto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCompleto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeCompleto.Location = new System.Drawing.Point(12, 49);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.PasswordChar = '\0';
            this.txtNomeCompleto.PlaceholderText = "Nome Completo";
            this.txtNomeCompleto.SelectedText = "";
            this.txtNomeCompleto.Size = new System.Drawing.Size(273, 36);
            this.txtNomeCompleto.TabIndex = 3;
            this.txtNomeCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeCompleto_KeyPress);
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.Location = new System.Drawing.Point(12, 23);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(126, 20);
            this.lblNomeCompleto.TabIndex = 4;
            this.lblNomeCompleto.Text = "Nome Completo ";
            // 
            // lblTelemovel
            // 
            this.lblTelemovel.BackColor = System.Drawing.Color.Transparent;
            this.lblTelemovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelemovel.Location = new System.Drawing.Point(13, 102);
            this.lblTelemovel.Name = "lblTelemovel";
            this.lblTelemovel.Size = new System.Drawing.Size(83, 22);
            this.lblTelemovel.TabIndex = 5;
            this.lblTelemovel.Text = "Telemóvel";
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lbDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascimento.Location = new System.Drawing.Point(13, 184);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(156, 20);
            this.lbDataNascimento.TabIndex = 6;
            this.lbDataNascimento.Text = "Data de Nascimento\r\n ";
            // 
            // lblGenero
            // 
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(13, 260);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(59, 20);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "Género";
            // 
            // txtTelemovel
            // 
            this.txtTelemovel.AcceptsReturn = true;
            this.txtTelemovel.BorderRadius = 8;
            this.txtTelemovel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelemovel.DefaultText = "";
            this.txtTelemovel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelemovel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelemovel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelemovel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelemovel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelemovel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelemovel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelemovel.Location = new System.Drawing.Point(13, 130);
            this.txtTelemovel.Name = "txtTelemovel";
            this.txtTelemovel.PasswordChar = '\0';
            this.txtTelemovel.PlaceholderText = "Telemóvel";
            this.txtTelemovel.SelectedText = "";
            this.txtTelemovel.Size = new System.Drawing.Size(272, 36);
            this.txtTelemovel.TabIndex = 8;
            this.txtTelemovel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelemovel_KeyPress);
            // 
            // cboxGenero
            // 
            this.cboxGenero.BackColor = System.Drawing.Color.Transparent;
            this.cboxGenero.BorderRadius = 8;
            this.cboxGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGenero.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxGenero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboxGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxGenero.ItemHeight = 30;
            this.cboxGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Neutro"});
            this.cboxGenero.Location = new System.Drawing.Point(12, 286);
            this.cboxGenero.Name = "cboxGenero";
            this.cboxGenero.Size = new System.Drawing.Size(273, 36);
            this.cboxGenero.StartIndex = 0;
            this.cboxGenero.TabIndex = 9;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.BorderRadius = 8;
            this.dtpDataNascimento.Checked = true;
            this.dtpDataNascimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDataNascimento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtpDataNascimento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(13, 210);
            this.dtpDataNascimento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDataNascimento.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(272, 36);
            this.dtpDataNascimento.TabIndex = 10;
            this.dtpDataNascimento.Value = new System.DateTime(2023, 5, 4, 21, 10, 44, 933);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(215, 290);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(215, 290);
            this.guna2ImageButton1.Location = new System.Drawing.Point(305, 23);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(215, 290);
            this.guna2ImageButton1.Size = new System.Drawing.Size(199, 299);
            this.guna2ImageButton1.TabIndex = 11;
            this.guna2ImageButton1.UseTransparentBackground = true;
            // 
            // formAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 390);
            this.ControlBox = false;
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.cboxGenero);
            this.Controls.Add(this.txtTelemovel);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lbDataNascimento);
            this.Controls.Add(this.lblTelemovel);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "formAgenda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Telefónica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnGravar;
        private Guna.UI2.WinForms.Guna2Button btnLimpar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeCompleto;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNomeCompleto;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTelemovel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbDataNascimento;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGenero;
        private Guna.UI2.WinForms.Guna2TextBox txtTelemovel;
        private Guna.UI2.WinForms.Guna2ComboBox cboxGenero;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataNascimento;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}

