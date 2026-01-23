namespace Shop.TelaFuncionarios
{
    partial class InformacaoContatocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacaoContatocs));
            PicBContato = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicBContato).BeginInit();
            SuspendLayout();
            // 
            // PicBContato
            // 
            PicBContato.BackgroundImage = (Image)resources.GetObject("PicBContato.BackgroundImage");
            PicBContato.BackgroundImageLayout = ImageLayout.Stretch;
            PicBContato.BorderStyle = BorderStyle.FixedSingle;
            PicBContato.Location = new Point(1, -1);
            PicBContato.MaximumSize = new Size(851, 246);
            PicBContato.MinimumSize = new Size(851, 246);
            PicBContato.Name = "PicBContato";
            PicBContato.Size = new Size(851, 246);
            PicBContato.TabIndex = 0;
            PicBContato.TabStop = false;
            // 
            // InformacaoContatocs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 244);
            Controls.Add(PicBContato);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(870, 291);
            MinimizeBox = false;
            MinimumSize = new Size(870, 291);
            Name = "InformacaoContatocs";
            Text = "InformacaoContatocs";
            ((System.ComponentModel.ISupportInitialize)PicBContato).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicBContato;
    }
}