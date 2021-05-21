
namespace SorteioMagnata
{
    partial class gridApostas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gridApostas));
            this.dgvApostas = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.txtNumeroAposta10 = new System.Windows.Forms.TextBox();
            this.txtNumeroAposta9 = new System.Windows.Forms.TextBox();
            this.txtNumeroAposta8 = new System.Windows.Forms.TextBox();
            this.txtNumeroAposta7 = new System.Windows.Forms.TextBox();
            this.txtNumeroAposta6 = new System.Windows.Forms.TextBox();
            this.txtNumeroAposta5 = new System.Windows.Forms.TextBox();
            this.txtNumeroAposta4 = new System.Windows.Forms.TextBox();
            this.txtNumeroAposta3 = new System.Windows.Forms.TextBox();
            this.txtNumeroAposta2 = new System.Windows.Forms.TextBox();
            this.txtNumeroAposta1 = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApostas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApostas
            // 
            this.dgvApostas.AllowUserToAddRows = false;
            this.dgvApostas.AllowUserToDeleteRows = false;
            this.dgvApostas.BackgroundColor = System.Drawing.Color.White;
            this.dgvApostas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApostas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApostas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApostas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.excluir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApostas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApostas.Location = new System.Drawing.Point(-1, 112);
            this.dgvApostas.Name = "dgvApostas";
            this.dgvApostas.ReadOnly = true;
            this.dgvApostas.RowHeadersWidth = 4;
            this.dgvApostas.Size = new System.Drawing.Size(801, 467);
            this.dgvApostas.TabIndex = 2;
            this.dgvApostas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApostas_CellContentClick);
            this.dgvApostas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvApostas_CellFormatting);
            this.dgvApostas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvApostas_DataBindingComplete);
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
            this.btnFechar.Location = new System.Drawing.Point(627, -2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(65, 65);
            this.btnFechar.TabIndex = 37;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(556, -3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 65);
            this.btnSalvar.TabIndex = 36;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(164, 21);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(60, 20);
            this.lbNome.TabIndex = 35;
            this.lbNome.Text = "Nome:";
            this.lbNome.Visible = false;
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnAleatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAleatorio.BackgroundImage")));
            this.btnAleatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAleatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAleatorio.FlatAppearance.BorderSize = 0;
            this.btnAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAleatorio.Location = new System.Drawing.Point(500, 5);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(50, 50);
            this.btnAleatorio.TabIndex = 48;
            this.btnAleatorio.UseVisualStyleBackColor = false;
            this.btnAleatorio.Visible = false;
            // 
            // txtNumeroAposta10
            // 
            this.txtNumeroAposta10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroAposta10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.txtNumeroAposta10.Location = new System.Drawing.Point(585, 68);
            this.txtNumeroAposta10.Name = "txtNumeroAposta10";
            this.txtNumeroAposta10.Size = new System.Drawing.Size(42, 38);
            this.txtNumeroAposta10.TabIndex = 47;
            this.txtNumeroAposta10.Visible = false;
            // 
            // txtNumeroAposta9
            // 
            this.txtNumeroAposta9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroAposta9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.txtNumeroAposta9.Location = new System.Drawing.Point(537, 68);
            this.txtNumeroAposta9.Name = "txtNumeroAposta9";
            this.txtNumeroAposta9.Size = new System.Drawing.Size(42, 38);
            this.txtNumeroAposta9.TabIndex = 46;
            this.txtNumeroAposta9.Visible = false;
            // 
            // txtNumeroAposta8
            // 
            this.txtNumeroAposta8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroAposta8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.txtNumeroAposta8.Location = new System.Drawing.Point(489, 68);
            this.txtNumeroAposta8.Name = "txtNumeroAposta8";
            this.txtNumeroAposta8.Size = new System.Drawing.Size(42, 38);
            this.txtNumeroAposta8.TabIndex = 45;
            this.txtNumeroAposta8.Visible = false;
            // 
            // txtNumeroAposta7
            // 
            this.txtNumeroAposta7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroAposta7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.txtNumeroAposta7.Location = new System.Drawing.Point(441, 68);
            this.txtNumeroAposta7.Name = "txtNumeroAposta7";
            this.txtNumeroAposta7.Size = new System.Drawing.Size(42, 38);
            this.txtNumeroAposta7.TabIndex = 44;
            this.txtNumeroAposta7.Visible = false;
            // 
            // txtNumeroAposta6
            // 
            this.txtNumeroAposta6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroAposta6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.txtNumeroAposta6.Location = new System.Drawing.Point(393, 68);
            this.txtNumeroAposta6.MaxLength = 2;
            this.txtNumeroAposta6.Name = "txtNumeroAposta6";
            this.txtNumeroAposta6.Size = new System.Drawing.Size(42, 38);
            this.txtNumeroAposta6.TabIndex = 43;
            this.txtNumeroAposta6.Visible = false;
            // 
            // txtNumeroAposta5
            // 
            this.txtNumeroAposta5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroAposta5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.txtNumeroAposta5.Location = new System.Drawing.Point(345, 68);
            this.txtNumeroAposta5.Name = "txtNumeroAposta5";
            this.txtNumeroAposta5.Size = new System.Drawing.Size(42, 38);
            this.txtNumeroAposta5.TabIndex = 42;
            this.txtNumeroAposta5.Visible = false;
            // 
            // txtNumeroAposta4
            // 
            this.txtNumeroAposta4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroAposta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.txtNumeroAposta4.Location = new System.Drawing.Point(297, 68);
            this.txtNumeroAposta4.Name = "txtNumeroAposta4";
            this.txtNumeroAposta4.Size = new System.Drawing.Size(42, 38);
            this.txtNumeroAposta4.TabIndex = 41;
            this.txtNumeroAposta4.Visible = false;
            // 
            // txtNumeroAposta3
            // 
            this.txtNumeroAposta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroAposta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.txtNumeroAposta3.Location = new System.Drawing.Point(249, 68);
            this.txtNumeroAposta3.Name = "txtNumeroAposta3";
            this.txtNumeroAposta3.Size = new System.Drawing.Size(42, 38);
            this.txtNumeroAposta3.TabIndex = 40;
            this.txtNumeroAposta3.Visible = false;
            // 
            // txtNumeroAposta2
            // 
            this.txtNumeroAposta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroAposta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.txtNumeroAposta2.Location = new System.Drawing.Point(201, 68);
            this.txtNumeroAposta2.Name = "txtNumeroAposta2";
            this.txtNumeroAposta2.Size = new System.Drawing.Size(42, 38);
            this.txtNumeroAposta2.TabIndex = 39;
            this.txtNumeroAposta2.Visible = false;
            // 
            // txtNumeroAposta1
            // 
            this.txtNumeroAposta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroAposta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.txtNumeroAposta1.Location = new System.Drawing.Point(153, 68);
            this.txtNumeroAposta1.MaxLength = 2;
            this.txtNumeroAposta1.Name = "txtNumeroAposta1";
            this.txtNumeroAposta1.Size = new System.Drawing.Size(42, 38);
            this.txtNumeroAposta1.TabIndex = 38;
            this.txtNumeroAposta1.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(230, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(222, 26);
            this.txtNome.TabIndex = 49;
            // 
            // gridApostas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.txtNumeroAposta10);
            this.Controls.Add(this.txtNumeroAposta9);
            this.Controls.Add(this.txtNumeroAposta8);
            this.Controls.Add(this.txtNumeroAposta7);
            this.Controls.Add(this.txtNumeroAposta6);
            this.Controls.Add(this.txtNumeroAposta5);
            this.Controls.Add(this.txtNumeroAposta4);
            this.Controls.Add(this.txtNumeroAposta3);
            this.Controls.Add(this.txtNumeroAposta2);
            this.Controls.Add(this.txtNumeroAposta1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.dgvApostas);
            this.Name = "gridApostas";
            this.Text = "Editar Apostas";
            this.Load += new System.EventHandler(this.gridApostas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApostas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApostas;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn excluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.TextBox txtNumeroAposta10;
        private System.Windows.Forms.TextBox txtNumeroAposta9;
        private System.Windows.Forms.TextBox txtNumeroAposta8;
        private System.Windows.Forms.TextBox txtNumeroAposta7;
        private System.Windows.Forms.TextBox txtNumeroAposta6;
        private System.Windows.Forms.TextBox txtNumeroAposta5;
        private System.Windows.Forms.TextBox txtNumeroAposta4;
        private System.Windows.Forms.TextBox txtNumeroAposta3;
        private System.Windows.Forms.TextBox txtNumeroAposta2;
        private System.Windows.Forms.TextBox txtNumeroAposta1;
        private System.Windows.Forms.TextBox txtNome;
    }
}