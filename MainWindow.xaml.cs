using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace WPF_Anim_KeyFramesAnimation_Ex
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btStart_Click(object sender, RoutedEventArgs e)
		{
			StringAnimationUsingKeyFrames da = new()
			{
				AutoReverse = true
			};
			double t = 0, dt = 0.25;
			da.KeyFrames.Add(new DiscreteStringKeyFrame("", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("P", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("Pr", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("Pre", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("Pred", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("Prede", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("Predef", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("Predefi", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("Predefin", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("Predefine", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("Predefined", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.Duration = new Duration(TimeSpan.FromSeconds(DT(ref t, dt)));
			btStart.BeginAnimation(ContentProperty, da);
		}
		private double DT(ref double t, double dt)
		{
			t = t + dt;
			return t;
		}

	}
}
