using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Replay_sorter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void source_directory_button_click(object sender, EventArgs e)
        {
            using(var source_directory_dialog = new FolderBrowserDialog())
            {
                if(source_directory_dialog.ShowDialog() == DialogResult.OK)
                {
                    this.source_directory_textbox.Text = source_directory_dialog.SelectedPath;
                }
            }
        }

        private void destination_directory_button_click(object sender, EventArgs e)
        {
            using(var destination_directory_dialog = new FolderBrowserDialog())
            {
                if(destination_directory_dialog.ShowDialog() == DialogResult.OK)
                {
                    this.destination_directory_textbox.Text = destination_directory_dialog.SelectedPath;
                }
            }
        }

        private void sort_replays_button_click(object sender, EventArgs e)
        {
            this.source_directory_button.Enabled = false;
            this.destination_directory_button.Enabled = false;
            this.sort_replays_button.Enabled = false;

            if(!Directory.Exists(this.source_directory_textbox.Text))
            {
                MessageBox.Show("Source directory doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!Directory.Exists(this.destination_directory_textbox.Text))
            {
                MessageBox.Show("Destination directory doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var replay_files = Directory.GetFiles(this.source_directory_textbox.Text, "*.wotreplay", SearchOption.AllDirectories);

                    foreach(string current_file in replay_files)
                    {
                        using(BinaryReader binary_reader = new BinaryReader(File.Open(current_file, FileMode.Open)))
                        {
                            uint[] replay_header = new uint[3];

                            for(byte h = 0; h < 3; ++h)
                            {
                                replay_header[h] = binary_reader.ReadUInt32();
                            }

                            if(replay_header[0] == 288633362)
                            {
                                byte[] data_block = new byte[replay_header[2]];

                                for(int h = 0; h < replay_header[2]; ++h)
                                {
                                    data_block[h] = binary_reader.ReadByte();
                                }

                                string json_data_block = System.Text.Encoding.UTF8.GetString(data_block, 0, Convert.ToInt32(replay_header[2]));
                                Replay_info replay_info = JsonConvert.DeserializeObject<Replay_info>(json_data_block);
                                string combined_path = Path.Combine(this.destination_directory_textbox.Text, replay_info.clientVersionFromExe);

                                if(!Directory.Exists(combined_path))
                                {
                                    Directory.CreateDirectory(combined_path);
                                }

                                combined_path = Path.Combine(combined_path, this.parse_battle_type(replay_info.battleType));

                                if(!Directory.Exists(combined_path))
                                {
                                    Directory.CreateDirectory(combined_path);
                                }

                                combined_path = Path.Combine(combined_path, Path.GetFileName(current_file));

                                if(!File.Exists(combined_path))
                                {
                                    using(BinaryWriter binary_writer = new BinaryWriter(File.Open(combined_path, FileMode.CreateNew)))
                                    {
                                        binary_reader.BaseStream.Position = 0;
                                        byte[] replay = new byte[binary_reader.BaseStream.Length];
                                        replay = binary_reader.ReadBytes(Convert.ToInt32(binary_reader.BaseStream.Length));
                                        binary_writer.Write(replay, 0, replay.Length);
                                    }

                                    File.SetCreationTime(combined_path, File.GetCreationTime(current_file));
                                    File.SetLastWriteTime(combined_path, File.GetLastWriteTime(current_file));
                                }                                
                            }
                        }
                    }

                    MessageBox.Show("Job done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message, "Exception");
                }
            }

            this.source_directory_button.Enabled = true;
            this.destination_directory_button.Enabled = true;
            this.sort_replays_button.Enabled = true;
        }

        private string parse_battle_type(byte battle_type)
        {
            switch(battle_type)
            {
                case 1:
                    return "Randoms";

                case 2:
                    return "Trainings";

                case 7:
                    return "Team_battles";

                case 13:
                    return "Clan_Wars";

                case 14:
                    return "Tournaments";

                case 17:
                    return "Proving_ground_battles";

                case 20:
                    return "Stronghold_battles";

                case 21:
                    return "Assaults";

                default:
                    return Convert.ToString(battle_type);
            }
        }
    }
}