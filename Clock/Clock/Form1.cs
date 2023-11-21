using System;
using System.Windows.Forms;

namespace Clock
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      
    }

    public void label1_Click(object sender, EventArgs e)
    {
      
    }

    public void SetTimeText(string time)
    {
      label1.Text = time;
      label1.Show();
    }
  }
}
