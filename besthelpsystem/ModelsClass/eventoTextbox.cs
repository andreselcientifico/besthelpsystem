namespace besthelpsystem.ModelsClass
{
    public class eventoTextbox
    {
        public void textkeyPress(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }

        }

        public void numberkeypress(KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            if (char.IsLetter(e.KeyChar)) { e.Handled = true; }
        }
        public void numberdecimal(TextBox textBox, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if ((e.KeyChar == '.') && (!textBox.Text.Contains("."))) { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}
