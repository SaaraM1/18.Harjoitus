namespace _18.Harjoitus
{
    partial class AvainhenkilotForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.oppilaitosCB = new System.Windows.Forms.ComboBox();
            this.vastuuhloCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OsoiteLB = new System.Windows.Forms.Label();
            this.PostinroLB = new System.Windows.Forms.Label();
            this.PostitoimipaikkaLB = new System.Windows.Forms.Label();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.PuhLB = new System.Windows.Forms.Label();
            this.SahkopostiLB = new System.Windows.Forms.Label();
            this.OsastoLB = new System.Windows.Forms.Label();
            this.TitteliLB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valitse oppilaitos";
            // 
            // oppilaitosCB
            // 
            this.oppilaitosCB.FormattingEnabled = true;
            this.oppilaitosCB.Location = new System.Drawing.Point(80, 163);
            this.oppilaitosCB.Name = "oppilaitosCB";
            this.oppilaitosCB.Size = new System.Drawing.Size(182, 33);
            this.oppilaitosCB.TabIndex = 1;
            this.oppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.oppilaitosCB_SelectedIndexChanged);
            // 
            // vastuuhloCB
            // 
            this.vastuuhloCB.FormattingEnabled = true;
            this.vastuuhloCB.Location = new System.Drawing.Point(368, 167);
            this.vastuuhloCB.Name = "vastuuhloCB";
            this.vastuuhloCB.Size = new System.Drawing.Size(182, 33);
            this.vastuuhloCB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valitse vastuuhenkilö";
            // 
            // OsoiteLB
            // 
            this.OsoiteLB.AutoSize = true;
            this.OsoiteLB.Location = new System.Drawing.Point(80, 216);
            this.OsoiteLB.Name = "OsoiteLB";
            this.OsoiteLB.Size = new System.Drawing.Size(64, 25);
            this.OsoiteLB.TabIndex = 4;
            this.OsoiteLB.Text = "Osoite";
            // 
            // PostinroLB
            // 
            this.PostinroLB.AutoSize = true;
            this.PostinroLB.Location = new System.Drawing.Point(80, 261);
            this.PostinroLB.Name = "PostinroLB";
            this.PostinroLB.Size = new System.Drawing.Size(112, 25);
            this.PostinroLB.TabIndex = 5;
            this.PostinroLB.Text = "Postinumero";
            // 
            // PostitoimipaikkaLB
            // 
            this.PostitoimipaikkaLB.AutoSize = true;
            this.PostitoimipaikkaLB.Location = new System.Drawing.Point(80, 306);
            this.PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            this.PostitoimipaikkaLB.Size = new System.Drawing.Size(142, 25);
            this.PostitoimipaikkaLB.TabIndex = 6;
            this.PostitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Location = new System.Drawing.Point(80, 351);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(69, 25);
            this.PuhelinLB.TabIndex = 7;
            this.PuhelinLB.Text = "Puhelin";
            // 
            // PuhLB
            // 
            this.PuhLB.AutoSize = true;
            this.PuhLB.Location = new System.Drawing.Point(368, 351);
            this.PuhLB.Name = "PuhLB";
            this.PuhLB.Size = new System.Drawing.Size(69, 25);
            this.PuhLB.TabIndex = 11;
            this.PuhLB.Text = "Puhelin";
            // 
            // SahkopostiLB
            // 
            this.SahkopostiLB.AutoSize = true;
            this.SahkopostiLB.Location = new System.Drawing.Point(368, 306);
            this.SahkopostiLB.Name = "SahkopostiLB";
            this.SahkopostiLB.Size = new System.Drawing.Size(101, 25);
            this.SahkopostiLB.TabIndex = 10;
            this.SahkopostiLB.Text = "Sähköposti";
            // 
            // OsastoLB
            // 
            this.OsastoLB.AutoSize = true;
            this.OsastoLB.Location = new System.Drawing.Point(368, 261);
            this.OsastoLB.Name = "OsastoLB";
            this.OsastoLB.Size = new System.Drawing.Size(68, 25);
            this.OsastoLB.TabIndex = 9;
            this.OsastoLB.Text = "Osasto";
            // 
            // TitteliLB
            // 
            this.TitteliLB.AutoSize = true;
            this.TitteliLB.Location = new System.Drawing.Point(368, 216);
            this.TitteliLB.Name = "TitteliLB";
            this.TitteliLB.Size = new System.Drawing.Size(54, 25);
            this.TitteliLB.TabIndex = 8;
            this.TitteliLB.Text = "Titteli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(60, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 38);
            this.label5.TabIndex = 12;
            this.label5.Text = "Oppilaitosten vastuuhenkilöt";
            // 
            // AvainhenkilotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 438);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PuhLB);
            this.Controls.Add(this.SahkopostiLB);
            this.Controls.Add(this.OsastoLB);
            this.Controls.Add(this.TitteliLB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.PostitoimipaikkaLB);
            this.Controls.Add(this.PostinroLB);
            this.Controls.Add(this.OsoiteLB);
            this.Controls.Add(this.vastuuhloCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oppilaitosCB);
            this.Controls.Add(this.label1);
            this.Name = "AvainhenkilotForm";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.AvainHenkilotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox oppilaitosCB;
        private ComboBox vastuuhloCB;
        private Label label4;
        private Label OsoiteLB;
        private Label PostinroLB;
        private Label PostitoimipaikkaLB;
        private Label PuhelinLB;
        private Label PuhLB;
        private Label SahkopostiLB;
        private Label OsastoLB;
        private Label TitteliLB;
        private Label label5;
    }
}