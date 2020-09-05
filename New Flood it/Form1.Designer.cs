namespace New_Flood_it
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labSteps = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cheShow = new System.Windows.Forms.CheckBox();
            this.butSolve = new System.Windows.Forms.Button();
            this.butHint = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.labSize = new System.Windows.Forms.Label();
            this.comSize = new System.Windows.Forms.ComboBox();
            this.butBlue = new System.Windows.Forms.Button();
            this.butPurple = new System.Windows.Forms.Button();
            this.butGreen = new System.Windows.Forms.Button();
            this.butYellow = new System.Windows.Forms.Button();
            this.butOrange = new System.Windows.Forms.Button();
            this.butRed = new System.Windows.Forms.Button();
            this.board_Flood_It_Control = new New_Flood_it.Board_Flood_It_Control();
            this.SuspendLayout();
            // 
            // labSteps
            // 
            this.labSteps.AutoSize = true;
            this.labSteps.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSteps.Location = new System.Drawing.Point(27, 328);
            this.labSteps.Name = "labSteps";
            this.labSteps.Size = new System.Drawing.Size(49, 18);
            this.labSteps.TabIndex = 27;
            this.labSteps.Text = "0 steps";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 284);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(133, 26);
            this.progressBar1.TabIndex = 26;
            // 
            // cheShow
            // 
            this.cheShow.AutoSize = true;
            this.cheShow.Location = new System.Drawing.Point(21, 261);
            this.cheShow.Name = "cheShow";
            this.cheShow.Size = new System.Drawing.Size(116, 17);
            this.cheShow.TabIndex = 25;
            this.cheShow.Text = "Show while solving";
            this.cheShow.UseVisualStyleBackColor = true;
            // 
            // butSolve
            // 
            this.butSolve.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSolve.Location = new System.Drawing.Point(21, 215);
            this.butSolve.Name = "butSolve";
            this.butSolve.Size = new System.Drawing.Size(133, 27);
            this.butSolve.TabIndex = 24;
            this.butSolve.Text = "Solve";
            this.butSolve.UseVisualStyleBackColor = true;
            this.butSolve.Click += new System.EventHandler(this.butSolve_Click);
            // 
            // butHint
            // 
            this.butHint.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHint.Location = new System.Drawing.Point(99, 167);
            this.butHint.Name = "butHint";
            this.butHint.Size = new System.Drawing.Size(55, 27);
            this.butHint.TabIndex = 23;
            this.butHint.Text = "Hint";
            this.butHint.UseVisualStyleBackColor = true;
            // 
            // butReset
            // 
            this.butReset.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReset.Location = new System.Drawing.Point(21, 167);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(55, 27);
            this.butReset.TabIndex = 22;
            this.butReset.Text = "Reset";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butResert_Click);
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSize.Location = new System.Drawing.Point(25, 110);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(34, 16);
            this.labSize.TabIndex = 21;
            this.labSize.Text = "Size";
            // 
            // comSize
            // 
            this.comSize.FormattingEnabled = true;
            this.comSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.comSize.Location = new System.Drawing.Point(21, 129);
            this.comSize.Name = "comSize";
            this.comSize.Size = new System.Drawing.Size(133, 21);
            this.comSize.TabIndex = 20;
            this.comSize.SelectedValueChanged += new System.EventHandler(this.comSize_SelectedValueChanged);
            // 
            // butBlue
            // 
            this.butBlue.BackColor = System.Drawing.Color.Blue;
            this.butBlue.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.butBlue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butBlue.Location = new System.Drawing.Point(67, 19);
            this.butBlue.Name = "butBlue";
            this.butBlue.Size = new System.Drawing.Size(40, 30);
            this.butBlue.TabIndex = 19;
            this.butBlue.UseVisualStyleBackColor = false;
            this.butBlue.Click += new System.EventHandler(this.butBlue_Click);
            // 
            // butPurple
            // 
            this.butPurple.BackColor = System.Drawing.Color.Purple;
            this.butPurple.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.butPurple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butPurple.Location = new System.Drawing.Point(114, 19);
            this.butPurple.Name = "butPurple";
            this.butPurple.Size = new System.Drawing.Size(40, 30);
            this.butPurple.TabIndex = 18;
            this.butPurple.UseVisualStyleBackColor = false;
            this.butPurple.Click += new System.EventHandler(this.butPurple_Click);
            // 
            // butGreen
            // 
            this.butGreen.BackColor = System.Drawing.Color.Green;
            this.butGreen.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.butGreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butGreen.Location = new System.Drawing.Point(21, 58);
            this.butGreen.Name = "butGreen";
            this.butGreen.Size = new System.Drawing.Size(40, 30);
            this.butGreen.TabIndex = 17;
            this.butGreen.UseVisualStyleBackColor = false;
            this.butGreen.Click += new System.EventHandler(this.butGreen_Click);
            // 
            // butYellow
            // 
            this.butYellow.BackColor = System.Drawing.Color.Yellow;
            this.butYellow.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.butYellow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butYellow.Location = new System.Drawing.Point(68, 58);
            this.butYellow.Name = "butYellow";
            this.butYellow.Size = new System.Drawing.Size(40, 30);
            this.butYellow.TabIndex = 16;
            this.butYellow.UseVisualStyleBackColor = false;
            this.butYellow.Click += new System.EventHandler(this.butYellow_Click);
            // 
            // butOrange
            // 
            this.butOrange.BackColor = System.Drawing.Color.Orange;
            this.butOrange.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.butOrange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butOrange.Location = new System.Drawing.Point(114, 55);
            this.butOrange.Name = "butOrange";
            this.butOrange.Size = new System.Drawing.Size(40, 33);
            this.butOrange.TabIndex = 15;
            this.butOrange.UseVisualStyleBackColor = false;
            this.butOrange.Click += new System.EventHandler(this.butOrange_Click);
            // 
            // butRed
            // 
            this.butRed.BackColor = System.Drawing.Color.Red;
            this.butRed.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.butRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butRed.Location = new System.Drawing.Point(21, 19);
            this.butRed.Name = "butRed";
            this.butRed.Size = new System.Drawing.Size(40, 30);
            this.butRed.TabIndex = 14;
            this.butRed.UseVisualStyleBackColor = false;
            this.butRed.Click += new System.EventHandler(this.butRed_Click);
            // 
            // board_Flood_It_Control
            // 
            this.board_Flood_It_Control.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.board_Flood_It_Control.Board = null;
            this.board_Flood_It_Control.Location = new System.Drawing.Point(178, 8);
            this.board_Flood_It_Control.Name = "board_Flood_It_Control";
            this.board_Flood_It_Control.Size = new System.Drawing.Size(395, 388);
            this.board_Flood_It_Control.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 408);
            this.Controls.Add(this.board_Flood_It_Control);
            this.Controls.Add(this.labSteps);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cheShow);
            this.Controls.Add(this.butSolve);
            this.Controls.Add(this.butHint);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.labSize);
            this.Controls.Add(this.comSize);
            this.Controls.Add(this.butBlue);
            this.Controls.Add(this.butPurple);
            this.Controls.Add(this.butGreen);
            this.Controls.Add(this.butYellow);
            this.Controls.Add(this.butOrange);
            this.Controls.Add(this.butRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labSteps;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox cheShow;
        private System.Windows.Forms.Button butSolve;
        private System.Windows.Forms.Button butHint;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.ComboBox comSize;
        private System.Windows.Forms.Button butBlue;
        private System.Windows.Forms.Button butPurple;
        private System.Windows.Forms.Button butGreen;
        private System.Windows.Forms.Button butYellow;
        private System.Windows.Forms.Button butOrange;
        private System.Windows.Forms.Button butRed;
        private Board_Flood_It_Control board_Flood_It_Control;
    }
}

