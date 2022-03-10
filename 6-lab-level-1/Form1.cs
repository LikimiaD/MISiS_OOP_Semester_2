namespace _6_lab_level_1
{
    public partial class Form1 : Form
    {
        public static Random rnd = new Random();
        public static Dictionary<string, int[]> dic = new Dictionary<string, int[]>();
        public static List<int> temp = new List<int>();
        public Form1() => InitializeComponent();

        private void generate_button_Click(object sender, EventArgs e)
        {
            generate(); main_textbox.Text = ""; kicked_textbox.Text = "";
            foreach (var people in dic)
            {
                main_textbox.Text += $"Имя:{people.Key}\tОценка:{people.Value[0]}\tКол-во пропусков:{people.Value[1]}\n";
                if (!(people.Value[0] > 2)) temp.Add(people.Value[1]); 
            }
        }
        private void filter_button_Click(object sender, EventArgs e)
        {
            temp.Sort(); temp.Reverse();
            kicked_textbox.Text = "Неуспевающие:\n";
            foreach (var hours in temp)
            {
                kicked_textbox.Text += $"{dic.FirstOrDefault(x => x.Value[1] == hours).Key}";
            }
         }
        public void generate()
        {
            var text = string.Empty;
            for (int i = 0; i < 20; i++)
                text += (char)rnd.Next(50, 200);
            var list = new int[] { rnd.Next(0, 5), rnd.Next(0, 36) };
            dic.Add(text, list);
        }
    }
}