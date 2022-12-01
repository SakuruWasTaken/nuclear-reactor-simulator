namespace Reactor
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.InsertionLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DensityLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ThermalPowerLabel = new System.Windows.Forms.Label();
            this.RodsIn = new System.Windows.Forms.Button();
            this.RodsHold = new System.Windows.Forms.Button();
            this.RodsOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReactorTripResetButton = new System.Windows.Forms.Button();
            this.ReactorTripButton = new System.Windows.Forms.Button();
            this.ReactivityLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reactivity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rod Insertion";
            // 
            // InsertionLabel
            // 
            this.InsertionLabel.AutoSize = true;
            this.InsertionLabel.Location = new System.Drawing.Point(6, 64);
            this.InsertionLabel.Name = "InsertionLabel";
            this.InsertionLabel.Size = new System.Drawing.Size(25, 13);
            this.InsertionLabel.TabIndex = 3;
            this.InsertionLabel.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Neutron Density";
            // 
            // DensityLabel
            // 
            this.DensityLabel.AutoSize = true;
            this.DensityLabel.Location = new System.Drawing.Point(82, 29);
            this.DensityLabel.Name = "DensityLabel";
            this.DensityLabel.Size = new System.Drawing.Size(13, 13);
            this.DensityLabel.TabIndex = 5;
            this.DensityLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thermal Power";
            // 
            // ThermalPowerLabel
            // 
            this.ThermalPowerLabel.AutoSize = true;
            this.ThermalPowerLabel.Location = new System.Drawing.Point(82, 64);
            this.ThermalPowerLabel.Name = "ThermalPowerLabel";
            this.ThermalPowerLabel.Size = new System.Drawing.Size(36, 13);
            this.ThermalPowerLabel.TabIndex = 7;
            this.ThermalPowerLabel.Text = "0MWt";
            // 
            // RodsIn
            // 
            this.RodsIn.Location = new System.Drawing.Point(6, 138);
            this.RodsIn.Name = "RodsIn";
            this.RodsIn.Size = new System.Drawing.Size(75, 23);
            this.RodsIn.TabIndex = 8;
            this.RodsIn.Text = "Rods in";
            this.RodsIn.UseVisualStyleBackColor = true;
            this.RodsIn.Click += new System.EventHandler(this.RodsIn_Click);
            // 
            // RodsHold
            // 
            this.RodsHold.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.RodsHold.Location = new System.Drawing.Point(6, 109);
            this.RodsHold.Name = "RodsHold";
            this.RodsHold.Size = new System.Drawing.Size(75, 23);
            this.RodsHold.TabIndex = 9;
            this.RodsHold.Text = "Hold";
            this.RodsHold.UseVisualStyleBackColor = true;
            this.RodsHold.Click += new System.EventHandler(this.RodsHold_Click);
            // 
            // RodsOut
            // 
            this.RodsOut.Location = new System.Drawing.Point(6, 80);
            this.RodsOut.Name = "RodsOut";
            this.RodsOut.Size = new System.Drawing.Size(75, 23);
            this.RodsOut.TabIndex = 10;
            this.RodsOut.Text = "Rods out";
            this.RodsOut.UseVisualStyleBackColor = true;
            this.RodsOut.Click += new System.EventHandler(this.RodsOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReactorTripResetButton);
            this.groupBox1.Controls.Add(this.ReactorTripButton);
            this.groupBox1.Controls.Add(this.ReactivityLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RodsHold);
            this.groupBox1.Controls.Add(this.RodsIn);
            this.groupBox1.Controls.Add(this.RodsOut);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DensityLabel);
            this.groupBox1.Controls.Add(this.ThermalPowerLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.InsertionLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 168);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reactor";
            // 
            // ReactorTripResetButton
            // 
            this.ReactorTripResetButton.Location = new System.Drawing.Point(119, 110);
            this.ReactorTripResetButton.Name = "ReactorTripResetButton";
            this.ReactorTripResetButton.Size = new System.Drawing.Size(75, 23);
            this.ReactorTripResetButton.TabIndex = 13;
            this.ReactorTripResetButton.Text = "Reset";
            this.ReactorTripResetButton.UseVisualStyleBackColor = true;
            this.ReactorTripResetButton.Click += new System.EventHandler(this.ReactorTripResetButton_Click);
            // 
            // ReactorTripButton
            // 
            this.ReactorTripButton.Location = new System.Drawing.Point(119, 80);
            this.ReactorTripButton.Name = "ReactorTripButton";
            this.ReactorTripButton.Size = new System.Drawing.Size(75, 23);
            this.ReactorTripButton.TabIndex = 12;
            this.ReactorTripButton.Text = "Trip";
            this.ReactorTripButton.UseVisualStyleBackColor = true;
            this.ReactorTripButton.Click += new System.EventHandler(this.ReactorTripButton_Click);
            // 
            // ReactivityLabel
            // 
            this.ReactivityLabel.AutoSize = true;
            this.ReactivityLabel.Location = new System.Drawing.Point(7, 29);
            this.ReactivityLabel.Name = "ReactivityLabel";
            this.ReactivityLabel.Size = new System.Drawing.Size(16, 13);
            this.ReactivityLabel.TabIndex = 11;
            this.ReactivityLabel.Text = "-0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label InsertionLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DensityLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ThermalPowerLabel;
        private System.Windows.Forms.Button RodsIn;
        private System.Windows.Forms.Button RodsHold;
        private System.Windows.Forms.Button RodsOut;
        private bool ReactorTripActive = false;
        // 0: not moving
        // 1: moving out
        // 2: moving in
        private int RodsMoving = 0;
        private float RodInsertion = 100f;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ReactivityLabel;
        private System.Windows.Forms.Button ReactorTripResetButton;
        private System.Windows.Forms.Button ReactorTripButton;
    }
}

