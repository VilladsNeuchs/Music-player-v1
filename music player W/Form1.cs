using System;
using System.Drawing;
using System.Windows.Forms;

namespace music_player_W
{
public partial class Form1 : Form
{
private bool isDarkMode = true;
private MusicPlayer player = new MusicPlayer();
private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

    public Form1()
    {
        InitializeComponent();
        player.Init();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        
        ApplyTheme(this, isDarkMode);

        timer.Interval = 100;
        timer.Tick += Timer_Tick;
        timer.Start();
        labelTime.Text = "00:00 / 00:00";
    }

    //  BUTTONS 

    private void button1_Click(object sender, EventArgs e)
    {
        player.TogglePause();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        player.Next();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        player.Previous();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        player.backward15();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        player.forward15();
    }

    private void button6_Click(object sender, EventArgs e)
    {
        isDarkMode = !isDarkMode;
        ApplyTheme(this, isDarkMode);

        
        Button btn = sender as Button;
        if (btn != null)
            btn.Text = isDarkMode ? "Light Mode" : "Dark Mode";
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        TimeSpan current = player.GetCurrentTime();
        TimeSpan total = player.GetTotalTime();
        
        if(total.TotalSeconds <=0)
            return;
        progressBar1.Maximum = (int)total.TotalSeconds;
        progressBar1.Value = Math.Min((int)current.TotalSeconds, progressBar1.Maximum);
        
        labelTime.Text = $"{current:mm\\:ss} / {total:mm\\:ss}";
    
    }
    

    void ApplyTheme(Control parent, bool darkMode)
    {
        Color backColor = darkMode ? Color.FromArgb(32, 32, 32) : SystemColors.Control;
        Color foreColor = darkMode ? Color.White : Color.Black;

        parent.BackColor = backColor;
        parent.ForeColor = foreColor;

        foreach (Control c in parent.Controls)
        {
            if (c is Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = darkMode ? Color.FromArgb(50, 50, 50) : SystemColors.Control;
                btn.ForeColor = foreColor;
            }
            else
            {
                c.BackColor = backColor;
                c.ForeColor = foreColor;
            }

            ApplyTheme(c, darkMode);
        }
    }


    
}


}
