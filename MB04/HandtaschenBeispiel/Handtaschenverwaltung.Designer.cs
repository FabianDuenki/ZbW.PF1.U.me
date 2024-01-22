namespace MB04.HandtaschenBeispiel
{
    partial class Handtaschenverwaltung
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
            BtnAdd = new Button();
            LblName = new Label();
            TxtName = new TextBox();
            LblPreis = new Label();
            NuDPrice = new NumericUpDown();
            TxtOutput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)NuDPrice).BeginInit();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(188, 96);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Hinzufügen";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(21, 22);
            LblName.Name = "LblName";
            LblName.Size = new Size(39, 15);
            LblName.TabIndex = 1;
            LblName.Text = "Name";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(79, 19);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(184, 23);
            TxtName.TabIndex = 2;
            // 
            // LblPreis
            // 
            LblPreis.AutoSize = true;
            LblPreis.Location = new Point(21, 51);
            LblPreis.Name = "LblPreis";
            LblPreis.Size = new Size(32, 15);
            LblPreis.TabIndex = 3;
            LblPreis.Text = "Preis";
            // 
            // NuDPrice
            // 
            NuDPrice.Location = new Point(78, 54);
            NuDPrice.Name = "NuDPrice";
            NuDPrice.Size = new Size(185, 23);
            NuDPrice.TabIndex = 4;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(21, 210);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.Size = new Size(242, 225);
            TxtOutput.TabIndex = 5;
            // 
            // Handtaschenverwaltung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 496);
            Controls.Add(TxtOutput);
            Controls.Add(NuDPrice);
            Controls.Add(LblPreis);
            Controls.Add(TxtName);
            Controls.Add(LblName);
            Controls.Add(BtnAdd);
            Name = "Handtaschenverwaltung";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Handtaschenverwaltung";
            ((System.ComponentModel.ISupportInitialize)NuDPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdd;
        private Label LblName;
        private TextBox TxtName;
        private Label LblPreis;
        private NumericUpDown NuDPrice;
        private TextBox TxtOutput;
    }
}