namespace _7DtD_HP
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.zombie_icon = new System.Windows.Forms.PictureBox();
            this.zombie_panel = new System.Windows.Forms.Panel();
            this.changeResist = new System.Windows.Forms.CheckBox();
            this.backupBtn = new System.Windows.Forms.Button();
            this.resist_rand_box = new System.Windows.Forms.GroupBox();
            this.randResistBtn = new System.Windows.Forms.Button();
            this.max_resist_value = new System.Windows.Forms.NumericUpDown();
            this.min_resist_value = new System.Windows.Forms.NumericUpDown();
            this.maxResistLbl = new System.Windows.Forms.Label();
            this.minResistLbl = new System.Windows.Forms.Label();
            this.resistRandLbl = new System.Windows.Forms.Label();
            this.hp_rand_box = new System.Windows.Forms.GroupBox();
            this.randHpBtn = new System.Windows.Forms.Button();
            this.max_hp_value = new System.Windows.Forms.NumericUpDown();
            this.min_hp_value = new System.Windows.Forms.NumericUpDown();
            this.maxHpLbl = new System.Windows.Forms.Label();
            this.minHpLbl = new System.Windows.Forms.Label();
            this.hpRandLbl = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.devolp = new System.Windows.Forms.Label();
            this.resist_default = new System.Windows.Forms.Label();
            this.load_btn = new System.Windows.Forms.Button();
            this.hp_default = new System.Windows.Forms.Label();
            this.apply_btn = new System.Windows.Forms.Button();
            this.default_btn = new System.Windows.Forms.Button();
            this.zombie_resist = new System.Windows.Forms.NumericUpDown();
            this.resist_title = new System.Windows.Forms.Label();
            this.zombie_hp = new System.Windows.Forms.NumericUpDown();
            this.hpTitle = new System.Windows.Forms.Label();
            this.zombieListLbl = new System.Windows.Forms.Label();
            this.zombie_list = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.zombie_icon)).BeginInit();
            this.zombie_panel.SuspendLayout();
            this.resist_rand_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_resist_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_resist_value)).BeginInit();
            this.hp_rand_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_hp_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_hp_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie_resist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie_hp)).BeginInit();
            this.SuspendLayout();
            // 
            // zombie_icon
            // 
            this.zombie_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zombie_icon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zombie_icon.Location = new System.Drawing.Point(3, 3);
            this.zombie_icon.Name = "zombie_icon";
            this.zombie_icon.Size = new System.Drawing.Size(200, 273);
            this.zombie_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zombie_icon.TabIndex = 0;
            this.zombie_icon.TabStop = false;
            // 
            // zombie_panel
            // 
            this.zombie_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zombie_panel.Controls.Add(this.changeResist);
            this.zombie_panel.Controls.Add(this.backupBtn);
            this.zombie_panel.Controls.Add(this.resist_rand_box);
            this.zombie_panel.Controls.Add(this.hp_rand_box);
            this.zombie_panel.Controls.Add(this.version);
            this.zombie_panel.Controls.Add(this.devolp);
            this.zombie_panel.Controls.Add(this.resist_default);
            this.zombie_panel.Controls.Add(this.load_btn);
            this.zombie_panel.Controls.Add(this.hp_default);
            this.zombie_panel.Controls.Add(this.apply_btn);
            this.zombie_panel.Controls.Add(this.default_btn);
            this.zombie_panel.Controls.Add(this.zombie_resist);
            this.zombie_panel.Controls.Add(this.resist_title);
            this.zombie_panel.Controls.Add(this.zombie_hp);
            this.zombie_panel.Controls.Add(this.hpTitle);
            this.zombie_panel.Controls.Add(this.zombieListLbl);
            this.zombie_panel.Controls.Add(this.zombie_list);
            this.zombie_panel.Controls.Add(this.zombie_icon);
            this.zombie_panel.Location = new System.Drawing.Point(12, 12);
            this.zombie_panel.Name = "zombie_panel";
            this.zombie_panel.Size = new System.Drawing.Size(666, 299);
            this.zombie_panel.TabIndex = 1;
            // 
            // changeResist
            // 
            this.changeResist.Appearance = System.Windows.Forms.Appearance.Button;
            this.changeResist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeResist.Location = new System.Drawing.Point(213, 89);
            this.changeResist.Name = "changeResist";
            this.changeResist.Size = new System.Drawing.Size(29, 29);
            this.changeResist.TabIndex = 2;
            this.changeResist.TabStop = false;
            this.changeResist.Text = "✖";
            this.changeResist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changeResist.UseVisualStyleBackColor = false;
            this.changeResist.CheckedChanged += new System.EventHandler(this.ChangeResist_CheckedChanged);
            this.changeResist.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Content_HelpRequested);
            // 
            // backupBtn
            // 
            this.backupBtn.AutoSize = true;
            this.backupBtn.ForeColor = System.Drawing.Color.White;
            this.backupBtn.Location = new System.Drawing.Point(212, 242);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(103, 34);
            this.backupBtn.TabIndex = 18;
            this.backupBtn.TabStop = false;
            this.backupBtn.Text = "Backup";
            this.backupBtn.UseVisualStyleBackColor = false;
            this.backupBtn.Click += new System.EventHandler(this.Backup_btn_Click);
            this.backupBtn.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Content_HelpRequested);
            // 
            // resist_rand_box
            // 
            this.resist_rand_box.Controls.Add(this.randResistBtn);
            this.resist_rand_box.Controls.Add(this.max_resist_value);
            this.resist_rand_box.Controls.Add(this.min_resist_value);
            this.resist_rand_box.Controls.Add(this.maxResistLbl);
            this.resist_rand_box.Controls.Add(this.minResistLbl);
            this.resist_rand_box.Controls.Add(this.resistRandLbl);
            this.resist_rand_box.Location = new System.Drawing.Point(431, 134);
            this.resist_rand_box.Name = "resist_rand_box";
            this.resist_rand_box.Size = new System.Drawing.Size(211, 102);
            this.resist_rand_box.TabIndex = 17;
            this.resist_rand_box.TabStop = false;
            // 
            // randResistBtn
            // 
            this.randResistBtn.AutoSize = true;
            this.randResistBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randResistBtn.ForeColor = System.Drawing.Color.White;
            this.randResistBtn.Location = new System.Drawing.Point(106, 62);
            this.randResistBtn.Name = "randResistBtn";
            this.randResistBtn.Size = new System.Drawing.Size(100, 34);
            this.randResistBtn.TabIndex = 20;
            this.randResistBtn.TabStop = false;
            this.randResistBtn.Text = "Randomize";
            this.randResistBtn.UseVisualStyleBackColor = false;
            this.randResistBtn.Click += new System.EventHandler(this.Rand_resist_btn_Click);
            this.randResistBtn.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Content_HelpRequested);
            // 
            // max_resist_value
            // 
            this.max_resist_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(50)))));
            this.max_resist_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.max_resist_value.ForeColor = System.Drawing.Color.White;
            this.max_resist_value.Location = new System.Drawing.Point(155, 34);
            this.max_resist_value.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.max_resist_value.Name = "max_resist_value";
            this.max_resist_value.Size = new System.Drawing.Size(51, 22);
            this.max_resist_value.TabIndex = 19;
            this.max_resist_value.TabStop = false;
            this.max_resist_value.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.max_resist_value.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Content_HelpRequested);
            // 
            // min_resist_value
            // 
            this.min_resist_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(50)))));
            this.min_resist_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.min_resist_value.ForeColor = System.Drawing.Color.White;
            this.min_resist_value.Location = new System.Drawing.Point(50, 34);
            this.min_resist_value.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.min_resist_value.Name = "min_resist_value";
            this.min_resist_value.Size = new System.Drawing.Size(51, 22);
            this.min_resist_value.TabIndex = 18;
            this.min_resist_value.TabStop = false;
            this.min_resist_value.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Content_HelpRequested);
            // 
            // maxResistLbl
            // 
            this.maxResistLbl.AutoSize = true;
            this.maxResistLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxResistLbl.ForeColor = System.Drawing.Color.White;
            this.maxResistLbl.Location = new System.Drawing.Point(107, 33);
            this.maxResistLbl.Name = "maxResistLbl";
            this.maxResistLbl.Size = new System.Drawing.Size(42, 20);
            this.maxResistLbl.TabIndex = 17;
            this.maxResistLbl.Text = "max:";
            this.maxResistLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // minResistLbl
            // 
            this.minResistLbl.AutoSize = true;
            this.minResistLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minResistLbl.ForeColor = System.Drawing.Color.White;
            this.minResistLbl.Location = new System.Drawing.Point(6, 33);
            this.minResistLbl.Name = "minResistLbl";
            this.minResistLbl.Size = new System.Drawing.Size(38, 20);
            this.minResistLbl.TabIndex = 16;
            this.minResistLbl.Text = "min:";
            this.minResistLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resistRandLbl
            // 
            this.resistRandLbl.AutoSize = true;
            this.resistRandLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resistRandLbl.ForeColor = System.Drawing.Color.White;
            this.resistRandLbl.Location = new System.Drawing.Point(6, 0);
            this.resistRandLbl.Name = "resistRandLbl";
            this.resistRandLbl.Size = new System.Drawing.Size(145, 20);
            this.resistRandLbl.TabIndex = 15;
            this.resistRandLbl.Text = "Random PDResist:";
            this.resistRandLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hp_rand_box
            // 
            this.hp_rand_box.Controls.Add(this.randHpBtn);
            this.hp_rand_box.Controls.Add(this.max_hp_value);
            this.hp_rand_box.Controls.Add(this.min_hp_value);
            this.hp_rand_box.Controls.Add(this.maxHpLbl);
            this.hp_rand_box.Controls.Add(this.minHpLbl);
            this.hp_rand_box.Controls.Add(this.hpRandLbl);
            this.hp_rand_box.Location = new System.Drawing.Point(212, 134);
            this.hp_rand_box.Name = "hp_rand_box";
            this.hp_rand_box.Size = new System.Drawing.Size(212, 102);
            this.hp_rand_box.TabIndex = 16;
            this.hp_rand_box.TabStop = false;
            // 
            // randHpBtn
            // 
            this.randHpBtn.AutoSize = true;
            this.randHpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randHpBtn.ForeColor = System.Drawing.Color.White;
            this.randHpBtn.Location = new System.Drawing.Point(106, 62);
            this.randHpBtn.Name = "randHpBtn";
            this.randHpBtn.Size = new System.Drawing.Size(100, 34);
            this.randHpBtn.TabIndex = 20;
            this.randHpBtn.TabStop = false;
            this.randHpBtn.Text = "Randomize";
            this.randHpBtn.UseVisualStyleBackColor = false;
            this.randHpBtn.Click += new System.EventHandler(this.Rand_hp_btn_Click);
            this.randHpBtn.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Content_HelpRequested);
            // 
            // max_hp_value
            // 
            this.max_hp_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(50)))));
            this.max_hp_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.max_hp_value.ForeColor = System.Drawing.Color.White;
            this.max_hp_value.Location = new System.Drawing.Point(155, 34);
            this.max_hp_value.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.max_hp_value.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.max_hp_value.Name = "max_hp_value";
            this.max_hp_value.Size = new System.Drawing.Size(51, 22);
            this.max_hp_value.TabIndex = 19;
            this.max_hp_value.TabStop = false;
            this.max_hp_value.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.max_hp_value.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Content_HelpRequested);
            // 
            // min_hp_value
            // 
            this.min_hp_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(50)))));
            this.min_hp_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.min_hp_value.ForeColor = System.Drawing.Color.White;
            this.min_hp_value.Location = new System.Drawing.Point(50, 34);
            this.min_hp_value.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.min_hp_value.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.min_hp_value.Name = "min_hp_value";
            this.min_hp_value.Size = new System.Drawing.Size(51, 22);
            this.min_hp_value.TabIndex = 18;
            this.min_hp_value.TabStop = false;
            this.min_hp_value.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.min_hp_value.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Content_HelpRequested);
            // 
            // maxHpLbl
            // 
            this.maxHpLbl.AutoSize = true;
            this.maxHpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxHpLbl.ForeColor = System.Drawing.Color.White;
            this.maxHpLbl.Location = new System.Drawing.Point(107, 33);
            this.maxHpLbl.Name = "maxHpLbl";
            this.maxHpLbl.Size = new System.Drawing.Size(42, 20);
            this.maxHpLbl.TabIndex = 17;
            this.maxHpLbl.Text = "max:";
            this.maxHpLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // minHpLbl
            // 
            this.minHpLbl.AutoSize = true;
            this.minHpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minHpLbl.ForeColor = System.Drawing.Color.White;
            this.minHpLbl.Location = new System.Drawing.Point(6, 33);
            this.minHpLbl.Name = "minHpLbl";
            this.minHpLbl.Size = new System.Drawing.Size(38, 20);
            this.minHpLbl.TabIndex = 16;
            this.minHpLbl.Text = "min:";
            this.minHpLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hpRandLbl
            // 
            this.hpRandLbl.AutoSize = true;
            this.hpRandLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hpRandLbl.ForeColor = System.Drawing.Color.White;
            this.hpRandLbl.Location = new System.Drawing.Point(6, 0);
            this.hpRandLbl.Name = "hpRandLbl";
            this.hpRandLbl.Size = new System.Drawing.Size(154, 20);
            this.hpRandLbl.TabIndex = 15;
            this.hpRandLbl.Text = "Random HealthMax:";
            this.hpRandLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Cursor = System.Windows.Forms.Cursors.Default;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.version.ForeColor = System.Drawing.Color.White;
            this.version.Location = new System.Drawing.Point(624, 279);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(41, 16);
            this.version.TabIndex = 14;
            this.version.Text = "v0.2.1";
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // devolp
            // 
            this.devolp.AutoSize = true;
            this.devolp.Cursor = System.Windows.Forms.Cursors.Help;
            this.devolp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devolp.ForeColor = System.Drawing.Color.White;
            this.devolp.Location = new System.Drawing.Point(-1, 277);
            this.devolp.Name = "devolp";
            this.devolp.Size = new System.Drawing.Size(126, 20);
            this.devolp.TabIndex = 13;
            this.devolp.Text = "By. Lonewolf239";
            this.devolp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.devolp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Devolp_MouseClick);
            // 
            // resist_default
            // 
            this.resist_default.AutoSize = true;
            this.resist_default.ForeColor = System.Drawing.Color.White;
            this.resist_default.Location = new System.Drawing.Point(528, 91);
            this.resist_default.Name = "resist_default";
            this.resist_default.Size = new System.Drawing.Size(72, 24);
            this.resist_default.TabIndex = 8;
            this.resist_default.Text = "Default:";
            this.resist_default.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // load_btn
            // 
            this.load_btn.AutoSize = true;
            this.load_btn.ForeColor = System.Drawing.Color.White;
            this.load_btn.Location = new System.Drawing.Point(321, 242);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(103, 34);
            this.load_btn.TabIndex = 12;
            this.load_btn.TabStop = false;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = false;
            this.load_btn.Click += new System.EventHandler(this.Load_btn_Click);
            this.load_btn.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Content_HelpRequested);
            // 
            // hp_default
            // 
            this.hp_default.AutoSize = true;
            this.hp_default.ForeColor = System.Drawing.Color.White;
            this.hp_default.Location = new System.Drawing.Point(528, 56);
            this.hp_default.Name = "hp_default";
            this.hp_default.Size = new System.Drawing.Size(72, 24);
            this.hp_default.TabIndex = 7;
            this.hp_default.Text = "Default:";
            this.hp_default.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // apply_btn
            // 
            this.apply_btn.AutoSize = true;
            this.apply_btn.ForeColor = System.Drawing.Color.White;
            this.apply_btn.Location = new System.Drawing.Point(539, 242);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(103, 34);
            this.apply_btn.TabIndex = 11;
            this.apply_btn.TabStop = false;
            this.apply_btn.Text = "Apply";
            this.apply_btn.UseVisualStyleBackColor = false;
            this.apply_btn.Click += new System.EventHandler(this.Apply_btn_Click);
            this.apply_btn.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Content_HelpRequested);
            // 
            // default_btn
            // 
            this.default_btn.AutoSize = true;
            this.default_btn.ForeColor = System.Drawing.Color.White;
            this.default_btn.Location = new System.Drawing.Point(430, 242);
            this.default_btn.Name = "default_btn";
            this.default_btn.Size = new System.Drawing.Size(103, 34);
            this.default_btn.TabIndex = 9;
            this.default_btn.TabStop = false;
            this.default_btn.Text = "To default";
            this.default_btn.UseVisualStyleBackColor = false;
            this.default_btn.Click += new System.EventHandler(this.Default_btn_Click);
            this.default_btn.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Content_HelpRequested);
            // 
            // zombie_resist
            // 
            this.zombie_resist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(50)))));
            this.zombie_resist.ForeColor = System.Drawing.Color.White;
            this.zombie_resist.Location = new System.Drawing.Point(430, 89);
            this.zombie_resist.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.zombie_resist.Name = "zombie_resist";
            this.zombie_resist.Size = new System.Drawing.Size(92, 29);
            this.zombie_resist.TabIndex = 6;
            this.zombie_resist.TabStop = false;
            this.zombie_resist.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.zombie_resist.ValueChanged += new System.EventHandler(this.Zombie_resist_ValueChanged);
            this.zombie_resist.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Content_HelpRequested);
            // 
            // resist_title
            // 
            this.resist_title.AutoSize = true;
            this.resist_title.ForeColor = System.Drawing.Color.White;
            this.resist_title.Location = new System.Drawing.Point(248, 91);
            this.resist_title.Name = "resist_title";
            this.resist_title.Size = new System.Drawing.Size(90, 24);
            this.resist_title.TabIndex = 5;
            this.resist_title.Text = "PDResist:";
            this.resist_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // zombie_hp
            // 
            this.zombie_hp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(50)))));
            this.zombie_hp.ForeColor = System.Drawing.Color.White;
            this.zombie_hp.Location = new System.Drawing.Point(430, 54);
            this.zombie_hp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.zombie_hp.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.zombie_hp.Name = "zombie_hp";
            this.zombie_hp.Size = new System.Drawing.Size(92, 29);
            this.zombie_hp.TabIndex = 4;
            this.zombie_hp.TabStop = false;
            this.zombie_hp.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.zombie_hp.ValueChanged += new System.EventHandler(this.Zombie_hp_ValueChanged);
            this.zombie_hp.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Content_HelpRequested);
            // 
            // hpTitle
            // 
            this.hpTitle.AutoSize = true;
            this.hpTitle.ForeColor = System.Drawing.Color.White;
            this.hpTitle.Location = new System.Drawing.Point(209, 56);
            this.hpTitle.Name = "hpTitle";
            this.hpTitle.Size = new System.Drawing.Size(105, 24);
            this.hpTitle.TabIndex = 3;
            this.hpTitle.Text = "HealthMax:";
            this.hpTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // zombieListLbl
            // 
            this.zombieListLbl.AutoSize = true;
            this.zombieListLbl.ForeColor = System.Drawing.Color.White;
            this.zombieListLbl.Location = new System.Drawing.Point(209, 6);
            this.zombieListLbl.Name = "zombieListLbl";
            this.zombieListLbl.Size = new System.Drawing.Size(80, 24);
            this.zombieListLbl.TabIndex = 2;
            this.zombieListLbl.Text = "Zombie:";
            this.zombieListLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // zombie_list
            // 
            this.zombie_list.BackColor = System.Drawing.Color.White;
            this.zombie_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zombie_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zombie_list.FormattingEnabled = true;
            this.zombie_list.Location = new System.Drawing.Point(295, 3);
            this.zombie_list.Name = "zombie_list";
            this.zombie_list.Size = new System.Drawing.Size(347, 32);
            this.zombie_list.TabIndex = 1;
            this.zombie_list.TabStop = false;
            this.zombie_list.SelectedIndexChanged += new System.EventHandler(this.Zombie_list_SelectedIndexChanged);
            this.zombie_list.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Content_HelpRequested);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(690, 323);
            this.Controls.Add(this.zombie_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7DtD Zombie HP Changer";
            ((System.ComponentModel.ISupportInitialize)(this.zombie_icon)).EndInit();
            this.zombie_panel.ResumeLayout(false);
            this.zombie_panel.PerformLayout();
            this.resist_rand_box.ResumeLayout(false);
            this.resist_rand_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_resist_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_resist_value)).EndInit();
            this.hp_rand_box.ResumeLayout(false);
            this.hp_rand_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_hp_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_hp_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie_resist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie_hp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox zombie_icon;
        private System.Windows.Forms.Panel zombie_panel;
        private System.Windows.Forms.Label zombieListLbl;
        private System.Windows.Forms.ComboBox zombie_list;
        private System.Windows.Forms.NumericUpDown zombie_hp;
        private System.Windows.Forms.Label hpTitle;
        private System.Windows.Forms.NumericUpDown zombie_resist;
        private System.Windows.Forms.Label resist_title;
        private System.Windows.Forms.Label hp_default;
        private System.Windows.Forms.Label resist_default;
        private System.Windows.Forms.Button default_btn;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Label devolp;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.GroupBox hp_rand_box;
        private System.Windows.Forms.Label minHpLbl;
        private System.Windows.Forms.Label hpRandLbl;
        private System.Windows.Forms.Button randHpBtn;
        private System.Windows.Forms.NumericUpDown max_hp_value;
        private System.Windows.Forms.NumericUpDown min_hp_value;
        private System.Windows.Forms.Label maxHpLbl;
        private System.Windows.Forms.GroupBox resist_rand_box;
        private System.Windows.Forms.Button randResistBtn;
        private System.Windows.Forms.NumericUpDown max_resist_value;
        private System.Windows.Forms.NumericUpDown min_resist_value;
        private System.Windows.Forms.Label maxResistLbl;
        private System.Windows.Forms.Label minResistLbl;
        private System.Windows.Forms.Label resistRandLbl;
        private System.Windows.Forms.Button backupBtn;
        private System.Windows.Forms.CheckBox changeResist;
    }
}

