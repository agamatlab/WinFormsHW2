namespace MyControls
{
    class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }
    }
}
