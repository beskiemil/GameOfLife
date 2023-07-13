namespace Gra_w_życie.Forms
{
    partial class SimulationParametersForm
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
            this.boardSizeLabel = new System.Windows.Forms.Label();
            this.boardSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bannerLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.maxRoundsLabel = new System.Windows.Forms.Label();
            this.simulationNameTextBox = new System.Windows.Forms.TextBox();
            this.simulationNameLabel = new System.Windows.Forms.Label();
            this.maxRoundsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.boardSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRoundsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // boardSizeLabel
            // 
            this.boardSizeLabel.AutoSize = true;
            this.boardSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boardSizeLabel.Location = new System.Drawing.Point(29, 88);
            this.boardSizeLabel.Name = "boardSizeLabel";
            this.boardSizeLabel.Size = new System.Drawing.Size(125, 20);
            this.boardSizeLabel.TabIndex = 1;
            this.boardSizeLabel.Text = "Rozmiar planszy";
            // 
            // boardSizeNumericUpDown
            // 
            this.boardSizeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boardSizeNumericUpDown.Location = new System.Drawing.Point(160, 86);
            this.boardSizeNumericUpDown.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.boardSizeNumericUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.boardSizeNumericUpDown.Name = "boardSizeNumericUpDown";
            this.boardSizeNumericUpDown.Size = new System.Drawing.Size(135, 26);
            this.boardSizeNumericUpDown.TabIndex = 8;
            this.boardSizeNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // bannerLabel
            // 
            this.bannerLabel.AutoSize = true;
            this.bannerLabel.Font = new System.Drawing.Font("Bauhaus 93", 27.75F, System.Drawing.FontStyle.Bold);
            this.bannerLabel.Location = new System.Drawing.Point(43, 22);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(264, 42);
            this.bannerLabel.TabIndex = 9;
            this.bannerLabel.Text = "Parametry gry";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submitButton.Location = new System.Drawing.Point(179, 212);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(126, 31);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Dalej -->";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(48, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "<-- Cofnij";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // maxRoundsLabel
            // 
            this.maxRoundsLabel.AutoSize = true;
            this.maxRoundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxRoundsLabel.Location = new System.Drawing.Point(76, 121);
            this.maxRoundsLabel.Name = "maxRoundsLabel";
            this.maxRoundsLabel.Size = new System.Drawing.Size(78, 20);
            this.maxRoundsLabel.TabIndex = 12;
            this.maxRoundsLabel.Text = "Ilość rund";
            // 
            // simulationNameTextBox
            // 
            this.simulationNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.simulationNameTextBox.Location = new System.Drawing.Point(160, 150);
            this.simulationNameTextBox.Name = "simulationNameTextBox";
            this.simulationNameTextBox.Size = new System.Drawing.Size(135, 26);
            this.simulationNameTextBox.TabIndex = 15;
            // 
            // simulationNameLabel
            // 
            this.simulationNameLabel.AutoSize = true;
            this.simulationNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.simulationNameLabel.Location = new System.Drawing.Point(29, 153);
            this.simulationNameLabel.Name = "simulationNameLabel";
            this.simulationNameLabel.Size = new System.Drawing.Size(124, 20);
            this.simulationNameLabel.TabIndex = 14;
            this.simulationNameLabel.Text = "Nazwa symulacji";
            // 
            // maxRoundsNumericUpDown
            // 
            this.maxRoundsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxRoundsNumericUpDown.Location = new System.Drawing.Point(160, 118);
            this.maxRoundsNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.maxRoundsNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.maxRoundsNumericUpDown.Name = "maxRoundsNumericUpDown";
            this.maxRoundsNumericUpDown.Size = new System.Drawing.Size(135, 26);
            this.maxRoundsNumericUpDown.TabIndex = 16;
            this.maxRoundsNumericUpDown.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            // 
            // SimulationParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 274);
            this.Controls.Add(this.maxRoundsNumericUpDown);
            this.Controls.Add(this.simulationNameTextBox);
            this.Controls.Add(this.simulationNameLabel);
            this.Controls.Add(this.maxRoundsLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.bannerLabel);
            this.Controls.Add(this.boardSizeNumericUpDown);
            this.Controls.Add(this.boardSizeLabel);
            this.Name = "SimulationParametersForm";
            this.Text = "Nowa gra";
            ((System.ComponentModel.ISupportInitialize)(this.boardSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRoundsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label boardSizeLabel;
        private System.Windows.Forms.NumericUpDown boardSizeNumericUpDown;
        private System.Windows.Forms.Label bannerLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label maxRoundsLabel;
        private System.Windows.Forms.TextBox simulationNameTextBox;
        private System.Windows.Forms.Label simulationNameLabel;
        private System.Windows.Forms.NumericUpDown maxRoundsNumericUpDown;
    }
}