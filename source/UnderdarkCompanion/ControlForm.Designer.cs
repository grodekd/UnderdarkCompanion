namespace UnderdarkCompanion
{
    partial class ControlForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.outsetComboBox = new System.Windows.Forms.ComboBox();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.setDestinationButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.paceComboBox = new System.Windows.Forms.ComboBox();
            this.setPaceButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.travelDayButton = new System.Windows.Forms.Button();
            this.daysToTravelInput = new System.Windows.Forms.NumericUpDown();
            this.addFoodInput = new System.Windows.Forms.NumericUpDown();
            this.addFoodButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.addWaterInput = new System.Windows.Forms.NumericUpDown();
            this.addWaterButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveTripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setLogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressDayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.daysToTravelInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFoodInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addWaterInput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination:";
            // 
            // outsetComboBox
            // 
            this.outsetComboBox.FormattingEnabled = true;
            this.outsetComboBox.Location = new System.Drawing.Point(112, 26);
            this.outsetComboBox.Name = "outsetComboBox";
            this.outsetComboBox.Size = new System.Drawing.Size(178, 28);
            this.outsetComboBox.TabIndex = 2;
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.Location = new System.Drawing.Point(112, 84);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(178, 28);
            this.destinationComboBox.TabIndex = 3;
            // 
            // setDestinationButton
            // 
            this.setDestinationButton.Location = new System.Drawing.Point(16, 144);
            this.setDestinationButton.Name = "setDestinationButton";
            this.setDestinationButton.Size = new System.Drawing.Size(150, 30);
            this.setDestinationButton.TabIndex = 4;
            this.setDestinationButton.Text = "Set Destination";
            this.setDestinationButton.UseVisualStyleBackColor = true;
            this.setDestinationButton.Click += new System.EventHandler(this.SetDestination);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pace:";
            // 
            // paceComboBox
            // 
            this.paceComboBox.FormattingEnabled = true;
            this.paceComboBox.Items.AddRange(new object[] {
            "Slow",
            "Normal",
            "Fast"});
            this.paceComboBox.Location = new System.Drawing.Point(317, 84);
            this.paceComboBox.Name = "paceComboBox";
            this.paceComboBox.Size = new System.Drawing.Size(118, 28);
            this.paceComboBox.TabIndex = 6;
            // 
            // setPaceButton
            // 
            this.setPaceButton.Location = new System.Drawing.Point(317, 144);
            this.setPaceButton.Name = "setPaceButton";
            this.setPaceButton.Size = new System.Drawing.Size(118, 30);
            this.setPaceButton.TabIndex = 7;
            this.setPaceButton.Text = "Set Pace";
            this.setPaceButton.UseVisualStyleBackColor = true;
            this.setPaceButton.Click += new System.EventHandler(this.SetPace);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Days To Travel:";
            // 
            // travelDayButton
            // 
            this.travelDayButton.Location = new System.Drawing.Point(469, 82);
            this.travelDayButton.Name = "travelDayButton";
            this.travelDayButton.Size = new System.Drawing.Size(113, 30);
            this.travelDayButton.TabIndex = 10;
            this.travelDayButton.Text = "Travel Day";
            this.travelDayButton.UseVisualStyleBackColor = true;
            this.travelDayButton.Click += new System.EventHandler(this.Travel);
            // 
            // daysToTravelInput
            // 
            this.daysToTravelInput.Location = new System.Drawing.Point(469, 55);
            this.daysToTravelInput.Name = "daysToTravelInput";
            this.daysToTravelInput.Size = new System.Drawing.Size(113, 26);
            this.daysToTravelInput.TabIndex = 11;
            // 
            // addFoodInput
            // 
            this.addFoodInput.Location = new System.Drawing.Point(616, 87);
            this.addFoodInput.Name = "addFoodInput";
            this.addFoodInput.Size = new System.Drawing.Size(113, 26);
            this.addFoodInput.TabIndex = 14;
            // 
            // addFoodButton
            // 
            this.addFoodButton.Location = new System.Drawing.Point(616, 144);
            this.addFoodButton.Name = "addFoodButton";
            this.addFoodButton.Size = new System.Drawing.Size(113, 30);
            this.addFoodButton.TabIndex = 13;
            this.addFoodButton.Text = "Add";
            this.addFoodButton.UseVisualStyleBackColor = true;
            this.addFoodButton.Click += new System.EventHandler(this.AddFood);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Add Food:";
            // 
            // addWaterInput
            // 
            this.addWaterInput.Location = new System.Drawing.Point(739, 87);
            this.addWaterInput.Name = "addWaterInput";
            this.addWaterInput.Size = new System.Drawing.Size(113, 26);
            this.addWaterInput.TabIndex = 17;
            // 
            // addWaterButton
            // 
            this.addWaterButton.Location = new System.Drawing.Point(739, 144);
            this.addWaterButton.Name = "addWaterButton";
            this.addWaterButton.Size = new System.Drawing.Size(113, 30);
            this.addWaterButton.TabIndex = 16;
            this.addWaterButton.Text = "Add";
            this.addWaterButton.UseVisualStyleBackColor = true;
            this.addWaterButton.Click += new System.EventHandler(this.AddWater);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(735, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Add Water:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTripMenuItem,
            this.loadTripMenuItem,
            this.setLogMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveTripMenuItem
            // 
            this.saveTripMenuItem.Name = "saveTripMenuItem";
            this.saveTripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.saveTripMenuItem.Text = "Save Trip";
            this.saveTripMenuItem.Click += new System.EventHandler(this.SaveTrip);
            // 
            // loadTripMenuItem
            // 
            this.loadTripMenuItem.Name = "loadTripMenuItem";
            this.loadTripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.loadTripMenuItem.Text = "Load Trip";
            this.loadTripMenuItem.Click += new System.EventHandler(this.LoadTrip);
            // 
            // setLogMenuItem
            // 
            this.setLogMenuItem.Name = "setLogMenuItem";
            this.setLogMenuItem.Size = new System.Drawing.Size(58, 20);
            this.setLogMenuItem.Text = "Set Log";
            this.setLogMenuItem.Click += new System.EventHandler(this.SetLog);
            // 
            // progressDayButton
            // 
            this.progressDayButton.Location = new System.Drawing.Point(469, 144);
            this.progressDayButton.Name = "progressDayButton";
            this.progressDayButton.Size = new System.Drawing.Size(113, 30);
            this.progressDayButton.TabIndex = 19;
            this.progressDayButton.Text = "Progress Day";
            this.progressDayButton.UseVisualStyleBackColor = true;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 196);
            this.Controls.Add(this.progressDayButton);
            this.Controls.Add(this.addWaterInput);
            this.Controls.Add(this.addWaterButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addFoodInput);
            this.Controls.Add(this.addFoodButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.daysToTravelInput);
            this.Controls.Add(this.travelDayButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.setPaceButton);
            this.Controls.Add(this.paceComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.setDestinationButton);
            this.Controls.Add(this.destinationComboBox);
            this.Controls.Add(this.outsetComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ControlForm";
            this.Text = "ControlForm";
            ((System.ComponentModel.ISupportInitialize)(this.daysToTravelInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFoodInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addWaterInput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox outsetComboBox;
        private System.Windows.Forms.ComboBox destinationComboBox;
        private System.Windows.Forms.Button setDestinationButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox paceComboBox;
        private System.Windows.Forms.Button setPaceButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button travelDayButton;
        private System.Windows.Forms.NumericUpDown daysToTravelInput;
        private System.Windows.Forms.NumericUpDown addFoodInput;
        private System.Windows.Forms.Button addFoodButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown addWaterInput;
        private System.Windows.Forms.Button addWaterButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveTripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setLogMenuItem;
        private System.Windows.Forms.Button progressDayButton;
    }
}