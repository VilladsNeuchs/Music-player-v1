namespace music_player_W;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        button5 = new System.Windows.Forms.Button();
        button6 = new System.Windows.Forms.Button();
        progressBar1 = new System.Windows.Forms.ProgressBar();
        labelTime = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(153, 326);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(89, 23);
        button1.TabIndex = 0;
        button1.Text = "TogglePause";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(248, 325);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(42, 23);
        button2.TabIndex = 1;
        button2.Text = "next";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(88, 325);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(59, 23);
        button3.TabIndex = 2;
        button3.Text = "priviest";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(42, 325);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(40, 23);
        button4.TabIndex = 3;
        button4.Text = "-15";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.Location = new System.Drawing.Point(296, 325);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(40, 23);
        button5.TabIndex = 4;
        button5.Text = "+15";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button6
        // 
        button6.Location = new System.Drawing.Point(333, 3);
        button6.Name = "button6";
        button6.Size = new System.Drawing.Size(48, 23);
        button6.TabIndex = 5;
        button6.Text = "mode";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // progressBar1
        // 
        progressBar1.Location = new System.Drawing.Point(33, 309);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new System.Drawing.Size(313, 10);
        progressBar1.TabIndex = 6;
        // 
        // labelTime
        // 
        labelTime.Location = new System.Drawing.Point(251, 7);
        labelTime.Name = "labelTime";
        labelTime.Size = new System.Drawing.Size(76, 19);
        labelTime.TabIndex = 7;
        labelTime.Text = "labelTime";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(384, 361);
        Controls.Add(labelTime);
        Controls.Add(progressBar1);
        Controls.Add(button6);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        MaximumSize = new System.Drawing.Size(400, 400);
        MinimumSize = new System.Drawing.Size(400, 400);
        Text = "IDKMusic";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label labelTime;

    private System.Windows.Forms.ProgressBar progressBar1;

    private System.Windows.Forms.Button button6;

    private System.Windows.Forms.Button button5;

    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    #endregion
}