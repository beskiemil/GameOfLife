namespace Gra_w_życie.Forms
{
    partial class SimulationForm
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
            this.pobierzSymulacjeButton = new System.Windows.Forms.Button();
            this.nextRoundButton = new System.Windows.Forms.Button();
            this.previousRound = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.intervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.boardControl = new GraWZycieControlLibrary.Controls.BoardControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pobierzSymulacjeButton
            // 
            this.pobierzSymulacjeButton.Location = new System.Drawing.Point(15, 24);
            this.pobierzSymulacjeButton.Name = "pobierzSymulacjeButton";
            this.pobierzSymulacjeButton.Size = new System.Drawing.Size(121, 23);
            this.pobierzSymulacjeButton.TabIndex = 1;
            this.pobierzSymulacjeButton.Text = "Pobierz symulacje";
            this.pobierzSymulacjeButton.UseVisualStyleBackColor = true;
            this.pobierzSymulacjeButton.Click += new System.EventHandler(this.pobierzSymulacjeButton_Click);
            // 
            // nextRoundButton
            // 
            this.nextRoundButton.Location = new System.Drawing.Point(15, 53);
            this.nextRoundButton.Name = "nextRoundButton";
            this.nextRoundButton.Size = new System.Drawing.Size(121, 23);
            this.nextRoundButton.TabIndex = 2;
            this.nextRoundButton.Text = "Następna runda";
            this.nextRoundButton.UseVisualStyleBackColor = true;
            this.nextRoundButton.Click += new System.EventHandler(this.nextRoundButton_Click);
            // 
            // previousRound
            // 
            this.previousRound.Location = new System.Drawing.Point(15, 82);
            this.previousRound.Name = "previousRound";
            this.previousRound.Size = new System.Drawing.Size(121, 23);
            this.previousRound.TabIndex = 3;
            this.previousRound.Text = "Poprzednia runda";
            this.previousRound.UseVisualStyleBackColor = true;
            this.previousRound.Click += new System.EventHandler(this.previousRound_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.intervalNumericUpDown);
            this.panel1.Controls.Add(this.pobierzSymulacjeButton);
            this.panel1.Controls.Add(this.previousRound);
            this.panel1.Controls.Add(this.nextRoundButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(652, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 450);
            this.panel1.TabIndex = 4;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(15, 258);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(121, 23);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Wyczyść";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(15, 220);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(121, 23);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(15, 191);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(121, 23);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Start";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Interwał";
            // 
            // intervalNumericUpDown
            // 
            this.intervalNumericUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.intervalNumericUpDown.Location = new System.Drawing.Point(15, 164);
            this.intervalNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.intervalNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.intervalNumericUpDown.Name = "intervalNumericUpDown";
            this.intervalNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.intervalNumericUpDown.TabIndex = 4;
            this.intervalNumericUpDown.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // boardControl
            // 
            this.boardControl.BackColor = System.Drawing.Color.Wheat;
            this.boardControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.boardControl.Location = new System.Drawing.Point(0, 0);
            this.boardControl.MaximumSize = new System.Drawing.Size(342, 342);
            this.boardControl.MinimumSize = new System.Drawing.Size(342, 342);
            this.boardControl.Name = "boardControl";
            this.boardControl.Size = new System.Drawing.Size(342, 342);
            this.boardControl.TabIndex = 5;
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boardControl);
            this.Controls.Add(this.panel1);
            this.Name = "SimulationForm";
            this.Text = "SymulacjaForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        
        private System.Windows.Forms.Button pobierzSymulacjeButton;
        private System.Windows.Forms.Button nextRoundButton;
        private System.Windows.Forms.Button previousRound;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown intervalNumericUpDown;
        private System.Windows.Forms.Button resetButton;
        private GraWZycieControlLibrary.Controls.BoardControl boardControl;
    }
}