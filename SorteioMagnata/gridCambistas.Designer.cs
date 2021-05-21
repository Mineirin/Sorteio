
namespace SorteioMagnata
{
    partial class gridCambistas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gridCambistas));
            this.dgvCambistas = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.lbCelular = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambistas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCambistas
            // 
            this.dgvCambistas.AllowUserToAddRows = false;
            this.dgvCambistas.AllowUserToDeleteRows = false;
            this.dgvCambistas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCambistas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCambistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCambistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.excluir});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCambistas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCambistas.Location = new System.Drawing.Point(0, 75);
            this.dgvCambistas.Name = "dgvCambistas";
            this.dgvCambistas.ReadOnly = true;
            this.dgvCambistas.RowHeadersWidth = 4;
            this.dgvCambistas.Size = new System.Drawing.Size(801, 505);
            this.dgvCambistas.TabIndex = 1;
            this.dgvCambistas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCambistas_CellContentClick);
            this.dgvCambistas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCambistas_CellFormatting);
            this.dgvCambistas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCambistas_DataBindingComplete);
            // 
            // editar
            // 
            this.editar.HeaderText = "";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Width = 30;
            // 
            // excluir
            // 
            this.excluir.HeaderText = "";
            this.excluir.Image = ((System.Drawing.Image)(resources.GetObject("excluir.Image")));
            this.excluir.Name = "excluir";
            this.excluir.ReadOnly = true;
            this.excluir.Width = 30;
            // 
            // btnFechar
            // 
            this.btnFechar.Enabled = false;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(610, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(65, 65);
            this.btnFechar.TabIndex = 32;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(539, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 65);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            // 
            // txtCelular
            // 
            this.txtCelular.Enabled = false;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(382, 22);
            this.txtCelular.Mask = "(00)00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(137, 26);
            this.txtCelular.TabIndex = 28;
            this.txtCelular.Visible = false;
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelular.Location = new System.Drawing.Point(312, 25);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(70, 20);
            this.lbCelular.TabIndex = 30;
            this.lbCelular.Text = "Celular:";
            this.lbCelular.Visible = false;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(12, 25);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(60, 20);
            this.lbNome.TabIndex = 29;
            this.lbNome.Text = "Nome:";
            this.lbNome.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(72, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(222, 26);
            this.txtNome.TabIndex = 27;
            this.txtNome.Visible = false;
            // 
            // gridCambistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvCambistas);
            this.Name = "gridCambistas";
            this.Text = "Cambistas";
            this.Load += new System.EventHandler(this.gridCambistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCambistas;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn excluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
    }
}