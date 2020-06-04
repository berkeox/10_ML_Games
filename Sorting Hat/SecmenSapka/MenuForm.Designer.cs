namespace SecmenSapka
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.Test_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Train_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // Test_Btn
            // 
            this.Test_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Test_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Test_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Test_Btn.BorderRadius = 0;
            this.Test_Btn.ButtonText = "TEST";
            this.Test_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Test_Btn.DisabledColor = System.Drawing.Color.Transparent;
            this.Test_Btn.ForeColor = System.Drawing.Color.Black;
            this.Test_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Test_Btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Test_Btn.Iconimage")));
            this.Test_Btn.Iconimage_right = null;
            this.Test_Btn.Iconimage_right_Selected = null;
            this.Test_Btn.Iconimage_Selected = null;
            this.Test_Btn.IconMarginLeft = 0;
            this.Test_Btn.IconMarginRight = 0;
            this.Test_Btn.IconRightVisible = true;
            this.Test_Btn.IconRightZoom = 0D;
            this.Test_Btn.IconVisible = true;
            this.Test_Btn.IconZoom = 90D;
            this.Test_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Test_Btn.IsTab = false;
            this.Test_Btn.Location = new System.Drawing.Point(210, 294);
            this.Test_Btn.Name = "Test_Btn";
            this.Test_Btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Test_Btn.OnHovercolor = System.Drawing.Color.Khaki;
            this.Test_Btn.OnHoverTextColor = System.Drawing.Color.Black;
            this.Test_Btn.selected = false;
            this.Test_Btn.Size = new System.Drawing.Size(133, 48);
            this.Test_Btn.TabIndex = 0;
            this.Test_Btn.Text = "TEST";
            this.Test_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Test_Btn.Textcolor = System.Drawing.Color.Plum;
            this.Test_Btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test_Btn.Click += new System.EventHandler(this.Test_Btn_Click);
            // 
            // Train_Btn
            // 
            this.Train_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Train_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Train_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Train_Btn.BorderRadius = 0;
            this.Train_Btn.ButtonText = "TRAIN";
            this.Train_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Train_Btn.DisabledColor = System.Drawing.Color.Transparent;
            this.Train_Btn.ForeColor = System.Drawing.Color.Black;
            this.Train_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Train_Btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Train_Btn.Iconimage")));
            this.Train_Btn.Iconimage_right = null;
            this.Train_Btn.Iconimage_right_Selected = null;
            this.Train_Btn.Iconimage_Selected = null;
            this.Train_Btn.IconMarginLeft = 0;
            this.Train_Btn.IconMarginRight = 0;
            this.Train_Btn.IconRightVisible = true;
            this.Train_Btn.IconRightZoom = 0D;
            this.Train_Btn.IconVisible = true;
            this.Train_Btn.IconZoom = 90D;
            this.Train_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Train_Btn.IsTab = false;
            this.Train_Btn.Location = new System.Drawing.Point(12, 294);
            this.Train_Btn.Name = "Train_Btn";
            this.Train_Btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Train_Btn.OnHovercolor = System.Drawing.Color.Khaki;
            this.Train_Btn.OnHoverTextColor = System.Drawing.Color.Black;
            this.Train_Btn.selected = false;
            this.Train_Btn.Size = new System.Drawing.Size(133, 48);
            this.Train_Btn.TabIndex = 1;
            this.Train_Btn.Text = "TRAIN";
            this.Train_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Train_Btn.Textcolor = System.Drawing.Color.Plum;
            this.Train_Btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Train_Btn.Click += new System.EventHandler(this.Train_Btn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecmenSapka.Properties.Resources.hogwarts_studio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 433);
            this.Controls.Add(this.Train_Btn);
            this.Controls.Add(this.Test_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton Test_Btn;
        private Bunifu.Framework.UI.BunifuFlatButton Train_Btn;
    }
}