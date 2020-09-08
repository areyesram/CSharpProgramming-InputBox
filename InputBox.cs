using System.Drawing;
using System.Windows.Forms;

namespace areyesram
{
    public static class InputBox
    {
        private static string _text;
        private static DialogResult _result;

        public static string Prompt(string prompt = "", string title = "")
        {
            var form = new Form
            {
                ClientSize = new Size(300, 100),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title
            };
            var lblPrompt = new Label
            {
                Dock = DockStyle.Top,
                Text = prompt
            };
            var txtInput = new TextBox
            {
                Dock = DockStyle.Top,
                TabIndex = 0
            };
            var buttonPanel = new Panel
            {
                Dock = DockStyle.Top,
                Location = new Point(8, 54),
                Padding = new Padding { Top = 8 },
                Height = 32,
                TabIndex = 1
            };
            var btnCancel = new Button
            {
                DialogResult = DialogResult.Cancel,
                Dock = DockStyle.Right,
                Text = "Cancel"
            };
            var separator = new Label
            {
                Dock = DockStyle.Right,
                Width = 8
            };
            var btnOK = new Button
            {
                Dock = DockStyle.Right,
                Text = "OK"
            };
            buttonPanel.Controls.Add(btnOK);
            buttonPanel.Controls.Add(separator);
            buttonPanel.Controls.Add(btnCancel);
            form.AcceptButton = btnOK;
            form.CancelButton = btnCancel;
            form.Controls.Add(buttonPanel);
            form.Controls.Add(txtInput);
            form.Controls.Add(lblPrompt);
            form.Padding = new Padding(8);

            btnOK.Click += (o, e) =>
            {
                _text = txtInput.Text;
                _result = DialogResult.OK;
                form.Close();
            };
            btnCancel.Click += (o, e) => _result = DialogResult.Cancel;
            form.ShowDialog();
            return _result == DialogResult.OK ? _text : null;
        }
    }
}
