namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.doubleTrackBar1 = new DoubleTrackBarControl.DoubleTrackBar();
            this.SuspendLayout();
            // 
            // doubleTrackBar1
            // 
            this.doubleTrackBar1.Location = new System.Drawing.Point(54, 79);
            this.doubleTrackBar1.Maximum = 10;
            this.doubleTrackBar1.Minimum = 0;
            this.doubleTrackBar1.Name = "doubleTrackBar1";
            this.doubleTrackBar1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.doubleTrackBar1.Size = new System.Drawing.Size(391, 149);
            this.doubleTrackBar1.SmallChange = 1;
            this.doubleTrackBar1.TabIndex = 0;
            this.doubleTrackBar1.Text = "doubleTrackBar1";
            this.doubleTrackBar1.ValueLeft = 0;
            this.doubleTrackBar1.ValueRight = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 441);
            this.Controls.Add(this.doubleTrackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleTrackBarControl.DoubleTrackBar doubleTrackBar1;


    }
}

