namespace _6_lab_level_3
{
    // Вариант: 2
    // Уровень: 3
    public partial class Form1 : Form
    {
        public static Random rnd = new Random();
        public static Dictionary<string, int> dic = new Dictionary<string, int>();
        public static List<int> list = new List<int>();
        public Form1() => InitializeComponent();
        private void button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                generate();
            }
            main.Text = ""; legit.Text = "Самые лучшие комманды:\n";
            foreach (var people in dic)
            {
                main.Text += $"Название комманды:{people.Key}\tСчет:{people.Value}\n";
                list.Add(people.Value);
            }
            list.Sort();
            list.Reverse();
            for (int i = 0; i < 6; i++)
            {
                legit.Text += $"{dic.FirstOrDefault(x => x.Value == list[i]).Key}\n";
            }
        }
        public void generate()
        {
            var text = string.Empty;
            for (int i = 0; i < 20; i++)
                text += (char)rnd.Next(50, 200);
            dic.Add(text, rnd.Next(1, 100));
        }
    }
}