using System;
using System.IO;
using System.Linq;
using _7DtD_HP.Classes;
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

        private void SaveConfig()
        {
            try
            {
                string[] lines = File.ReadAllLines("entityclasses.xml");
                foreach (var zombie in Zombies)
                {
                    lines[zombie.HealthMaxLineIndex - 1] = $"\t\t<passive_effect name=\"HealthMax\" operation=\"base_set\" value=\"{zombie.HealthMax}\"/>";
                    if (zombie.HasPhysicalDamageResist) lines[zombie.PhysicalDamageResistLineIndex - 1] = $"\t\t<passive_effect name=\"PhysicalDamageResist\" operation=\"base_set\" value=\"{zombie.PhysicalDamageResist}\"/>";
                }
                File.WriteAllLines("entityclasses.xml", lines);
            }
            catch
            {
                if (File.Exists("entityclasses.xml")) File.Delete("entityclasses.xml");
                MessageBox.Show("The entityclasses.xml file is corrupted! Please copy the new file from the game folder (7 Days To Die\\Data\\Config) to the same folder as 7DtD_HP.exe",
                    "The entityclasses.xml file is corrupted!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

        private void UpdateInfo()
        {
            zombie_icon.Image = Zombies[zombie_list.SelectedIndex].Icon;
            hp_default.Text = $"Default: {Zombies[zombie_list.SelectedIndex].DefaultHealthMax}";
            resist_default.Text = $"Default: {Zombies[zombie_list.SelectedIndex].DefaultHealthMax}";
            zombie_resist.Enabled = Zombies[zombie_list.SelectedIndex].HasPhysicalDamageResist;
            try
            {
                zombie_hp.Value = Zombies[zombie_list.SelectedIndex].HealthMax;
                zombie_resist.Value = Zombies[zombie_list.SelectedIndex].PhysicalDamageResist;
            }
            catch
            {
                zombie_hp.Value = Zombies[zombie_list.SelectedIndex].DefaultHealthMax;
                zombie_resist.Value = Zombies[zombie_list.SelectedIndex].DefaultPhysicalDamageResist;
            }
        }

        private void Zombie_hp_ValueChanged(object sender, EventArgs e) => Zombies[zombie_list.SelectedIndex].HealthMax = (int)zombie_hp.Value;

        private void Zombie_resist_ValueChanged(object sender, EventArgs e) => Zombies[zombie_list.SelectedIndex].PhysicalDamageResist = (int)zombie_resist.Value;

        private void Default_btn_Click(object sender, EventArgs e) => ToDefault();

        private void Save_btn_Click(object sender, EventArgs e) => SaveConfig();

        private void Apply_btn_Click(object sender, EventArgs e) => saveDialog.ShowDialog();

        private void Load_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("entityclasses.xml");
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
                if (File.Exists("entityclasses.xml")) File.Delete("entityclasses.xml");
                MessageBox.Show("The entityclasses.xml file is corrupted! Please copy the new file from the game folder (7 Days To Die\\Data\\Config) to the same folder as 7DtD_HP.exe",
                    "The entityclasses.xml file is corrupted!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            UpdateInfo();
        }

        private void Rand_hp_btn_Click(object sender, EventArgs e)
        {
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

        private void SaveDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (File.Exists(saveDialog.FileName)) File.Delete(saveDialog.FileName);
            SaveConfig();
            File.Copy("entityclasses.xml", saveDialog.FileName);
        }
    }
}