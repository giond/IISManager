using System;
using System.Windows.Forms;
using IISManager.Core.Managers;

namespace IISManager.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void bRecycle_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                await AspManager.Recycle();

                MessageBox.Show("IIS pool successfully recycled", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Hand;
            }
        }

        private async void bStop_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                await AspManager.Stop();

                MessageBox.Show("Site successfully stopped", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Hand;
            }
        }

        private async void bStart_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                await AspManager.Start();

                MessageBox.Show("Site successfully started", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Hand;
            }
        }

        private async void bRestart_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                await AspManager.Restart();

                MessageBox.Show("Site successfully restarted", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Hand;
            }
        }
    }
}
