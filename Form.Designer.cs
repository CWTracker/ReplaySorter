namespace Replay_sorter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.source_directory_box = new System.Windows.Forms.GroupBox();
            this.source_directory_textbox = new System.Windows.Forms.TextBox();
            this.source_directory_button = new System.Windows.Forms.Button();
            this.destination_directory_box = new System.Windows.Forms.GroupBox();
            this.destination_directory_textbox = new System.Windows.Forms.TextBox();
            this.destination_directory_button = new System.Windows.Forms.Button();
            this.horizontal_line_label = new System.Windows.Forms.Label();
            this.sort_replays_button = new System.Windows.Forms.Button();
            this.copyright_label = new System.Windows.Forms.Label();
            this.source_directory_box.SuspendLayout();
            this.destination_directory_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // source_directory_box
            // 
            this.source_directory_box.Controls.Add(this.source_directory_textbox);
            this.source_directory_box.Controls.Add(this.source_directory_button);
            this.source_directory_box.Location = new System.Drawing.Point(12, 12);
            this.source_directory_box.Name = "source_directory_box";
            this.source_directory_box.Size = new System.Drawing.Size(560, 52);
            this.source_directory_box.TabIndex = 0;
            this.source_directory_box.TabStop = false;
            this.source_directory_box.Text = "Source directory";
            // 
            // source_directory_textbox
            // 
            this.source_directory_textbox.Location = new System.Drawing.Point(6, 19);
            this.source_directory_textbox.Name = "source_directory_textbox";
            this.source_directory_textbox.ReadOnly = true;
            this.source_directory_textbox.Size = new System.Drawing.Size(518, 20);
            this.source_directory_textbox.TabIndex = 1;
            // 
            // source_directory_button
            // 
            this.source_directory_button.Location = new System.Drawing.Point(530, 19);
            this.source_directory_button.Name = "source_directory_button";
            this.source_directory_button.Size = new System.Drawing.Size(24, 20);
            this.source_directory_button.TabIndex = 2;
            this.source_directory_button.Text = "...";
            this.source_directory_button.UseVisualStyleBackColor = true;
            this.source_directory_button.Click += new System.EventHandler(this.source_directory_button_click);
            // 
            // destination_directory_box
            // 
            this.destination_directory_box.Controls.Add(this.destination_directory_textbox);
            this.destination_directory_box.Controls.Add(this.destination_directory_button);
            this.destination_directory_box.Location = new System.Drawing.Point(12, 70);
            this.destination_directory_box.Name = "destination_directory_box";
            this.destination_directory_box.Size = new System.Drawing.Size(560, 52);
            this.destination_directory_box.TabIndex = 3;
            this.destination_directory_box.TabStop = false;
            this.destination_directory_box.Text = "Destination directory";
            // 
            // destination_directory_textbox
            // 
            this.destination_directory_textbox.Location = new System.Drawing.Point(6, 19);
            this.destination_directory_textbox.Name = "destination_directory_textbox";
            this.destination_directory_textbox.ReadOnly = true;
            this.destination_directory_textbox.Size = new System.Drawing.Size(518, 20);
            this.destination_directory_textbox.TabIndex = 4;
            // 
            // destination_directory_button
            // 
            this.destination_directory_button.Location = new System.Drawing.Point(530, 18);
            this.destination_directory_button.Name = "destination_directory_button";
            this.destination_directory_button.Size = new System.Drawing.Size(24, 20);
            this.destination_directory_button.TabIndex = 5;
            this.destination_directory_button.Text = "...";
            this.destination_directory_button.UseVisualStyleBackColor = true;
            this.destination_directory_button.Click += new System.EventHandler(this.destination_directory_button_click);
            // 
            // horizontal_line_label
            // 
            this.horizontal_line_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontal_line_label.Enabled = false;
            this.horizontal_line_label.Location = new System.Drawing.Point(12, 125);
            this.horizontal_line_label.Name = "horizontal_line_label";
            this.horizontal_line_label.Size = new System.Drawing.Size(560, 2);
            this.horizontal_line_label.TabIndex = 6;
            // 
            // sort_replays_button
            // 
            this.sort_replays_button.Location = new System.Drawing.Point(472, 130);
            this.sort_replays_button.Name = "sort_replays_button";
            this.sort_replays_button.Size = new System.Drawing.Size(100, 23);
            this.sort_replays_button.TabIndex = 7;
            this.sort_replays_button.Text = "Sort replays";
            this.sort_replays_button.UseVisualStyleBackColor = true;
            this.sort_replays_button.Click += new System.EventHandler(this.sort_replays_button_click);
            // 
            // copyright_label
            // 
            this.copyright_label.AutoSize = true;
            this.copyright_label.Enabled = false;
            this.copyright_label.Location = new System.Drawing.Point(9, 135);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(285, 13);
            this.copyright_label.TabIndex = 8;
            this.copyright_label.Text = "Copyright (C) 2017 CWTracker - Replay sorter (Version 1.0)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 162);
            this.Controls.Add(this.horizontal_line_label);
            this.Controls.Add(this.destination_directory_box);
            this.Controls.Add(this.copyright_label);
            this.Controls.Add(this.sort_replays_button);
            this.Controls.Add(this.source_directory_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CWTracker - Replay sorter";
            this.source_directory_box.ResumeLayout(false);
            this.source_directory_box.PerformLayout();
            this.destination_directory_box.ResumeLayout(false);
            this.destination_directory_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox source_directory_box;
        private System.Windows.Forms.TextBox source_directory_textbox;
        private System.Windows.Forms.Button source_directory_button;
        private System.Windows.Forms.GroupBox destination_directory_box;
        private System.Windows.Forms.TextBox destination_directory_textbox;
        private System.Windows.Forms.Button destination_directory_button;
        private System.Windows.Forms.Label horizontal_line_label;
        private System.Windows.Forms.Button sort_replays_button;
        private System.Windows.Forms.Label copyright_label;
    }
}

