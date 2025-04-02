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
            this.resist_rand_box = new System.Windows.Forms.GroupBox();
            this.rand_resist_btn = new System.Windows.Forms.Button();
            this.max_resist_value = new System.Windows.Forms.NumericUpDown();
            this.min_resist_value = new System.Windows.Forms.NumericUpDown();
            this.max_resist_title = new System.Windows.Forms.Label();
            this.min_resist_title = new System.Windows.Forms.Label();
            this.resist_rand_title = new System.Windows.Forms.Label();
            this.hp_rand_box = new System.Windows.Forms.GroupBox();
            this.rand_hp_btn = new System.Windows.Forms.Button();
            this.max_hp_value = new System.Windows.Forms.NumericUpDown();
            this.min_hp_value = new System.Windows.Forms.NumericUpDown();
            this.max_hp_title = new System.Windows.Forms.Label();
            this.min_hp_title = new System.Windows.Forms.Label();
            this.hp_rand_title = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.devolp = new System.Windows.Forms.Label();
            this.resist_default = new System.Windows.Forms.Label();
            this.load_btn = new System.Windows.Forms.Button();
            this.hp_default = new System.Windows.Forms.Label();
            this.apply_btn = new System.Windows.Forms.Button();
            this.default_btn = new System.Windows.Forms.Button();
            this.zombie_resist = new System.Windows.Forms.NumericUpDown();
            this.save_btn = new System.Windows.Forms.Button();
            this.resist_title = new System.Windows.Forms.Label();
            this.zombie_hp = new System.Windows.Forms.NumericUpDown();
            this.hp_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zombie_list = new System.Windows.Forms.ComboBox();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
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
            this.zombie_icon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zombie_icon.Location = new System.Drawing.Point(3, 3);
            this.zombie_icon.Name = "zombie_icon";
            this.zombie_icon.Size = new System.Drawing.Size(200, 200);
            this.zombie_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zombie_icon.TabIndex = 0;
            this.zombie_icon.TabStop = false;
            // 
            // zombie_panel
            // 
            this.zombie_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.zombie_panel.Controls.Add(this.save_btn);
            this.zombie_panel.Controls.Add(this.resist_title);
            this.zombie_panel.Controls.Add(this.zombie_hp);
            this.zombie_panel.Controls.Add(this.hp_title);
            this.zombie_panel.Controls.Add(this.label1);
            this.zombie_panel.Controls.Add(this.zombie_list);
            this.zombie_panel.Controls.Add(this.zombie_icon);
            this.zombie_panel.Location = new System.Drawing.Point(12, 12);
            this.zombie_panel.Name = "zombie_panel";
            this.zombie_panel.Size = new System.Drawing.Size(666, 299);
            this.zombie_panel.TabIndex = 1;
            // 
            // resist_rand_box
            // 
            this.resist_rand_box.Controls.Add(this.rand_resist_btn);
            this.resist_rand_box.Controls.Add(this.max_resist_value);
            this.resist_rand_box.Controls.Add(this.min_resist_value);
            this.resist_rand_box.Controls.Add(this.max_resist_title);
            this.resist_rand_box.Controls.Add(this.min_resist_title);
            this.resist_rand_box.Controls.Add(this.resist_rand_title);
            this.resist_rand_box.Location = new System.Drawing.Point(431, 134);
            this.resist_rand_box.Name = "resist_rand_box";
            this.resist_rand_box.Size = new System.Drawing.Size(211, 102);
            this.resist_rand_box.TabIndex = 17;
            this.resist_rand_box.TabStop = false;
            // 
            // rand_resist_btn
            // 
            this.rand_resist_btn.AutoSize = true;
            this.rand_resist_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rand_resist_btn.ForeColor = System.Drawing.Color.White;
            this.rand_resist_btn.Location = new System.Drawing.Point(106, 62);
            this.rand_resist_btn.Name = "rand_resist_btn";
            this.rand_resist_btn.Size = new System.Drawing.Size(100, 34);
            this.rand_resist_btn.TabIndex = 20;
            this.rand_resist_btn.Text = "Randomize";
            this.rand_resist_btn.UseVisualStyleBackColor = false;
            this.rand_resist_btn.Click += new System.EventHandler(this.Rand_resist_btn_Click);
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
            this.max_resist_value.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
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
            // 
            // max_resist_title
            // 
            this.max_resist_title.AutoSize = true;
            this.max_resist_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.max_resist_title.ForeColor = System.Drawing.Color.White;
            this.max_resist_title.Location = new System.Drawing.Point(107, 33);
            this.max_resist_title.Name = "max_resist_title";
            this.max_resist_title.Size = new System.Drawing.Size(42, 20);
            this.max_resist_title.TabIndex = 17;
            this.max_resist_title.Text = "max:";
            this.max_resist_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // min_resist_title
            // 
            this.min_resist_title.AutoSize = true;
            this.min_resist_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.min_resist_title.ForeColor = System.Drawing.Color.White;
            this.min_resist_title.Location = new System.Drawing.Point(6, 33);
            this.min_resist_title.Name = "min_resist_title";
            this.min_resist_title.Size = new System.Drawing.Size(38, 20);
            this.min_resist_title.TabIndex = 16;
            this.min_resist_title.Text = "min:";
            this.min_resist_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resist_rand_title
            // 
            this.resist_rand_title.AutoSize = true;
            this.resist_rand_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resist_rand_title.ForeColor = System.Drawing.Color.White;
            this.resist_rand_title.Location = new System.Drawing.Point(6, 0);
            this.resist_rand_title.Name = "resist_rand_title";
            this.resist_rand_title.Size = new System.Drawing.Size(145, 20);
            this.resist_rand_title.TabIndex = 15;
            this.resist_rand_title.Text = "Random PDResist:";
            this.resist_rand_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hp_rand_box
            // 
            this.hp_rand_box.Controls.Add(this.rand_hp_btn);
            this.hp_rand_box.Controls.Add(this.max_hp_value);
            this.hp_rand_box.Controls.Add(this.min_hp_value);
            this.hp_rand_box.Controls.Add(this.max_hp_title);
            this.hp_rand_box.Controls.Add(this.min_hp_title);
            this.hp_rand_box.Controls.Add(this.hp_rand_title);
            this.hp_rand_box.Location = new System.Drawing.Point(212, 134);
            this.hp_rand_box.Name = "hp_rand_box";
            this.hp_rand_box.Size = new System.Drawing.Size(212, 102);
            this.hp_rand_box.TabIndex = 16;
            this.hp_rand_box.TabStop = false;
            // 
            // rand_hp_btn
            // 
            this.rand_hp_btn.AutoSize = true;
            this.rand_hp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rand_hp_btn.ForeColor = System.Drawing.Color.White;
            this.rand_hp_btn.Location = new System.Drawing.Point(106, 62);
            this.rand_hp_btn.Name = "rand_hp_btn";
            this.rand_hp_btn.Size = new System.Drawing.Size(100, 34);
            this.rand_hp_btn.TabIndex = 20;
            this.rand_hp_btn.Text = "Randomize";
            this.rand_hp_btn.UseVisualStyleBackColor = false;
            this.rand_hp_btn.Click += new System.EventHandler(this.Rand_hp_btn_Click);
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
            this.max_hp_value.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
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
            this.min_hp_value.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // max_hp_title
            // 
            this.max_hp_title.AutoSize = true;
            this.max_hp_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.max_hp_title.ForeColor = System.Drawing.Color.White;
            this.max_hp_title.Location = new System.Drawing.Point(107, 33);
            this.max_hp_title.Name = "max_hp_title";
            this.max_hp_title.Size = new System.Drawing.Size(42, 20);
            this.max_hp_title.TabIndex = 17;
            this.max_hp_title.Text = "max:";
            this.max_hp_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // min_hp_title
            // 
            this.min_hp_title.AutoSize = true;
            this.min_hp_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.min_hp_title.ForeColor = System.Drawing.Color.White;
            this.min_hp_title.Location = new System.Drawing.Point(6, 33);
            this.min_hp_title.Name = "min_hp_title";
            this.min_hp_title.Size = new System.Drawing.Size(38, 20);
            this.min_hp_title.TabIndex = 16;
            this.min_hp_title.Text = "min:";
            this.min_hp_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hp_rand_title
            // 
            this.hp_rand_title.AutoSize = true;
            this.hp_rand_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hp_rand_title.ForeColor = System.Drawing.Color.White;
            this.hp_rand_title.Location = new System.Drawing.Point(6, 0);
            this.hp_rand_title.Name = "hp_rand_title";
            this.hp_rand_title.Size = new System.Drawing.Size(154, 20);
            this.hp_rand_title.TabIndex = 15;
            this.hp_rand_title.Text = "Random HealthMax:";
            this.hp_rand_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Cursor = System.Windows.Forms.Cursors.Help;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.version.ForeColor = System.Drawing.Color.White;
            this.version.Location = new System.Drawing.Point(630, 279);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(31, 16);
            this.version.TabIndex = 14;
            this.version.Text = "v0.1";
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // devolp
            // 
            this.devolp.AutoSize = true;
            this.devolp.Cursor = System.Windows.Forms.Cursors.Help;
            this.devolp.ForeColor = System.Drawing.Color.White;
            this.devolp.Location = new System.Drawing.Point(3, 273);
            this.devolp.Name = "devolp";
            this.devolp.Size = new System.Drawing.Size(147, 24);
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
            this.load_btn.Location = new System.Drawing.Point(212, 242);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(103, 34);
            this.load_btn.TabIndex = 12;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = false;
            this.load_btn.Click += new System.EventHandler(this.Load_btn_Click);
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
            this.apply_btn.Text = "Apply";
            this.apply_btn.UseVisualStyleBackColor = false;
            this.apply_btn.Click += new System.EventHandler(this.Apply_btn_Click);
            // 
            // default_btn
            // 
            this.default_btn.AutoSize = true;
            this.default_btn.ForeColor = System.Drawing.Color.White;
            this.default_btn.Location = new System.Drawing.Point(321, 242);
            this.default_btn.Name = "default_btn";
            this.default_btn.Size = new System.Drawing.Size(103, 34);
            this.default_btn.TabIndex = 9;
            this.default_btn.Text = "To default";
            this.default_btn.UseVisualStyleBackColor = false;
            this.default_btn.Click += new System.EventHandler(this.Default_btn_Click);
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
            this.zombie_resist.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.zombie_resist.ValueChanged += new System.EventHandler(this.Zombie_resist_ValueChanged);
            // 
            // save_btn
            // 
            this.save_btn.AutoSize = true;
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(430, 242);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(103, 34);
            this.save_btn.TabIndex = 10;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // resist_title
            // 
            this.resist_title.AutoSize = true;
            this.resist_title.ForeColor = System.Drawing.Color.White;
            this.resist_title.Location = new System.Drawing.Point(209, 91);
            this.resist_title.Name = "resist_title";
            this.resist_title.Size = new System.Drawing.Size(205, 24);
            this.resist_title.TabIndex = 5;
            this.resist_title.Text = "PhysicalDamageResist:";
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
            this.zombie_hp.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.zombie_hp.ValueChanged += new System.EventHandler(this.Zombie_hp_ValueChanged);
            // 
            // hp_title
            // 
            this.hp_title.AutoSize = true;
            this.hp_title.ForeColor = System.Drawing.Color.White;
            this.hp_title.Location = new System.Drawing.Point(209, 56);
            this.hp_title.Name = "hp_title";
            this.hp_title.Size = new System.Drawing.Size(105, 24);
            this.hp_title.TabIndex = 3;
            this.hp_title.Text = "HealthMax:";
            this.hp_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zombie:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // 
            // saveDialog
            // 
            this.saveDialog.FileName = "entityclasses.xml";
            this.saveDialog.Filter = "XML files (*.xml)|*.xml";
            this.saveDialog.OverwritePrompt = false;
            this.saveDialog.Title = "Select the file \"entityclasses.xml\" from the path \"7 Days To Die\\Data\\Config\"";
            this.saveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveDialog_FileOk);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox zombie_list;
        private System.Windows.Forms.NumericUpDown zombie_hp;
        private System.Windows.Forms.Label hp_title;
        private System.Windows.Forms.NumericUpDown zombie_resist;
        private System.Windows.Forms.Label resist_title;
        private System.Windows.Forms.Label hp_default;
        private System.Windows.Forms.Label resist_default;
        private System.Windows.Forms.Button default_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Label devolp;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.GroupBox hp_rand_box;
        private System.Windows.Forms.Label min_hp_title;
        private System.Windows.Forms.Label hp_rand_title;
        private System.Windows.Forms.Button rand_hp_btn;
        private System.Windows.Forms.NumericUpDown max_hp_value;
        private System.Windows.Forms.NumericUpDown min_hp_value;
        private System.Windows.Forms.Label max_hp_title;
        private System.Windows.Forms.GroupBox resist_rand_box;
        private System.Windows.Forms.Button rand_resist_btn;
        private System.Windows.Forms.NumericUpDown max_resist_value;
        private System.Windows.Forms.NumericUpDown min_resist_value;
        private System.Windows.Forms.Label max_resist_title;
        private System.Windows.Forms.Label min_resist_title;
        private System.Windows.Forms.Label resist_rand_title;
        private System.Windows.Forms.SaveFileDialog saveDialog;
    }
}

