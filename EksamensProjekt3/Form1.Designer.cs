
namespace EksamensProjekt3
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
            this.components = new System.ComponentModel.Container();
            this.arrayOfStringBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UdenforFugtLabel = new System.Windows.Forms.Label();
            this.UdenforTempLabel = new System.Windows.Forms.Label();
            this.LagerFugtLabel = new System.Windows.Forms.Label();
            this.LagerTempLabel = new System.Windows.Forms.Label();
            this.UdenforLabel = new System.Windows.Forms.Label();
            this.UdenforFugt = new System.Windows.Forms.Label();
            this.UdenforTemp = new System.Windows.Forms.Label();
            this.LagerLabel = new System.Windows.Forms.Label();
            this.LagerFugt = new System.Windows.Forms.Label();
            this.LagerTemp = new System.Windows.Forms.Label();
            this.Lagerstatus = new System.Windows.Forms.GroupBox();
            this.VarerMaksGroup = new System.Windows.Forms.GroupBox();
            this.SolgtIDagGroup = new System.Windows.Forms.GroupBox();
            this.VarerMinGroup = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.USATime = new System.Windows.Forms.Label();
            this.USALabel = new System.Windows.Forms.Label();
            this.ChinaTime = new System.Windows.Forms.Label();
            this.ChinaLabel = new System.Windows.Forms.Label();
            this.KøbenhavnTime = new System.Windows.Forms.Label();
            this.KøbenhavnLabel = new System.Windows.Forms.Label();
            this.stockItemsMostSoldResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.arrayOfStringBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Lagerstatus.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemsMostSoldResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // arrayOfStringBindingSource
            // 
            this.arrayOfStringBindingSource.DataSource = typeof(string);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UdenforFugtLabel);
            this.groupBox1.Controls.Add(this.UdenforTempLabel);
            this.groupBox1.Controls.Add(this.LagerFugtLabel);
            this.groupBox1.Controls.Add(this.LagerTempLabel);
            this.groupBox1.Controls.Add(this.UdenforLabel);
            this.groupBox1.Controls.Add(this.UdenforFugt);
            this.groupBox1.Controls.Add(this.UdenforTemp);
            this.groupBox1.Controls.Add(this.LagerLabel);
            this.groupBox1.Controls.Add(this.LagerFugt);
            this.groupBox1.Controls.Add(this.LagerTemp);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperatur og fugtighed ";
            // 
            // UdenforFugtLabel
            // 
            this.UdenforFugtLabel.AutoSize = true;
            this.UdenforFugtLabel.Location = new System.Drawing.Point(41, 150);
            this.UdenforFugtLabel.Name = "UdenforFugtLabel";
            this.UdenforFugtLabel.Size = new System.Drawing.Size(37, 16);
            this.UdenforFugtLabel.TabIndex = 9;
            this.UdenforFugtLabel.Text = "Fugt:";
            // 
            // UdenforTempLabel
            // 
            this.UdenforTempLabel.AutoSize = true;
            this.UdenforTempLabel.Location = new System.Drawing.Point(40, 137);
            this.UdenforTempLabel.Name = "UdenforTempLabel";
            this.UdenforTempLabel.Size = new System.Drawing.Size(47, 16);
            this.UdenforTempLabel.TabIndex = 8;
            this.UdenforTempLabel.Text = "Temp:";
            // 
            // LagerFugtLabel
            // 
            this.LagerFugtLabel.AutoSize = true;
            this.LagerFugtLabel.Location = new System.Drawing.Point(41, 75);
            this.LagerFugtLabel.Name = "LagerFugtLabel";
            this.LagerFugtLabel.Size = new System.Drawing.Size(37, 16);
            this.LagerFugtLabel.TabIndex = 7;
            this.LagerFugtLabel.Text = "Fugt:";
            // 
            // LagerTempLabel
            // 
            this.LagerTempLabel.AutoSize = true;
            this.LagerTempLabel.Location = new System.Drawing.Point(40, 62);
            this.LagerTempLabel.Name = "LagerTempLabel";
            this.LagerTempLabel.Size = new System.Drawing.Size(47, 16);
            this.LagerTempLabel.TabIndex = 6;
            this.LagerTempLabel.Text = "Temp:";
            // 
            // UdenforLabel
            // 
            this.UdenforLabel.AutoSize = true;
            this.UdenforLabel.Location = new System.Drawing.Point(28, 118);
            this.UdenforLabel.Name = "UdenforLabel";
            this.UdenforLabel.Size = new System.Drawing.Size(59, 16);
            this.UdenforLabel.TabIndex = 5;
            this.UdenforLabel.Text = "Udenfor:";
            // 
            // UdenforFugt
            // 
            this.UdenforFugt.AutoSize = true;
            this.UdenforFugt.Location = new System.Drawing.Point(86, 150);
            this.UdenforFugt.Name = "UdenforFugt";
            this.UdenforFugt.Size = new System.Drawing.Size(44, 16);
            this.UdenforFugt.TabIndex = 4;
            this.UdenforFugt.Text = "0,00%";
            // 
            // UdenforTemp
            // 
            this.UdenforTemp.AutoSize = true;
            this.UdenforTemp.Location = new System.Drawing.Point(86, 137);
            this.UdenforTemp.Name = "UdenforTemp";
            this.UdenforTemp.Size = new System.Drawing.Size(45, 16);
            this.UdenforTemp.TabIndex = 3;
            this.UdenforTemp.Text = "0,00°C";
            // 
            // LagerLabel
            // 
            this.LagerLabel.AutoSize = true;
            this.LagerLabel.Location = new System.Drawing.Point(28, 46);
            this.LagerLabel.Name = "LagerLabel";
            this.LagerLabel.Size = new System.Drawing.Size(46, 16);
            this.LagerLabel.TabIndex = 2;
            this.LagerLabel.Text = "Lager:";
            // 
            // LagerFugt
            // 
            this.LagerFugt.AutoSize = true;
            this.LagerFugt.Location = new System.Drawing.Point(85, 75);
            this.LagerFugt.Name = "LagerFugt";
            this.LagerFugt.Size = new System.Drawing.Size(44, 16);
            this.LagerFugt.TabIndex = 1;
            this.LagerFugt.Text = "0,00%";
            // 
            // LagerTemp
            // 
            this.LagerTemp.AutoSize = true;
            this.LagerTemp.Location = new System.Drawing.Point(85, 62);
            this.LagerTemp.Name = "LagerTemp";
            this.LagerTemp.Size = new System.Drawing.Size(45, 16);
            this.LagerTemp.TabIndex = 0;
            this.LagerTemp.Text = "0,00°C";
            // 
            // Lagerstatus
            // 
            this.Lagerstatus.Controls.Add(this.VarerMaksGroup);
            this.Lagerstatus.Controls.Add(this.SolgtIDagGroup);
            this.Lagerstatus.Controls.Add(this.VarerMinGroup);
            this.Lagerstatus.Location = new System.Drawing.Point(386, 12);
            this.Lagerstatus.Name = "Lagerstatus";
            this.Lagerstatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lagerstatus.Size = new System.Drawing.Size(504, 426);
            this.Lagerstatus.TabIndex = 2;
            this.Lagerstatus.TabStop = false;
            this.Lagerstatus.Text = "Lagerstatus";
            // 
            // VarerMaksGroup
            // 
            this.VarerMaksGroup.Location = new System.Drawing.Point(6, 159);
            this.VarerMaksGroup.Name = "VarerMaksGroup";
            this.VarerMaksGroup.Size = new System.Drawing.Size(492, 120);
            this.VarerMaksGroup.TabIndex = 16;
            this.VarerMaksGroup.TabStop = false;
            this.VarerMaksGroup.Text = "Varer over maksimum:";
            // 
            // SolgtIDagGroup
            // 
            this.SolgtIDagGroup.Location = new System.Drawing.Point(6, 295);
            this.SolgtIDagGroup.Name = "SolgtIDagGroup";
            this.SolgtIDagGroup.Size = new System.Drawing.Size(492, 120);
            this.SolgtIDagGroup.TabIndex = 16;
            this.SolgtIDagGroup.TabStop = false;
            this.SolgtIDagGroup.Text = "Mest solg i dag:";
            // 
            // VarerMinGroup
            // 
            this.VarerMinGroup.Location = new System.Drawing.Point(6, 21);
            this.VarerMinGroup.Name = "VarerMinGroup";
            this.VarerMinGroup.Size = new System.Drawing.Size(492, 120);
            this.VarerMinGroup.TabIndex = 15;
            this.VarerMinGroup.TabStop = false;
            this.VarerMinGroup.Text = "Varer under minimum:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.USATime);
            this.groupBox3.Controls.Add(this.USALabel);
            this.groupBox3.Controls.Add(this.ChinaTime);
            this.groupBox3.Controls.Add(this.ChinaLabel);
            this.groupBox3.Controls.Add(this.KøbenhavnTime);
            this.groupBox3.Controls.Add(this.KøbenhavnLabel);
            this.groupBox3.Location = new System.Drawing.Point(12, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 215);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dato / tid";
            // 
            // USATime
            // 
            this.USATime.AutoSize = true;
            this.USATime.Location = new System.Drawing.Point(43, 158);
            this.USATime.Name = "USATime";
            this.USATime.Size = new System.Drawing.Size(32, 16);
            this.USATime.TabIndex = 7;
            this.USATime.Text = "0:00";
            // 
            // USALabel
            // 
            this.USALabel.AutoSize = true;
            this.USALabel.Location = new System.Drawing.Point(28, 145);
            this.USALabel.Name = "USALabel";
            this.USALabel.Size = new System.Drawing.Size(39, 16);
            this.USALabel.TabIndex = 6;
            this.USALabel.Text = "USA:";
            // 
            // ChinaTime
            // 
            this.ChinaTime.AutoSize = true;
            this.ChinaTime.Location = new System.Drawing.Point(43, 98);
            this.ChinaTime.Name = "ChinaTime";
            this.ChinaTime.Size = new System.Drawing.Size(32, 16);
            this.ChinaTime.TabIndex = 5;
            this.ChinaTime.Text = "0:00";
            // 
            // ChinaLabel
            // 
            this.ChinaLabel.AutoSize = true;
            this.ChinaLabel.Location = new System.Drawing.Point(28, 85);
            this.ChinaLabel.Name = "ChinaLabel";
            this.ChinaLabel.Size = new System.Drawing.Size(45, 16);
            this.ChinaLabel.TabIndex = 4;
            this.ChinaLabel.Text = "China:";
            // 
            // KøbenhavnTime
            // 
            this.KøbenhavnTime.AutoSize = true;
            this.KøbenhavnTime.Location = new System.Drawing.Point(43, 50);
            this.KøbenhavnTime.Name = "KøbenhavnTime";
            this.KøbenhavnTime.Size = new System.Drawing.Size(32, 16);
            this.KøbenhavnTime.TabIndex = 3;
            this.KøbenhavnTime.Text = "0:00";
            // 
            // KøbenhavnLabel
            // 
            this.KøbenhavnLabel.AutoSize = true;
            this.KøbenhavnLabel.Location = new System.Drawing.Point(28, 37);
            this.KøbenhavnLabel.Name = "KøbenhavnLabel";
            this.KøbenhavnLabel.Size = new System.Drawing.Size(79, 16);
            this.KøbenhavnLabel.TabIndex = 2;
            this.KøbenhavnLabel.Text = "København:";
            // 
            // stockItemsMostSoldResponseBindingSource
            // 
            this.stockItemsMostSoldResponseBindingSource.DataSource = typeof(EksamensProjekt3.Monitor.StockItemsMostSoldResponse);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Lagerstatus);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Lager overvågnings system";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.arrayOfStringBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Lagerstatus.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemsMostSoldResponseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource arrayOfStringBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LagerLabel;
        private System.Windows.Forms.Label LagerFugt;
        private System.Windows.Forms.Label LagerTemp;
        private System.Windows.Forms.GroupBox Lagerstatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label UdenforLabel;
        private System.Windows.Forms.Label UdenforFugt;
        private System.Windows.Forms.Label UdenforTemp;
        private System.Windows.Forms.Label USATime;
        private System.Windows.Forms.Label USALabel;
        private System.Windows.Forms.Label ChinaTime;
        private System.Windows.Forms.Label ChinaLabel;
        private System.Windows.Forms.Label KøbenhavnTime;
        private System.Windows.Forms.Label KøbenhavnLabel;
        private System.Windows.Forms.Label LagerFugtLabel;
        private System.Windows.Forms.Label LagerTempLabel;
        private System.Windows.Forms.Label UdenforFugtLabel;
        private System.Windows.Forms.Label UdenforTempLabel;
        private System.Windows.Forms.BindingSource stockItemsMostSoldResponseBindingSource;
        private System.Windows.Forms.GroupBox VarerMaksGroup;
        private System.Windows.Forms.GroupBox SolgtIDagGroup;
        private System.Windows.Forms.GroupBox VarerMinGroup;
    }
}

