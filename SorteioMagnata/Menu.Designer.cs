
namespace SorteioMagnata
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuTopo = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.apostadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuApostas = new System.Windows.Forms.ToolStripMenuItem();
            this.novaApostaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSorteios = new System.Windows.Forms.ToolStripMenuItem();
            this.novoSorteioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lbl_Apostadores = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Sorteios = new System.Windows.Forms.Label();
            this.lbl_Apostas = new System.Windows.Forms.Label();
            this.lbl_Cambistas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSorteios = new System.Windows.Forms.Button();
            this.btnApostas = new System.Windows.Forms.Button();
            this.btnCambistas = new System.Windows.Forms.Button();
            this.btnApostadores = new System.Windows.Forms.Button();
            this.pnlMenuGrid = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuTopo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlMenuGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTopo
            // 
            this.menuTopo.BackColor = System.Drawing.Color.Transparent;
            this.menuTopo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTopo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuApostas,
            this.MenuSorteios,
            this.MenuRelatorios,
            this.sairToolStripMenuItem});
            this.menuTopo.Location = new System.Drawing.Point(0, 0);
            this.menuTopo.Name = "menuTopo";
            this.menuTopo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuTopo.Size = new System.Drawing.Size(1199, 29);
            this.menuTopo.TabIndex = 0;
            this.menuTopo.Text = "menuTopo";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apostadoresToolStripMenuItem,
            this.cambistasToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.cargoToolStripMenuItem});
            this.MenuCadastro.Image = ((System.Drawing.Image)(resources.GetObject("MenuCadastro.Image")));
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(107, 25);
            this.MenuCadastro.Text = "Cadastros";
            // 
            // apostadoresToolStripMenuItem
            // 
            this.apostadoresToolStripMenuItem.Name = "apostadoresToolStripMenuItem";
            this.apostadoresToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.apostadoresToolStripMenuItem.Text = "Apostadores";
            this.apostadoresToolStripMenuItem.Click += new System.EventHandler(this.apostadoresToolStripMenuItem_Click);
            // 
            // cambistasToolStripMenuItem
            // 
            this.cambistasToolStripMenuItem.Name = "cambistasToolStripMenuItem";
            this.cambistasToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.cambistasToolStripMenuItem.Text = "Cambistas";
            this.cambistasToolStripMenuItem.Click += new System.EventHandler(this.cambistasToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // cargoToolStripMenuItem
            // 
            this.cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
            this.cargoToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.cargoToolStripMenuItem.Text = "Cargo";
            this.cargoToolStripMenuItem.Click += new System.EventHandler(this.cargoToolStripMenuItem_Click);
            // 
            // MenuApostas
            // 
            this.MenuApostas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaApostaToolStripMenuItem});
            this.MenuApostas.Image = ((System.Drawing.Image)(resources.GetObject("MenuApostas.Image")));
            this.MenuApostas.Name = "MenuApostas";
            this.MenuApostas.Size = new System.Drawing.Size(93, 25);
            this.MenuApostas.Text = "Apostas";
            // 
            // novaApostaToolStripMenuItem
            // 
            this.novaApostaToolStripMenuItem.Name = "novaApostaToolStripMenuItem";
            this.novaApostaToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.novaApostaToolStripMenuItem.Text = "Nova Aposta";
            this.novaApostaToolStripMenuItem.Click += new System.EventHandler(this.novaApostaToolStripMenuItem_Click);
            // 
            // MenuSorteios
            // 
            this.MenuSorteios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoSorteioToolStripMenuItem});
            this.MenuSorteios.Image = ((System.Drawing.Image)(resources.GetObject("MenuSorteios.Image")));
            this.MenuSorteios.Name = "MenuSorteios";
            this.MenuSorteios.Size = new System.Drawing.Size(95, 25);
            this.MenuSorteios.Text = "Sorteios";
            // 
            // novoSorteioToolStripMenuItem
            // 
            this.novoSorteioToolStripMenuItem.Name = "novoSorteioToolStripMenuItem";
            this.novoSorteioToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.novoSorteioToolStripMenuItem.Text = "Novo Sorteio";
            this.novoSorteioToolStripMenuItem.Click += new System.EventHandler(this.novoSorteioToolStripMenuItem_Click);
            // 
            // MenuRelatorios
            // 
            this.MenuRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("MenuRelatorios.Image")));
            this.MenuRelatorios.Name = "MenuRelatorios";
            this.MenuRelatorios.Size = new System.Drawing.Size(108, 25);
            this.MenuRelatorios.Text = "Relatórios";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Controls.Add(this.lbl_Apostadores);
            this.pnlMenu.Controls.Add(this.lbl_Total);
            this.pnlMenu.Controls.Add(this.lbl_Sorteios);
            this.pnlMenu.Controls.Add(this.lbl_Apostas);
            this.pnlMenu.Controls.Add(this.lbl_Cambistas);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.btnSorteios);
            this.pnlMenu.Controls.Add(this.btnApostas);
            this.pnlMenu.Controls.Add(this.btnCambistas);
            this.pnlMenu.Controls.Add(this.btnApostadores);
            this.pnlMenu.Location = new System.Drawing.Point(165, 105);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(912, 249);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // lbl_Apostadores
            // 
            this.lbl_Apostadores.AutoSize = true;
            this.lbl_Apostadores.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Apostadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Apostadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apostadores.ForeColor = System.Drawing.Color.White;
            this.lbl_Apostadores.Location = new System.Drawing.Point(76, 185);
            this.lbl_Apostadores.Name = "lbl_Apostadores";
            this.lbl_Apostadores.Size = new System.Drawing.Size(25, 25);
            this.lbl_Apostadores.TabIndex = 10;
            this.lbl_Apostadores.Text = "0";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.Color.White;
            this.lbl_Total.Location = new System.Drawing.Point(820, 185);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(25, 25);
            this.lbl_Total.TabIndex = 9;
            this.lbl_Total.Text = "0";
            // 
            // lbl_Sorteios
            // 
            this.lbl_Sorteios.AutoSize = true;
            this.lbl_Sorteios.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Sorteios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Sorteios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sorteios.ForeColor = System.Drawing.Color.White;
            this.lbl_Sorteios.Location = new System.Drawing.Point(636, 185);
            this.lbl_Sorteios.Name = "lbl_Sorteios";
            this.lbl_Sorteios.Size = new System.Drawing.Size(25, 25);
            this.lbl_Sorteios.TabIndex = 8;
            this.lbl_Sorteios.Text = "0";
            // 
            // lbl_Apostas
            // 
            this.lbl_Apostas.AutoSize = true;
            this.lbl_Apostas.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Apostas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Apostas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apostas.ForeColor = System.Drawing.Color.White;
            this.lbl_Apostas.Location = new System.Drawing.Point(453, 185);
            this.lbl_Apostas.Name = "lbl_Apostas";
            this.lbl_Apostas.Size = new System.Drawing.Size(25, 25);
            this.lbl_Apostas.TabIndex = 7;
            this.lbl_Apostas.Text = "0";
            // 
            // lbl_Cambistas
            // 
            this.lbl_Cambistas.AutoSize = true;
            this.lbl_Cambistas.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Cambistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Cambistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cambistas.ForeColor = System.Drawing.Color.White;
            this.lbl_Cambistas.Location = new System.Drawing.Point(266, 185);
            this.lbl_Cambistas.Name = "lbl_Cambistas";
            this.lbl_Cambistas.Size = new System.Drawing.Size(25, 25);
            this.lbl_Cambistas.TabIndex = 6;
            this.lbl_Cambistas.Text = "0";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(740, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 217);
            this.button1.TabIndex = 4;
            this.button1.Text = "TOTAL";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSorteios
            // 
            this.btnSorteios.FlatAppearance.BorderSize = 0;
            this.btnSorteios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorteios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorteios.ForeColor = System.Drawing.Color.White;
            this.btnSorteios.Image = ((System.Drawing.Image)(resources.GetObject("btnSorteios.Image")));
            this.btnSorteios.Location = new System.Drawing.Point(555, 16);
            this.btnSorteios.Name = "btnSorteios";
            this.btnSorteios.Size = new System.Drawing.Size(169, 217);
            this.btnSorteios.TabIndex = 3;
            this.btnSorteios.Text = "SORTEIOS";
            this.btnSorteios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSorteios.UseVisualStyleBackColor = true;
            this.btnSorteios.Click += new System.EventHandler(this.btnSorteios_Click);
            // 
            // btnApostas
            // 
            this.btnApostas.FlatAppearance.BorderSize = 0;
            this.btnApostas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApostas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApostas.ForeColor = System.Drawing.Color.White;
            this.btnApostas.Image = ((System.Drawing.Image)(resources.GetObject("btnApostas.Image")));
            this.btnApostas.Location = new System.Drawing.Point(370, 16);
            this.btnApostas.Name = "btnApostas";
            this.btnApostas.Size = new System.Drawing.Size(169, 217);
            this.btnApostas.TabIndex = 2;
            this.btnApostas.Text = "APOSTAS";
            this.btnApostas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnApostas.UseVisualStyleBackColor = true;
            this.btnApostas.Click += new System.EventHandler(this.btnApostas_Click);
            // 
            // btnCambistas
            // 
            this.btnCambistas.FlatAppearance.BorderSize = 0;
            this.btnCambistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambistas.ForeColor = System.Drawing.Color.White;
            this.btnCambistas.Image = ((System.Drawing.Image)(resources.GetObject("btnCambistas.Image")));
            this.btnCambistas.Location = new System.Drawing.Point(185, 16);
            this.btnCambistas.Name = "btnCambistas";
            this.btnCambistas.Size = new System.Drawing.Size(169, 217);
            this.btnCambistas.TabIndex = 1;
            this.btnCambistas.Text = "CAMBISTAS";
            this.btnCambistas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCambistas.UseVisualStyleBackColor = true;
            this.btnCambistas.Click += new System.EventHandler(this.btnCambistas_Click);
            // 
            // btnApostadores
            // 
            this.btnApostadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApostadores.FlatAppearance.BorderSize = 0;
            this.btnApostadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnApostadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApostadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApostadores.ForeColor = System.Drawing.Color.White;
            this.btnApostadores.Image = ((System.Drawing.Image)(resources.GetObject("btnApostadores.Image")));
            this.btnApostadores.Location = new System.Drawing.Point(2, 16);
            this.btnApostadores.Name = "btnApostadores";
            this.btnApostadores.Size = new System.Drawing.Size(167, 217);
            this.btnApostadores.TabIndex = 0;
            this.btnApostadores.Text = "APOSTADORES";
            this.btnApostadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnApostadores.UseVisualStyleBackColor = true;
            this.btnApostadores.Click += new System.EventHandler(this.btnApostadores_Click);
            // 
            // pnlMenuGrid
            // 
            this.pnlMenuGrid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMenuGrid.Controls.Add(this.panel1);
            this.pnlMenuGrid.Controls.Add(this.label13);
            this.pnlMenuGrid.Controls.Add(this.txtBuscar);
            this.pnlMenuGrid.Controls.Add(this.label7);
            this.pnlMenuGrid.Controls.Add(this.label6);
            this.pnlMenuGrid.Controls.Add(this.pictureBox1);
            this.pnlMenuGrid.Controls.Add(this.label9);
            this.pnlMenuGrid.Controls.Add(this.label8);
            this.pnlMenuGrid.Controls.Add(this.label10);
            this.pnlMenuGrid.Location = new System.Drawing.Point(165, 361);
            this.pnlMenuGrid.Name = "pnlMenuGrid";
            this.pnlMenuGrid.Size = new System.Drawing.Size(911, 688);
            this.pnlMenuGrid.TabIndex = 2;
            this.pnlMenuGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenuGrid_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 622);
            this.panel1.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(462, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(538, 24);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(150, 26);
            this.txtBuscar.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(755, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(755, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hora:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(702, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 53);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(789, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "14/04/2021";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(788, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "18:41:00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(903, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "_________________________________________________________________________________" +
    "_______________________________________________";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(66, 59);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(0, 20);
            this.lblCargo.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Cargo:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(66, 35);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 20);
            this.lblUsuario.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Nome:";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1199, 1061);
            this.Controls.Add(this.pnlMenuGrid);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.menuTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuTopo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.Text = "Sorteio Magnata";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.Resize += new System.EventHandler(this.FrmMenu_Resize);
            this.menuTopo.ResumeLayout(false);
            this.menuTopo.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlMenuGrid.ResumeLayout(false);
            this.pnlMenuGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTopo;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem apostadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuApostas;
        private System.Windows.Forms.ToolStripMenuItem novaApostaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSorteios;
        private System.Windows.Forms.ToolStripMenuItem novoSorteioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lbl_Apostadores;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Sorteios;
        private System.Windows.Forms.Label lbl_Apostas;
        private System.Windows.Forms.Label lbl_Cambistas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSorteios;
        private System.Windows.Forms.Button btnApostas;
        private System.Windows.Forms.Button btnCambistas;
        private System.Windows.Forms.Button btnApostadores;
        private System.Windows.Forms.Panel pnlMenuGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel1;
    }
}