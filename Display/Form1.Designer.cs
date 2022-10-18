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
            ((System.ComponentModel.ISupportInitialize)(this.nudSides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIZI
            // 
            this.cbIZI.AutoSize = true;
            this.cbIZI.Location = new System.Drawing.Point(12, 12);
            this.cbIZI.Name = "cbIZI";
            this.cbIZI.Size = new System.Drawing.Size(133, 21);
            this.cbIZI.TabIndex = 0;
            this.cbIZI.Text = "Is zero indexed?";
            this.cbIZI.UseVisualStyleBackColor = true;
            // 
            // nudSides
            // 
            this.nudSides.Location = new System.Drawing.Point(12, 39);
            this.nudSides.Name = "nudSides";
            this.nudSides.Size = new System.Drawing.Size(133, 22);
            this.nudSides.TabIndex = 1;
            this.nudSides.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // nudSeed
            // 
            this.nudSeed.Location = new System.Drawing.Point(12, 67);
            this.nudSeed.Name = "nudSeed";
            this.nudSeed.Size = new System.Drawing.Size(133, 22);
            this.nudSeed.TabIndex = 2;
            // 
            // lbSides
            // 
            this.lbSides.AutoSize = true;
            this.lbSides.Location = new System.Drawing.Point(151, 41);
            this.lbSides.Name = "lbSides";
            this.lbSides.Size = new System.Drawing.Size(43, 17);
            this.lbSides.TabIndex = 4;
            this.lbSides.Text = "Sides";
            // 
            // lbSeed
            // 
            this.lbSeed.AutoSize = true;
            this.lbSeed.Location = new System.Drawing.Point(151, 69);
            this.lbSeed.Name = "lbSeed";
            this.lbSeed.Size = new System.Drawing.Size(41, 17);
            this.lbSeed.TabIndex = 5;
            this.lbSeed.Text = "Seed";
            // 
            // lbCPS
            // 
            this.lbCPS.AutoSize = true;
            this.lbCPS.Location = new System.Drawing.Point(151, 98);
            this.lbCPS.Name = "lbCPS";
            this.lbCPS.Size = new System.Drawing.Size(155, 17);
            this.lbCPS.TabIndex = 6;
            this.lbCPS.Text = "Chance Per Side (in %)";
            // 
            // tbCPS
            // 
            this.tbCPS.Location = new System.Drawing.Point(12, 95);
            this.tbCPS.Name = "tbCPS";
            this.tbCPS.ReadOnly = true;
            this.tbCPS.Size = new System.Drawing.Size(133, 22);
            this.tbCPS.TabIndex = 7;
            // 
            // bnInstantiate
            // 
            this.bnInstantiate.Location = new System.Drawing.Point(13, 124);
            this.bnInstantiate.Name = "bnInstantiate";
            this.bnInstantiate.Size = new System.Drawing.Size(132, 23);
            this.bnInstantiate.TabIndex = 8;
            this.bnInstantiate.Text = "Instantiate";
            this.bnInstantiate.UseVisualStyleBackColor = true;
            this.bnInstantiate.Click += new System.EventHandler(this.bnInstantiate_Click);
            // 
            // bnRoll
            // 
            this.bnRoll.Location = new System.Drawing.Point(13, 154);
            this.bnRoll.Name = "bnRoll";
            this.bnRoll.Size = new System.Drawing.Size(132, 23);
            this.bnRoll.TabIndex = 9;
            this.bnRoll.Text = "Roll";
            this.bnRoll.UseVisualStyleBackColor = true;
            this.bnRoll.Click += new System.EventHandler(this.bnRoll_Click);
            // 
            // nudResult
            // 
            this.nudResult.Enabled = false;
            this.nudResult.Location = new System.Drawing.Point(12, 293);
            this.nudResult.Name = "nudResult";
            this.nudResult.ReadOnly = true;
            this.nudResult.Size = new System.Drawing.Size(133, 22);
            this.nudResult.TabIndex = 10;
            this.nudResult.ValueChanged += new System.EventHandler(this.ResChange);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(151, 295);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(48, 17);
            this.lbResult.TabIndex = 11;
            this.lbResult.Text = "Result";
            // 
            // tbFac
            // 
            this.tbFac.Location = new System.Drawing.Point(12, 265);
            this.tbFac.Name = "tbFac";
            this.tbFac.Size = new System.Drawing.Size(133, 22);
            this.tbFac.TabIndex = 16;
            this.tbFac.Text = "1";
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(12, 237);
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(133, 22);
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
            this.lbFac.Location = new System.Drawing.Point(151, 268);
            this.lbFac.Name = "lbFac";
            this.lbFac.Size = new System.Drawing.Size(76, 17);
            this.lbFac.TabIndex = 18;
            this.lbFac.Text = "Roll Factor";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(151, 239);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(73, 17);
            this.lbCount.TabIndex = 19;
            this.lbCount.Text = "Roll Count";
            // 
            // tbResSca
            // 
            this.tbResSca.Location = new System.Drawing.Point(12, 321);
            this.tbResSca.Name = "tbResSca";
            this.tbResSca.Size = new System.Drawing.Size(133, 22);
            this.tbResSca.TabIndex = 20;
            this.tbResSca.Text = "1";
            // 
            // lbResSca
            // 
            this.lbResSca.AutoSize = true;
            this.lbResSca.Location = new System.Drawing.Point(151, 324);
            this.lbResSca.Name = "lbResSca";
            this.lbResSca.Size = new System.Drawing.Size(87, 17);
            this.lbResSca.TabIndex = 21;
            this.lbResSca.Text = "Result Scale";
            // 
            // tbScaRes
            // 
            this.tbScaRes.Location = new System.Drawing.Point(12, 349);
            this.tbScaRes.Name = "tbScaRes";
            this.tbScaRes.ReadOnly = true;
            this.tbScaRes.Size = new System.Drawing.Size(133, 22);
            this.tbScaRes.TabIndex = 22;
            this.tbScaRes.TextChanged += new System.EventHandler(this.ScaResChanged);
            // 
            // lbScaRes
            // 
            this.lbScaRes.AutoSize = true;
            this.lbScaRes.Location = new System.Drawing.Point(151, 352);
            this.lbScaRes.Name = "lbScaRes";
            this.lbScaRes.Size = new System.Drawing.Size(95, 17);
            this.lbScaRes.TabIndex = 23;
            this.lbScaRes.Text = "Scaled Result";
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Checked = true;
            this.rbAdd.Location = new System.Drawing.Point(12, 183);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(89, 21);
            this.rbAdd.TabIndex = 24;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add Rolls";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // rbSubstract
            // 
            this.rbSubstract.AutoSize = true;
            this.rbSubstract.Location = new System.Drawing.Point(129, 183);
            this.rbSubstract.Name = "rbSubstract";
            this.rbSubstract.Size = new System.Drawing.Size(124, 21);
            this.rbSubstract.TabIndex = 25;
            this.rbSubstract.Text = "Substract Rolls";
            this.rbSubstract.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Location = new System.Drawing.Point(12, 209);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(111, 21);
            this.rbMultiply.TabIndex = 26;
            this.rbMultiply.Text = "Multiply Rolls";
            this.rbMultiply.UseVisualStyleBackColor = true;
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Location = new System.Drawing.Point(129, 209);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(103, 21);
            this.rbDivide.TabIndex = 27;
            this.rbDivide.Text = "Divide Rolls";
            this.rbDivide.UseVisualStyleBackColor = true;
            // 
            // tbAdditiveModifier
            // 
            this.tbAdditiveModifier.Location = new System.Drawing.Point(12, 377);
            this.tbAdditiveModifier.Name = "tbAdditiveModifier";
            this.tbAdditiveModifier.Size = new System.Drawing.Size(133, 22);
            this.tbAdditiveModifier.TabIndex = 28;
            this.tbAdditiveModifier.Text = "0";
            // 
            // lbAM
            // 
            this.lbAM.AutoSize = true;
            this.lbAM.Location = new System.Drawing.Point(151, 380);
            this.lbAM.Name = "lbAM";
            this.lbAM.Size = new System.Drawing.Size(112, 17);
            this.lbAM.TabIndex = 29;
            this.lbAM.Text = "Additive Modifier";
            // 
            // tbModifiedResult
            // 
            this.tbModifiedResult.Location = new System.Drawing.Point(12, 405);
            this.tbModifiedResult.Name = "tbModifiedResult";
            this.tbModifiedResult.ReadOnly = true;
            this.tbModifiedResult.Size = new System.Drawing.Size(133, 22);
            this.tbModifiedResult.TabIndex = 30;
            // 
            // lbMR
            // 
            this.lbMR.AutoSize = true;
            this.lbMR.Location = new System.Drawing.Point(151, 408);
            this.lbMR.Name = "lbMR";
            this.lbMR.Size = new System.Drawing.Size(105, 17);
            this.lbMR.TabIndex = 31;
            this.lbMR.Text = "Modified Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 439);
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
    }
}

