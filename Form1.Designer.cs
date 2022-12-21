namespace ModernForm
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_SideMenu = new System.Windows.Forms.Panel();
            this.btn_Help = new System.Windows.Forms.Button();
            this.pnl_ToolsSubMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btn_Tools = new System.Windows.Forms.Button();
            this.btn_Equalizer = new System.Windows.Forms.Button();
            this.pnl_PlaylistSubMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btn_Playlist = new System.Windows.Forms.Button();
            this.pnl_MediaSubMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Media = new System.Windows.Forms.Button();
            this.pnl_Logo = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_Player = new System.Windows.Forms.Panel();
            this.pnl_ChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.pnl_SideMenu.SuspendLayout();
            this.pnl_ToolsSubMenu.SuspendLayout();
            this.pnl_PlaylistSubMenu.SuspendLayout();
            this.pnl_MediaSubMenu.SuspendLayout();
            this.pnl_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_ChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_SideMenu
            // 
            this.pnl_SideMenu.AutoScroll = true;
            this.pnl_SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnl_SideMenu.Controls.Add(this.btn_Help);
            this.pnl_SideMenu.Controls.Add(this.pnl_ToolsSubMenu);
            this.pnl_SideMenu.Controls.Add(this.btn_Tools);
            this.pnl_SideMenu.Controls.Add(this.btn_Equalizer);
            this.pnl_SideMenu.Controls.Add(this.pnl_PlaylistSubMenu);
            this.pnl_SideMenu.Controls.Add(this.btn_Playlist);
            this.pnl_SideMenu.Controls.Add(this.pnl_MediaSubMenu);
            this.pnl_SideMenu.Controls.Add(this.btn_Media);
            this.pnl_SideMenu.Controls.Add(this.pnl_Logo);
            this.pnl_SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_SideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnl_SideMenu.Name = "pnl_SideMenu";
            this.pnl_SideMenu.Size = new System.Drawing.Size(260, 589);
            this.pnl_SideMenu.TabIndex = 0;
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btn_Help.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Help.FlatAppearance.BorderSize = 0;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Help.Location = new System.Drawing.Point(0, 784);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Help.Size = new System.Drawing.Size(243, 45);
            this.btn_Help.TabIndex = 8;
            this.btn_Help.Text = "Help";
            this.btn_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // pnl_ToolsSubMenu
            // 
            this.pnl_ToolsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.pnl_ToolsSubMenu.Controls.Add(this.button12);
            this.pnl_ToolsSubMenu.Controls.Add(this.button13);
            this.pnl_ToolsSubMenu.Controls.Add(this.button14);
            this.pnl_ToolsSubMenu.Controls.Add(this.button15);
            this.pnl_ToolsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ToolsSubMenu.Location = new System.Drawing.Point(0, 602);
            this.pnl_ToolsSubMenu.Name = "pnl_ToolsSubMenu";
            this.pnl_ToolsSubMenu.Size = new System.Drawing.Size(243, 182);
            this.pnl_ToolsSubMenu.TabIndex = 7;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.ForeColor = System.Drawing.Color.LightGray;
            this.button12.Location = new System.Drawing.Point(3, 3);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(257, 40);
            this.button12.TabIndex = 2;
            this.button12.Text = "Media";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.ForeColor = System.Drawing.Color.LightGray;
            this.button13.Location = new System.Drawing.Point(3, 49);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(257, 40);
            this.button13.TabIndex = 3;
            this.button13.Text = "Media";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.Dock = System.Windows.Forms.DockStyle.Top;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.ForeColor = System.Drawing.Color.LightGray;
            this.button14.Location = new System.Drawing.Point(3, 95);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button14.Size = new System.Drawing.Size(257, 40);
            this.button14.TabIndex = 4;
            this.button14.Text = "Media";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.Dock = System.Windows.Forms.DockStyle.Top;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.ForeColor = System.Drawing.Color.LightGray;
            this.button15.Location = new System.Drawing.Point(3, 141);
            this.button15.Name = "button15";
            this.button15.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button15.Size = new System.Drawing.Size(257, 40);
            this.button15.TabIndex = 5;
            this.button15.Text = "Media";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // btn_Tools
            // 
            this.btn_Tools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btn_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Tools.FlatAppearance.BorderSize = 0;
            this.btn_Tools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tools.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Tools.Location = new System.Drawing.Point(0, 557);
            this.btn_Tools.Name = "btn_Tools";
            this.btn_Tools.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Tools.Size = new System.Drawing.Size(243, 45);
            this.btn_Tools.TabIndex = 6;
            this.btn_Tools.Text = "Tools";
            this.btn_Tools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tools.UseVisualStyleBackColor = false;
            this.btn_Tools.Click += new System.EventHandler(this.btn_Tools_Click);
            // 
            // btn_Equalizer
            // 
            this.btn_Equalizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btn_Equalizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Equalizer.FlatAppearance.BorderSize = 0;
            this.btn_Equalizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Equalizer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Equalizer.Location = new System.Drawing.Point(0, 512);
            this.btn_Equalizer.Name = "btn_Equalizer";
            this.btn_Equalizer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Equalizer.Size = new System.Drawing.Size(243, 45);
            this.btn_Equalizer.TabIndex = 5;
            this.btn_Equalizer.Text = "Equalizer";
            this.btn_Equalizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Equalizer.UseVisualStyleBackColor = false;
            this.btn_Equalizer.Click += new System.EventHandler(this.btn_Equalizer_Click);
            // 
            // pnl_PlaylistSubMenu
            // 
            this.pnl_PlaylistSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.pnl_PlaylistSubMenu.Controls.Add(this.button6);
            this.pnl_PlaylistSubMenu.Controls.Add(this.button7);
            this.pnl_PlaylistSubMenu.Controls.Add(this.button8);
            this.pnl_PlaylistSubMenu.Controls.Add(this.button9);
            this.pnl_PlaylistSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_PlaylistSubMenu.Location = new System.Drawing.Point(0, 330);
            this.pnl_PlaylistSubMenu.Name = "pnl_PlaylistSubMenu";
            this.pnl_PlaylistSubMenu.Size = new System.Drawing.Size(243, 182);
            this.pnl_PlaylistSubMenu.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.LightGray;
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(257, 40);
            this.button6.TabIndex = 2;
            this.button6.Text = "Media";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.LightGray;
            this.button7.Location = new System.Drawing.Point(3, 49);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(257, 40);
            this.button7.TabIndex = 3;
            this.button7.Text = "Media";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.LightGray;
            this.button8.Location = new System.Drawing.Point(3, 95);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(257, 40);
            this.button8.TabIndex = 4;
            this.button8.Text = "Media";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.Color.LightGray;
            this.button9.Location = new System.Drawing.Point(3, 141);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(257, 41);
            this.button9.TabIndex = 5;
            this.button9.Text = "Media";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_Playlist
            // 
            this.btn_Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btn_Playlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Playlist.FlatAppearance.BorderSize = 0;
            this.btn_Playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Playlist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Playlist.Location = new System.Drawing.Point(0, 285);
            this.btn_Playlist.Name = "btn_Playlist";
            this.btn_Playlist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Playlist.Size = new System.Drawing.Size(243, 45);
            this.btn_Playlist.TabIndex = 3;
            this.btn_Playlist.Text = "Playlist Management";
            this.btn_Playlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Playlist.UseVisualStyleBackColor = false;
            this.btn_Playlist.Click += new System.EventHandler(this.btn_Playlist_Click);
            // 
            // pnl_MediaSubMenu
            // 
            this.pnl_MediaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.pnl_MediaSubMenu.Controls.Add(this.button1);
            this.pnl_MediaSubMenu.Controls.Add(this.button2);
            this.pnl_MediaSubMenu.Controls.Add(this.button3);
            this.pnl_MediaSubMenu.Controls.Add(this.button4);
            this.pnl_MediaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MediaSubMenu.Location = new System.Drawing.Point(0, 103);
            this.pnl_MediaSubMenu.Name = "pnl_MediaSubMenu";
            this.pnl_MediaSubMenu.Size = new System.Drawing.Size(243, 182);
            this.pnl_MediaSubMenu.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(257, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Media";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(3, 49);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(257, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Media";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(3, 95);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(257, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Media";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.LightGray;
            this.button4.Location = new System.Drawing.Point(3, 141);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(257, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "Media";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Media
            // 
            this.btn_Media.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btn_Media.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Media.FlatAppearance.BorderSize = 0;
            this.btn_Media.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Media.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Media.Location = new System.Drawing.Point(0, 58);
            this.btn_Media.Name = "btn_Media";
            this.btn_Media.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Media.Size = new System.Drawing.Size(243, 45);
            this.btn_Media.TabIndex = 1;
            this.btn_Media.Text = "Media";
            this.btn_Media.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Media.UseVisualStyleBackColor = false;
            this.btn_Media.Click += new System.EventHandler(this.btn_Media_Click);
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.pnl_Logo.Controls.Add(this.pictureBox3);
            this.pnl_Logo.Controls.Add(this.pictureBox2);
            this.pnl_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(243, 58);
            this.pnl_Logo.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnl_Player
            // 
            this.pnl_Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnl_Player.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Player.Location = new System.Drawing.Point(260, 463);
            this.pnl_Player.Name = "pnl_Player";
            this.pnl_Player.Size = new System.Drawing.Size(786, 126);
            this.pnl_Player.TabIndex = 1;
            // 
            // pnl_ChildForm
            // 
            this.pnl_ChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnl_ChildForm.Controls.Add(this.pictureBox1);
            this.pnl_ChildForm.Controls.Add(this.panel1);
            this.pnl_ChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ChildForm.Location = new System.Drawing.Point(260, 0);
            this.pnl_ChildForm.Name = "pnl_ChildForm";
            this.pnl_ChildForm.Size = new System.Drawing.Size(786, 463);
            this.pnl_ChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(786, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Maximize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 58);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(751, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(35, 34);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.BackgroundImage")));
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Minimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Minimize.Location = new System.Drawing.Point(681, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(35, 34);
            this.btn_Minimize.TabIndex = 3;
            this.btn_Minimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Maximize.BackgroundImage")));
            this.btn_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Location = new System.Drawing.Point(716, 0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(35, 34);
            this.btn_Maximize.TabIndex = 2;
            this.btn_Maximize.UseVisualStyleBackColor = false;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 589);
            this.Controls.Add(this.pnl_ChildForm);
            this.Controls.Add(this.pnl_Player);
            this.Controls.Add(this.pnl_SideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(976, 589);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_SideMenu.ResumeLayout(false);
            this.pnl_ToolsSubMenu.ResumeLayout(false);
            this.pnl_PlaylistSubMenu.ResumeLayout(false);
            this.pnl_MediaSubMenu.ResumeLayout(false);
            this.pnl_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_ChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_SideMenu;
        private System.Windows.Forms.FlowLayoutPanel pnl_Logo;
        private System.Windows.Forms.Panel pnl_Player;
        private System.Windows.Forms.Panel pnl_ChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.FlowLayoutPanel pnl_ToolsSubMenu;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btn_Tools;
        private System.Windows.Forms.Button btn_Equalizer;
        private System.Windows.Forms.FlowLayoutPanel pnl_PlaylistSubMenu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btn_Playlist;
        private System.Windows.Forms.FlowLayoutPanel pnl_MediaSubMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_Media;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

