using MyControls;

namespace WinFormsHW2
{



    public partial class Form1 : Form
    {
        bool newNumber = false;
        bool newOperation = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
            => Environment.Exit(0);

        const int ComaGap = 3;
        const int MaxNumberCount = 26;
        char currentOperator = default;

        static IEnumerable<string> ChunksUpto(string str, int maxChunkSize)
        {
            for (int i = str.Length - 1; i >= 0; i -= maxChunkSize)
            {
                int startIndex = i - maxChunkSize + 1;
                yield return str.Substring(startIndex < 0 ? 0 : startIndex, startIndex < 0 ? startIndex + maxChunkSize :  maxChunkSize);
            }
        }

        private string DivideString(string text, int chunkSize, string divider)
        {
            var parts = text.Split('.');
            var chunks = ChunksUpto(parts[0].Replace(divider, String.Empty), chunkSize).Reverse();
            return String.Join(divider, chunks) + (parts.Length != 1 ? '.' + parts[1] : "");
        
        }

        private void Number_Click(object sender, EventArgs e)
        {

            if(sender is Button btn && tbox_Current.Text.Length <= MaxNumberCount)
            {
                if (tbox_Current.Text == "0")
                    if (btn.Text == "0") return;
                    else tbox_Current.Text = String.Empty;    

                if(newNumber)
                {
                    tbox_Current.Text = String.Empty;
                    newNumber = false;
                }


                tbox_Current.Text += btn.Text;
                tbox_Current.Text = DivideString(tbox_Current.Text, ComaGap, ",");

            }
        }

        bool dragging = false;
        Point offset;
        Point startPoint = new Point(0, 0);

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        private void Operator_Click(object sender, EventArgs e)
        {
            if(sender is Button btn)
            {
                string currentOperator = btn.Tag.ToString();
                if (currentOperator == "=" && lbl_Previous.Text == String.Empty)
                    return;

                if (newOperation)
                {
                    lbl_Previous.Text = String.Empty;
                    newOperation = false;
                }

                decimal current = default;

                current = Convert.ToDecimal(tbox_Current.Text.Replace(",", String.Empty));

                switch (currentOperator)
                {
                    case "del":
                        if (tbox_Current.Text.Length == 1)
                            tbox_Current.Text = "0";
                        else if (tbox_Current.Text.Length != 0)
                            tbox_Current.Text = tbox_Current.Text.Substring(0,
                                tbox_Current.Text.Length - 1);

                        char lastChar = tbox_Current.Text.Last();
                        if ((lastChar == ',' || lastChar == '-'))
                            goto case "del";

                        return;
                    case "round":
                        tbox_Current.Text = Math.Round(Convert.ToDecimal(tbox_Current.Text), 2).ToString();
                        return;
                    case "clearPrevious":
                        lbl_Previous.Text = "";
                        tbox_Current.Text = "0";
                        newOperation = false;
                        newNumber = false;
                        return;
                    case "clear":
                        tbox_Current.Text = "0";
                        newNumber = false;
                        return;
                    case "²":
                        tbox_Current.Text = Convert.ToString(current* current);
                        return;
                    case "1/x":
                        if(tbox_Current.Text == "0")
                            MessageBox.Show("Can not Reverse ZERO");
                        else
                            tbox_Current.Text = Convert.ToString(1/current);
                        return;
                    case "√":
                        if (tbox_Current.Text[0] == '-')
                            MessageBox.Show("Can not Find ROOT of Negatives");
                        else
                            tbox_Current.Text = Convert.ToString(Math.Sqrt((double)current));
                        return;
                    case ".":
                        if(tbox_Current.Text.Length != 0 && 
                            !tbox_Current.Text.Contains('.'))
                            tbox_Current.Text += '.';

                        newNumber = false;
                        return;
                    case "+-":
                        if (tbox_Current.Text == "0") return;
                        if(tbox_Current.Text[0] == '-')
                            tbox_Current.Text = tbox_Current.Text.Remove(0, 1);
                        else
                            tbox_Current.Text = tbox_Current.Text.Insert(0, "-");

                        return;
                    default:
                        break;
                }

                //if (newNumber) return;

                string[] amount;
                decimal result = default;

                if(lbl_Previous.Text != String.Empty)
                {
                    amount = lbl_Previous.Text.Split(' ');
                    decimal previousAmount = Convert.ToDecimal(amount[0].Replace(",", String.Empty));

                    if(current == 0 && amount[1] == "/")
                    {
                        MessageBox.Show("Can not devide 0...");
                        return;
                    }

                    result = amount[1] switch
                    {
                        "-" => previousAmount - current,
                        "+" => previousAmount + current,
                        "*" => previousAmount * current,
                        "/" => previousAmount / current,
                    };

                }

                if (tbox_Current.Text.Last() == '.')
                    tbox_Current.Text = tbox_Current.Text
                        .Substring(0, tbox_Current.Text.Length - 1);

                //int dotIndex = tbox_Current.Text.IndexOf('.');
                //string values = new string(tbox_Current.Text.Substring(dotIndex).Distinct().ToArray());
                //if (dotIndex != -1 &&  values == ".0")
                //    tbox_Current.Text = tbox_Current.Text.Substring(0, dotIndex);

                if (result % 1 == 0)
                    result = (long)result;

                if (currentOperator == "=")
                {
                    lbl_Previous.Text += ' ' + tbox_Current.Text + ' ' + currentOperator;
                    tbox_Current.Text = result.ToString();
                    newOperation = true;
                }
                else {
                    if(lbl_Previous.Text.Length == 0) lbl_Previous.Text = tbox_Current.Text;
                    else lbl_Previous.Text = result.ToString();

                    lbl_Previous.Text += ' ' + currentOperator;
                    tbox_Current.Text = result.ToString();
                } 

                newNumber = true;

            }
        }

        private void tbox_Current_TextChanged(object sender, EventArgs e)
        {
            if (TextRenderer.MeasureText(tbox_Current.Text + "  ", tbox_Current.Font).Width > tbox_Current.Width)
                do { tbox_Current.Font = new Font("Segoe UI", tbox_Current.Font.Size - .1f, FontStyle.Bold); }
                while (TextRenderer.MeasureText(tbox_Current.Text + " ", tbox_Current.Font).Width > tbox_Current.Width);
            else
                while (TextRenderer.MeasureText(" ", tbox_Current.Font).Height < tbox_Current.Height - 10
                    && TextRenderer.MeasureText(tbox_Current.Text + "  ", tbox_Current.Font).Width < tbox_Current.Width)
                    tbox_Current.Font = new Font("Segoe UI", tbox_Current.Font.Size + .1f, FontStyle.Bold);

        }
    }
}