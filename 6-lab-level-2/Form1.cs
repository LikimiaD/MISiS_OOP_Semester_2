namespace _6_lab_level_2
{
    // Вариант: 8
    // Уровень: 2
    public partial class Form1 : Form
    {
        public static Random rnd = new Random();
        public static Dictionary<string, int[]> dic = new Dictionary<string, int[]>();
        public Form1() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            generate(); main.Text = ""; legit.Text = "Список кандидатов:\n";
            foreach (var people in dic)
            {
                main.Text += $"Имя:{people.Key}\tСуммарное штрафное время:{people.Value[0] * people.Value[1]}\tВсего игр:{people.Value[1]}\n";
                if (!(people.Value[0] * people.Value[1] >= 10))
                {
                    legit.Text += $"Имя:{people.Key}\tВсего игр:{people.Value[1]}\n";
                }
            }
        }
        public void generate()
        {
            var text = string.Empty;
            for (int i = 0; i < 20; i++)
                text += (char)rnd.Next(50, 200);
            var list = new int[] { rnd.Next(2, 11), rnd.Next(1,3) };
            dic.Add(text, list);
        }
    }
}