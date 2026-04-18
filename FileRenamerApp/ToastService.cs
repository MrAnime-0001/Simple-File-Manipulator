namespace FileRenamerApp;

public static class ToastService
{
    public static void ShowToast(string message, int duration = 2000, bool playSound = true)
    {
        Form toast = new Form
        {
            FormBorderStyle = FormBorderStyle.FixedToolWindow,
            ControlBox = false,
            Text = string.Empty,
            StartPosition = FormStartPosition.Manual,
            ShowInTaskbar = false,
            TopMost = true,
            BackColor = Color.Black,
            Size = new Size(250, 60),
            Opacity = 0.9
        };

        toast.Controls.Add(new Label
        {
            Text = message,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 10, FontStyle.Bold),
            ForeColor = Color.White,
            BackColor = Color.Transparent
        });

        var screen = Screen.PrimaryScreen!.WorkingArea;
        toast.Location = new Point(screen.Right - toast.Width - 10, screen.Bottom - toast.Height - 10);

        toast.Shown += async (s, e) =>
        {
            if (playSound)
                System.Media.SystemSounds.Exclamation.Play();

            await Task.Delay(duration);

            for (double i = toast.Opacity; i >= 0; i -= 0.05)
            {
                if (toast.IsDisposed) break;
                toast.Invoke((Action)(() => toast.Opacity = i));
                await Task.Delay(20);
            }

            if (!toast.IsDisposed)
                toast.Invoke((Action)(() => toast.Close()));
        };

        toast.Show();
    }
}
