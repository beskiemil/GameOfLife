namespace Gra_w_życie.Forms
{
    partial class StartMenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.symulacjaButton = new System.Windows.Forms.Button();
            this.loadSimulationButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game of Life";
            // 
            // symulacjaButton
            // 
            this.symulacjaButton.Location = new System.Drawing.Point(170, 111);
            this.symulacjaButton.Name = "symulacjaButton";
            this.symulacjaButton.Size = new System.Drawing.Size(227, 47);
            this.symulacjaButton.TabIndex = 1;
            this.symulacjaButton.Text = "Nowa symulacja";
            this.symulacjaButton.UseVisualStyleBackColor = true;
            this.symulacjaButton.Click += new System.EventHandler(this.symulacjaButton_Click);
            // 
            // loadSimulationButton
            // 
            this.loadSimulationButton.Location = new System.Drawing.Point(170, 164);
            this.loadSimulationButton.Name = "loadSimulationButton";
            this.loadSimulationButton.Size = new System.Drawing.Size(227, 47);
            this.loadSimulationButton.TabIndex = 2;
            this.loadSimulationButton.Text = "Wczytaj symulacje (WIP)";
            this.loadSimulationButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(170, 217);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(227, 47);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Wyjście";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // StartMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 346);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loadSimulationButton);
            this.Controls.Add(this.symulacjaButton);
            this.Controls.Add(this.label1);
            this.Name = "StartMenuForm";
            this.Text = "Game of Life";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button symulacjaButton;
        private System.Windows.Forms.Button loadSimulationButton;
        private System.Windows.Forms.Button exitButton;
    }
}