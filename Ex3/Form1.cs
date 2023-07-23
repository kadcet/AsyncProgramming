namespace Ex3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;
			btnCancelTask.Enabled = false;
			prgBar.Minimum = 0;
			prgBar.Maximum = 100;
		}
		CancellationTokenSource cancellationTokenSource;
		private void DoWork(CancellationToken token)
		{
			for (int i = 0; i < 100; i++)
			{
				Thread.Sleep(1000);
				lbxTaskResult.Items.Add(i);
				prgBar.Increment(1);
				try
				{
					token.ThrowIfCancellationRequested();
				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.ToString(), "Ýþlem Ýptal Edildi");
					return;
				}
			}
		}
		private async Task RunANewTas()
		{
			cancellationTokenSource = new CancellationTokenSource();

			var task = new Task(() =>
			{
				DoWork(cancellationTokenSource.Token);
			}, cancellationTokenSource.Token);

			task.Start();
			btnCancelTask.Enabled = true;
		}
		private async void btnRunANewTask_Click(object sender, EventArgs e)
		{
			await RunANewTas();
			MessageBox.Show("Test");
		}

		private void btnCancelTask_Click(object sender, EventArgs e)
		{
			cancellationTokenSource.Cancel();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			lbxData.Items.Add(txtMessage.Text);
		}
	}
}