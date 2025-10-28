using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScrollingTextControlSample
{
	public partial class ScrollingTextControl : UserControl
	{
		Timer MarqueeTimer = new Timer();
		String CurrentText = "Scrolling text";
		String OurText;
        Font ft = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        private bool _ScrollingLeftToRight = false;

		public ScrollingTextControl()
		{
			InitializeComponent();
			MarqueeTimer.Interval = 100;
			MarqueeTimer.Enabled = true;
			MarqueeTimer.Tick += new EventHandler(MarqueeUpdate);
		}

        public bool StartRun
        {
            set { MarqueeTimer.Enabled = value; }
        }
        public bool ScrollingLeftToRight
        {
            get { return _ScrollingLeftToRight; }
            set { _ScrollingLeftToRight = value; }
        }

		public int Interval
		{
			get { return MarqueeTimer.Interval; }
			set { MarqueeTimer.Interval = value; }
		}

		public override String Text
		{
			get { return OurText; }
			set { OurText = value; CurrentText = OurText; }
		}

		private void ScrollingTextControl_Paint(object sender, PaintEventArgs e)
		{
            TextRenderer.DrawText(e.Graphics, CurrentText, ft, ClientRectangle, System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(154)))), ((int)(((byte)(168))))));
		}

		void MarqueeUpdate(object sender, EventArgs e)
		{
            if (ScrollingLeftToRight)
            {
                CurrentText = CurrentText[CurrentText.Length - 1] + CurrentText.Substring(0, CurrentText.Length - 1);
            }
            else
            {
                CurrentText = CurrentText.Substring(1) + CurrentText[0];
            }
			Invalidate();
		}
	}
}
