namespace WindowsFormsApplication04
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Button_MouseEnter(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Button currentButton = sender as System.Windows.Forms.Button;
			if (currentButton != null)
			{
				currentButton.BackColor = System.Drawing.Color.Yellow;
			}
		}

		private void Button_MouseLeave(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Button currentButton = sender as System.Windows.Forms.Button;
			if (currentButton != null)
			{
				currentButton.BackColor = System.Drawing.Color.DarkGray;
			}
		}
	}
}
