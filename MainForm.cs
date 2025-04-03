using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _7DtD_HP
{
    public partial class MainForm : Form
    {
        private readonly Zombie[] Zombies;
        private Zombie Zombie => Zombies[zombie_list.SelectedIndex];

        private void Devolp_MouseClick(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) Process.Start(new ProcessStartInfo("https://github.com/Lonewolf239") { UseShellExecute = true }); }

        private static Zombie[] GetZombies()
        {
            var zombieType = typeof(Zombie);
            var derivedTypes = Assembly.GetAssembly(zombieType).GetTypes().Where(t => zombieType.IsAssignableFrom(t) && !t.IsAbstract);
            var result = new List<Zombie>();
            foreach (var type in derivedTypes) result.Add((Zombie)Activator.CreateInstance(type));
            return result.ToArray();
        }

        public MainForm()
        {
            InitializeComponent();
            Zombies = GetZombies();
            zombie_list.Items.AddRange(Zombies);
            zombie_list.SelectedIndex = 0;
        }

        private void Zombie_list_SelectedIndexChanged(object sender, EventArgs e) => UpdateInfo();

        private void ToDefault()
        {
            foreach (var zombie in Zombies)
            {
                zombie.HealthMax = zombie.DefaultHealthMax;
                zombie.PhysicalDamageResist = zombie.DefaultPhysicalDamageResist;
            }
            UpdateInfo();
        }

        private void LoadConfig()
        {
            try
            {
                string[] lines = File.ReadAllLines(Program.ECFile);
                const string hpPattern = @"\d+";
                const string resistPattern = @"\d+";
                foreach (var zombie in Zombies)
                {
                    var hp = lines[zombie.HealthMaxLineIndex - 1].Split('=')[3];
                    Match match = Regex.Match(hp, hpPattern);
                    if (match.Success) zombie.HealthMax = int.Parse(match.Value);
                    if (zombie.HasPhysicalDamageResist)
                    {
                        var resist = lines[zombie.HealthMaxLineIndex - 1].Split('=')[3];
                        match = Regex.Match(resist, resistPattern);
                        if (match.Success) zombie.PhysicalDamageResist = int.Parse(match.Value);
                    }
                }
            }
            catch
            {
                ToDefault();
                if (File.Exists(Program.ECFile)) File.Delete(Program.ECFile);
                MessageBox.Show("The entityclasses.xml file is corrupted! Please verify your game files through Steam to resolve the issue.",
                                "Entityclasses.xml Corrupted",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void UpdateInfo()
        {
            zombie_icon.BackgroundImage = Zombie.Icon;
            if (Zombie.Type == Zombie.ZombieType.Feral) zombie_icon.Image = Properties.Resources.feral;
            else if (Zombie.Type == Zombie.ZombieType.Radiated) zombie_icon.Image = Properties.Resources.radiated;
            else zombie_icon.Image = null;
            hp_default.Text = $"Default: {Zombie.DefaultHealthMax}";
            resist_default.Text = $"Default: {Zombie.DefaultPhysicalDamageResist}";
            zombie_resist.Enabled = Zombie.HasPhysicalDamageResist;
            try
            {
                zombie_hp.Value = Zombie.HealthMax;
                zombie_resist.Value = Zombie.PhysicalDamageResist;
            }
            catch
            {
                zombie_hp.Value = Zombie.DefaultHealthMax;
                zombie_resist.Value = Zombie.DefaultPhysicalDamageResist;
            }
        }

        private void Zombie_hp_ValueChanged(object sender, EventArgs e) => Zombie.HealthMax = (int)zombie_hp.Value;

        private void Zombie_resist_ValueChanged(object sender, EventArgs e) => Zombie.PhysicalDamageResist = (int)zombie_resist.Value;

        private void Default_btn_Click(object sender, EventArgs e)
        {
            zombie_panel.Focus();
            ToDefault();
        }

        private void Apply_btn_Click(object sender, EventArgs e)
        {
            zombie_panel.Focus();
            try
            {
                string[] lines = File.ReadAllLines(Program.ECFile);
                foreach (var zombie in Zombies)
                {
                    lines[zombie.HealthMaxLineIndex - 1] = $"\t\t<passive_effect name=\"HealthMax\" operation=\"base_set\" value=\"{zombie.HealthMax}\"/>";
                    if (zombie.HasPhysicalDamageResist) lines[zombie.PhysicalDamageResistLineIndex - 1] = $"\t\t<passive_effect name=\"PhysicalDamageResist\" operation=\"base_set\" value=\"{zombie.PhysicalDamageResist}\"/>";
                }
                File.WriteAllLines(Program.ECFile, lines);
            }
            catch
            {
                if (File.Exists(Program.ECFile)) File.Delete(Program.ECFile);
                MessageBox.Show("The entityclasses.xml file is corrupted! Please verify your game files through Steam to resolve the issue.",
                                "Entityclasses.xml Corrupted",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Load_btn_Click(object sender, EventArgs e)
        {
            zombie_panel.Focus();
            LoadConfig();
            UpdateInfo();
        }

        private void Rand_hp_btn_Click(object sender, EventArgs e)
        {
            zombie_panel.Focus();
            int min = (int)Math.Min(min_hp_value.Value, max_hp_value.Value);
            int max = (int)Math.Max(min_hp_value.Value, max_hp_value.Value);
            min_hp_value.Value = min;
            max_hp_value.Value = max;
            if (min == max)
            {
                MessageBox.Show("Error: The minimum value cannot be equal to the maximum value. Please provide a valid range.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            foreach (var zombie in Zombies) zombie.HealthMax = rand.Next(min, max);
            UpdateInfo();
        }

        private void Rand_resist_btn_Click(object sender, EventArgs e)
        {
            zombie_panel.Focus();
            int min = (int)Math.Min(min_resist_value.Value, max_resist_value.Value);
            int max = (int)Math.Max(min_resist_value.Value, max_resist_value.Value);
            min_resist_value.Value = min;
            max_resist_value.Value = max;
            if (min == max)
            {
                MessageBox.Show("Error: The minimum value cannot be equal to the maximum value. Please provide a valid range.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            foreach (var zombie in Zombies) { if (zombie.HasPhysicalDamageResist) zombie.PhysicalDamageResist = rand.Next(min, max); }
            UpdateInfo();
        }

        private void Backup_btn_Click(object sender, EventArgs e)
        {
            zombie_panel.Focus();
            if (File.Exists(Program.BECFile))
            {
                if (File.Exists(Program.ECFile)) File.Delete(Program.ECFile);
                File.Copy(Program.BECFile, Program.ECFile);
            }
            LoadConfig();
            UpdateInfo();
        }
    }
}