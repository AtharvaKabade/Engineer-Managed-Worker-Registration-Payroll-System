namespace miniproject1
{
    partial class workDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workDetail));
            this.Worker = new System.Windows.Forms.Button();
            this.Centring = new System.Windows.Forms.Button();
            this.Engineer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Worker
            // 
            this.Worker.BackColor = System.Drawing.Color.PeachPuff;
            this.Worker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Worker.Location = new System.Drawing.Point(189, 116);
            this.Worker.Name = "Worker";
            this.Worker.Size = new System.Drawing.Size(84, 40);
            this.Worker.TabIndex = 20;
            this.Worker.Text = "Worker";
            this.Worker.UseVisualStyleBackColor = false;
            this.Worker.Click += new System.EventHandler(this.Worker_Click);
            // 
            // Centring
            // 
            this.Centring.BackColor = System.Drawing.Color.PeachPuff;
            this.Centring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Centring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Centring.Location = new System.Drawing.Point(96, 116);
            this.Centring.Name = "Centring";
            this.Centring.Size = new System.Drawing.Size(87, 40);
            this.Centring.TabIndex = 19;
            this.Centring.Text = "Centring";
            this.Centring.UseVisualStyleBackColor = false;
            this.Centring.Click += new System.EventHandler(this.Centring_Click);
            // 
            // Engineer
            // 
            this.Engineer.BackColor = System.Drawing.Color.PeachPuff;
            this.Engineer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Engineer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Engineer.Location = new System.Drawing.Point(-1, 116);
            this.Engineer.Name = "Engineer";
            this.Engineer.Size = new System.Drawing.Size(91, 40);
            this.Engineer.TabIndex = 18;
            this.Engineer.Text = "Engineer";
            this.Engineer.UseVisualStyleBackColor = false;
            this.Engineer.Click += new System.EventHandler(this.Engineer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 55);
            this.label1.TabIndex = 21;
            this.label1.Text = "Work Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 248);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(749, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 52);
            this.button1.TabIndex = 23;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(361, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 40);
            this.button2.TabIndex = 24;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // workDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Worker);
            this.Controls.Add(this.Centring);
            this.Controls.Add(this.Engineer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "workDetail";
            this.Text = "workDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Worker;
        private System.Windows.Forms.Button Centring;
        private System.Windows.Forms.Button Engineer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}