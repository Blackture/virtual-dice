namespace Display
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbIZI = new System.Windows.Forms.CheckBox();
            this.nudSides = new System.Windows.Forms.NumericUpDown();
            this.nudSeed = new System.Windows.Forms.NumericUpDown();
            this.lbSides = new System.Windows.Forms.Label();
            this.lbSeed = new System.Windows.Forms.Label();
            this.lbCPS = new System.Windows.Forms.Label();
            this.tbCPS = new System.Windows.Forms.TextBox();
            this.bnInstantiate = new System.Windows.Forms.Button();
            this.bnRoll = new System.Windows.Forms.Button();
            this.nudResult = new System.Windows.Forms.NumericUpDown();
            this.lbResult = new System.Windows.Forms.Label();
            this.tbFac = new System.Windows.Forms.TextBox();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.lbFac = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.tbResSca = new System.Windows.Forms.TextBox();
            this.lbResSca = new System.Windows.Forms.Label();
            this.tbScaRes = new System.Windows.Forms.TextBox();
            this.lbScaRes = new System.Windows.Forms.Label();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbSubstract = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.tbAdditiveModifier = new System.Windows.Forms.TextBox();
            this.lbAM = new System.Windows.Forms.Label();
            this.tbModifiedResult = new System.Windows.Forms.TextBox();
            this.lbMR = new System.Windows.Forms.Label();
            this.cbAdvantage = new System.Windows.Forms.CheckBox();
            this.cbDisadvantage = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIZI
            // 
            this.cbIZI.AutoSize = true;
            this.cbIZI.Location = new System.Drawing.Point(9, 10);
            this.cbIZI.Margin = new System.Windows.Forms.Padding(2);
            this.cbIZI.Name = "cbIZI";
            this.cbIZI.Size = new System.Drawing.Size(103, 17);
            this.cbIZI.TabIndex = 0;
            this.cbIZI.Text = "Is zero indexed?";
            this.cbIZI.UseVisualStyleBackColor = true;
            // 
            // nudSides
            // 
            this.nudSides.Location = new System.Drawing.Point(9, 32);
            this.nudSides.Margin = new System.Windows.Forms.Padding(2);
            this.nudSides.Name = "nudSides";
            this.nudSides.Size = new System.Drawing.Size(100, 20);
            this.nudSides.TabIndex = 1;
            this.nudSides.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // nudSeed
            // 
            this.nudSeed.Location = new System.Drawing.Point(9, 54);
            this.nudSeed.Margin = new System.Windows.Forms.Padding(2);
            this.nudSeed.Name = "nudSeed";
            this.nudSeed.Size = new System.Drawing.Size(100, 20);
            this.nudSeed.TabIndex = 2;
            // 
            // lbSides
            // 
            this.lbSides.AutoSize = true;
            this.lbSides.Location = new System.Drawing.Point(113, 33);
            this.lbSides.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSides.Name = "lbSides";
            this.lbSides.Size = new System.Drawing.Size(33, 13);
            this.lbSides.TabIndex = 4;
            this.lbSides.Text = "Sides";
            // 
            // lbSeed
            // 
            this.lbSeed.AutoSize = true;
            this.lbSeed.Location = new System.Drawing.Point(113, 56);
            this.lbSeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSeed.Name = "lbSeed";
            this.lbSeed.Size = new System.Drawing.Size(32, 13);
            this.lbSeed.TabIndex = 5;
            this.lbSeed.Text = "Seed";
            // 
            // lbCPS
            // 
            this.lbCPS.AutoSize = true;
            this.lbCPS.Location = new System.Drawing.Point(113, 80);
            this.lbCPS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCPS.Name = "lbCPS";
            this.lbCPS.Size = new System.Drawing.Size(115, 13);
            this.lbCPS.TabIndex = 6;
            this.lbCPS.Text = "Chance Per Side (in %)";
            // 
            // tbCPS
            // 
            this.tbCPS.Location = new System.Drawing.Point(9, 77);
            this.tbCPS.Margin = new System.Windows.Forms.Padding(2);
            this.tbCPS.Name = "tbCPS";
            this.tbCPS.ReadOnly = true;
            this.tbCPS.Size = new System.Drawing.Size(101, 20);
            this.tbCPS.TabIndex = 7;
            // 
            // bnInstantiate
            // 
            this.bnInstantiate.Location = new System.Drawing.Point(9, 101);
            this.bnInstantiate.Margin = new System.Windows.Forms.Padding(2);
            this.bnInstantiate.Name = "bnInstantiate";
            this.bnInstantiate.Size = new System.Drawing.Size(99, 19);
            this.bnInstantiate.TabIndex = 8;
            this.bnInstantiate.Text = "Instantiate";
            this.bnInstantiate.UseVisualStyleBackColor = true;
            this.bnInstantiate.Click += new System.EventHandler(this.bnInstantiate_Click);
            // 
            // bnRoll
            // 
            this.bnRoll.Location = new System.Drawing.Point(9, 125);
            this.bnRoll.Margin = new System.Windows.Forms.Padding(2);
            this.bnRoll.Name = "bnRoll";
            this.bnRoll.Size = new System.Drawing.Size(99, 19);
            this.bnRoll.TabIndex = 9;
            this.bnRoll.Text = "Roll";
            this.bnRoll.UseVisualStyleBackColor = true;
            this.bnRoll.Click += new System.EventHandler(this.bnRoll_Click);
            // 
            // nudResult
            // 
            this.nudResult.Enabled = false;
            this.nudResult.Location = new System.Drawing.Point(9, 260);
            this.nudResult.Margin = new System.Windows.Forms.Padding(2);
            this.nudResult.Name = "nudResult";
            this.nudResult.ReadOnly = true;
            this.nudResult.Size = new System.Drawing.Size(100, 20);
            this.nudResult.TabIndex = 10;
            this.nudResult.ValueChanged += new System.EventHandler(this.ResChange);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(113, 262);
            this.lbResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(37, 13);
            this.lbResult.TabIndex = 11;
            this.lbResult.Text = "Result";
            // 
            // tbFac
            // 
            this.tbFac.Location = new System.Drawing.Point(9, 237);
            this.tbFac.Margin = new System.Windows.Forms.Padding(2);
            this.tbFac.Name = "tbFac";
            this.tbFac.Size = new System.Drawing.Size(101, 20);
            this.tbFac.TabIndex = 16;
            this.tbFac.Text = "1";
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(9, 215);
            this.nudCount.Margin = new System.Windows.Forms.Padding(2);
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(100, 20);
            this.nudCount.TabIndex = 17;
            this.nudCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbFac
            // 
            this.lbFac.AutoSize = true;
            this.lbFac.Location = new System.Drawing.Point(113, 240);
            this.lbFac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFac.Name = "lbFac";
            this.lbFac.Size = new System.Drawing.Size(58, 13);
            this.lbFac.TabIndex = 18;
            this.lbFac.Text = "Roll Factor";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(113, 216);
            this.lbCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(56, 13);
            this.lbCount.TabIndex = 19;
            this.lbCount.Text = "Roll Count";
            // 
            // tbResSca
            // 
            this.tbResSca.Location = new System.Drawing.Point(9, 283);
            this.tbResSca.Margin = new System.Windows.Forms.Padding(2);
            this.tbResSca.Name = "tbResSca";
            this.tbResSca.Size = new System.Drawing.Size(101, 20);
            this.tbResSca.TabIndex = 20;
            this.tbResSca.Text = "1";
            // 
            // lbResSca
            // 
            this.lbResSca.AutoSize = true;
            this.lbResSca.Location = new System.Drawing.Point(113, 285);
            this.lbResSca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbResSca.Name = "lbResSca";
            this.lbResSca.Size = new System.Drawing.Size(67, 13);
            this.lbResSca.TabIndex = 21;
            this.lbResSca.Text = "Result Scale";
            // 
            // tbScaRes
            // 
            this.tbScaRes.Location = new System.Drawing.Point(9, 306);
            this.tbScaRes.Margin = new System.Windows.Forms.Padding(2);
            this.tbScaRes.Name = "tbScaRes";
            this.tbScaRes.ReadOnly = true;
            this.tbScaRes.Size = new System.Drawing.Size(101, 20);
            this.tbScaRes.TabIndex = 22;
            this.tbScaRes.TextChanged += new System.EventHandler(this.ScaResChanged);
            // 
            // lbScaRes
            // 
            this.lbScaRes.AutoSize = true;
            this.lbScaRes.Location = new System.Drawing.Point(113, 308);
            this.lbScaRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbScaRes.Name = "lbScaRes";
            this.lbScaRes.Size = new System.Drawing.Size(73, 13);
            this.lbScaRes.TabIndex = 23;
            this.lbScaRes.Text = "Scaled Result";
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Checked = true;
            this.rbAdd.Location = new System.Drawing.Point(9, 171);
            this.rbAdd.Margin = new System.Windows.Forms.Padding(2);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(70, 17);
            this.rbAdd.TabIndex = 24;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add Rolls";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // rbSubstract
            // 
            this.rbSubstract.AutoSize = true;
            this.rbSubstract.Location = new System.Drawing.Point(97, 171);
            this.rbSubstract.Margin = new System.Windows.Forms.Padding(2);
            this.rbSubstract.Name = "rbSubstract";
            this.rbSubstract.Size = new System.Drawing.Size(96, 17);
            this.rbSubstract.TabIndex = 25;
            this.rbSubstract.Text = "Substract Rolls";
            this.rbSubstract.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Location = new System.Drawing.Point(9, 192);
            this.rbMultiply.Margin = new System.Windows.Forms.Padding(2);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(86, 17);
            this.rbMultiply.TabIndex = 26;
            this.rbMultiply.Text = "Multiply Rolls";
            this.rbMultiply.UseVisualStyleBackColor = true;
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Location = new System.Drawing.Point(97, 192);
            this.rbDivide.Margin = new System.Windows.Forms.Padding(2);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(81, 17);
            this.rbDivide.TabIndex = 27;
            this.rbDivide.Text = "Divide Rolls";
            this.rbDivide.UseVisualStyleBackColor = true;
            // 
            // tbAdditiveModifier
            // 
            this.tbAdditiveModifier.Location = new System.Drawing.Point(9, 328);
            this.tbAdditiveModifier.Margin = new System.Windows.Forms.Padding(2);
            this.tbAdditiveModifier.Name = "tbAdditiveModifier";
            this.tbAdditiveModifier.Size = new System.Drawing.Size(101, 20);
            this.tbAdditiveModifier.TabIndex = 28;
            this.tbAdditiveModifier.Text = "0";
            // 
            // lbAM
            // 
            this.lbAM.AutoSize = true;
            this.lbAM.Location = new System.Drawing.Point(113, 331);
            this.lbAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAM.Name = "lbAM";
            this.lbAM.Size = new System.Drawing.Size(85, 13);
            this.lbAM.TabIndex = 29;
            this.lbAM.Text = "Additive Modifier";
            // 
            // tbModifiedResult
            // 
            this.tbModifiedResult.Location = new System.Drawing.Point(9, 351);
            this.tbModifiedResult.Margin = new System.Windows.Forms.Padding(2);
            this.tbModifiedResult.Name = "tbModifiedResult";
            this.tbModifiedResult.ReadOnly = true;
            this.tbModifiedResult.Size = new System.Drawing.Size(101, 20);
            this.tbModifiedResult.TabIndex = 30;
            // 
            // lbMR
            // 
            this.lbMR.AutoSize = true;
            this.lbMR.Location = new System.Drawing.Point(113, 354);
            this.lbMR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMR.Name = "lbMR";
            this.lbMR.Size = new System.Drawing.Size(80, 13);
            this.lbMR.TabIndex = 31;
            this.lbMR.Text = "Modified Result";
            // 
            // cbAdvantage
            // 
            this.cbAdvantage.AutoSize = true;
            this.cbAdvantage.Location = new System.Drawing.Point(9, 149);
            this.cbAdvantage.Name = "cbAdvantage";
            this.cbAdvantage.Size = new System.Drawing.Size(78, 17);
            this.cbAdvantage.TabIndex = 32;
            this.cbAdvantage.Text = "Advantage";
            this.cbAdvantage.UseVisualStyleBackColor = true;
            this.cbAdvantage.Click += new System.EventHandler(this.cbAdvantage_Clicked);
            // 
            // cbDisadvantage
            // 
            this.cbDisadvantage.AutoSize = true;
            this.cbDisadvantage.Location = new System.Drawing.Point(97, 149);
            this.cbDisadvantage.Name = "cbDisadvantage";
            this.cbDisadvantage.Size = new System.Drawing.Size(92, 17);
            this.cbDisadvantage.TabIndex = 33;
            this.cbDisadvantage.Text = "Disadvantage";
            this.cbDisadvantage.UseVisualStyleBackColor = true;
            this.cbDisadvantage.Click += new System.EventHandler(this.cbDisadvantage_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 428);
            this.Controls.Add(this.cbDisadvantage);
            this.Controls.Add(this.cbAdvantage);
            this.Controls.Add(this.lbMR);
            this.Controls.Add(this.tbModifiedResult);
            this.Controls.Add(this.lbAM);
            this.Controls.Add(this.tbAdditiveModifier);
            this.Controls.Add(this.rbDivide);
            this.Controls.Add(this.rbMultiply);
            this.Controls.Add(this.rbSubstract);
            this.Controls.Add(this.rbAdd);
            this.Controls.Add(this.lbScaRes);
            this.Controls.Add(this.tbScaRes);
            this.Controls.Add(this.lbResSca);
            this.Controls.Add(this.tbResSca);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbFac);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.tbFac);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.nudResult);
            this.Controls.Add(this.bnRoll);
            this.Controls.Add(this.bnInstantiate);
            this.Controls.Add(this.tbCPS);
            this.Controls.Add(this.lbCPS);
            this.Controls.Add(this.lbSeed);
            this.Controls.Add(this.lbSides);
            this.Controls.Add(this.nudSeed);
            this.Controls.Add(this.nudSides);
            this.Controls.Add(this.cbIZI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Virtual Dice";
            ((System.ComponentModel.ISupportInitialize)(this.nudSides)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbIZI;
        private System.Windows.Forms.NumericUpDown nudSides;
        private System.Windows.Forms.NumericUpDown nudSeed;
        private System.Windows.Forms.Label lbSides;
        private System.Windows.Forms.Label lbSeed;
        private System.Windows.Forms.Label lbCPS;
        private System.Windows.Forms.TextBox tbCPS;
        private System.Windows.Forms.Button bnInstantiate;
        private System.Windows.Forms.Button bnRoll;
        private System.Windows.Forms.NumericUpDown nudResult;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox tbFac;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label lbFac;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.TextBox tbResSca;
        private System.Windows.Forms.Label lbResSca;
        private System.Windows.Forms.TextBox tbScaRes;
        private System.Windows.Forms.Label lbScaRes;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbSubstract;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.TextBox tbAdditiveModifier;
        private System.Windows.Forms.Label lbAM;
        private System.Windows.Forms.TextBox tbModifiedResult;
        private System.Windows.Forms.Label lbMR;
        private System.Windows.Forms.CheckBox cbAdvantage;
        private System.Windows.Forms.CheckBox cbDisadvantage;
    }
}

