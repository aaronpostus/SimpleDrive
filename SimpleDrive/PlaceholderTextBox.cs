using System;
using System.Drawing;
using System.Windows.Forms;
namespace SimpleDriveApp
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class PlaceHolderTextBox : TextBox
    {
        private bool isPlaceHolder = true;
        private string placeHolderText;
        private bool initialPlaceHolderSet = false;

        public string PlaceHolderText
        {
            get { return placeHolderText; }
            set
            {
                placeHolderText = value;
                SetPlaceholder();
            }
        }

        public PlaceHolderTextBox()
        {
            SetPlaceholder();
            GotFocus += OnGotFocus;
            LostFocus += OnLostFocus;
            TextChanged += OnTextChanged;
            Leave += OnLeave;
        }

        private void SetPlaceholder()
        {
            if (!initialPlaceHolderSet && string.IsNullOrEmpty(this.Text))
            {
                this.Text = placeHolderText;
                this.ForeColor = Color.Gray;
                isPlaceHolder = true;
            }
        }

        private void RemovePlaceHolder()
        {
            if (isPlaceHolder)
            {
                int selectionStart = this.SelectionStart;
                int selectionLength = this.SelectionLength;

                this.Text = this.Text.Replace(placeHolderText, ""); // Remove placeholder text
                this.ForeColor = System.Drawing.SystemColors.WindowText;
                isPlaceHolder = false;

                // Restore selection position
                this.Select(selectionStart - 1, selectionLength);
            }
        }

        private void OnGotFocus(object sender, EventArgs e)
        {
            if (isPlaceHolder)
            {
                this.Text = ""; // Clear placeholder text when textbox gains focus
                this.ForeColor = System.Drawing.SystemColors.WindowText;
                isPlaceHolder = false;
            }
        }

        private void OnLostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                SetPlaceholder(); // Restore placeholder text if textbox is empty and loses focus
            }
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (!initialPlaceHolderSet)
            {
                initialPlaceHolderSet = true;
                return;
            }

            if (this.Text.Length == 0)
            {
                SetPlaceholder();
            }
            else
            {
                RemovePlaceHolder();
            }
        }

        private void OnLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                SetPlaceholder(); // Restore placeholder text if textbox is empty and loses focus
            }
        }
    }


}