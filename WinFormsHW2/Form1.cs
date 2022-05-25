using MyControls;

namespace WinFormsHW2
{



    public partial class Form1 : Form
    {
        bool isDecimal = false;
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
            for (int i = 0; i < str.Length; i += maxChunkSize)
                yield return str.Substring(i, Math.Min(maxChunkSize, str.Length - i));
        }

        private string DivideString(string text, int chunkSize, string divider)
        {
            var chunks = ChunksUpto(text.Replace(divider, String.Empty), chunkSize);
            return String.Join(divider, chunks);
        
        }

        private void Number_Click(object sender, EventArgs e)
        {

            if(sender is Button btn && tbox_Current.Text.Length <= MaxNumberCount)
            {
                if(newNumber)
                {
                    tbox_Current.Text = String.Empty;
                    newNumber = false;
                }



                tbox_Current.Text += btn.Text;
                tbox_Current.Text = DivideString(tbox_Current.Text, ComaGap, ",");

            }
        }

        //private decimal CalculateOperators(string[] prev, decimal current, string currrentOperator)
        //{
        //    var previousAmount = Convert.ToDecimal(prev[0].Replace(",", String.Empty));

        //    decimal result = currrentOperator switch
        //    {
        //        "-" => previousAmount - current,
        //        "+" => previousAmount + current,
        //        "*" => previousAmount * current,
        //        "²" => current * current,
        //        "=" => CalculateOperators(prev,current, currrentOperator),
        //    };
        //}


        private void Operator_Click(object sender, EventArgs e)
        {
            if(sender is Button btn)
            {
                if (newOperation)
                {
                    lbl_Previous.Text = String.Empty;
                    newOperation = false;
                }

                decimal current = default;

                if (tbox_Current.Text != String.Empty)
                    current = Convert.ToDecimal(tbox_Current.Text.Replace(",", String.Empty));
                else
                    return;
                switch (btn.Tag.ToString())
                {
                    case "del":
                        if(tbox_Current.Text.Length != 0) 
                            tbox_Current.Text = tbox_Current.Text.Substring(0, tbox_Current.Text.Length - 1);
                        return;
                    case "²":
                        tbox_Current.Text = Convert.ToString(current* current);
                        return;
                    case "1/x":
                        tbox_Current.Text = Convert.ToString(1/current);
                        return;
                    case "√":
                        tbox_Current.Text = Convert.ToString(Math.Sqrt((double)current));
                        return;

                    default:
                        break;
                }

                if (newNumber) return;

                string[] amount;
                decimal result = default;

                if(lbl_Previous.Text != String.Empty)
                {
                    amount = lbl_Previous.Text.Split(' ');
                    decimal previousAmount = Convert.ToDecimal(amount[0].Replace(",", String.Empty));

                    result = amount[1] switch
                    {
                        "-" => previousAmount - current,
                        "+" => previousAmount + current,
                        "*" => previousAmount * current,
                    };

                }

                string currentOperator = btn.Tag.ToString();
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
                    newNumber = true;
                } 


            }
        }

        private void tbox_Current_TextChanged(object sender, EventArgs e)
        {
            while (TextRenderer.MeasureText(tbox_Current.Text + " ", tbox_Current.Font).Width > tbox_Current.Width)
                tbox_Current.Font = new Font("Segoe UI", tbox_Current.Font.Size - 1.6f, FontStyle.Bold);
        }
    }
}