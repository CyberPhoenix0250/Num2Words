using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Num2Word
{
	public partial class Main : Form
	{
		Num2Words nw;
		public Main()
		{
			InitializeComponent();
			nw = new Num2Words();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = nw.getInWords((long)numericUpDown1.Value).ToUpper();
		}
	}
}
