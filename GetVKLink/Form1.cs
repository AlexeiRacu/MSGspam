using static System.Net.WebRequestMethods;
using static System.Windows.Forms.LinkLabel;

namespace GetVKLink
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            int maxVideos = 8;
            LinkArr.Clear();
            if (ReadMyText.Text != string.Empty && ReadMyText.Text != "Введи свой запрос")
            {
                try
                {
                    maxVideos = int.Parse(textBox1.Text);
                }
                catch
                {

                }

                string[] YoutubeLinks = await GetLink.YoutubeVideoLink(ReadMyText.Text, Filtr.Text);
                foreach (string youtubeLink in YoutubeLinks)
                {
                    i++;
                    LinkArr.Text += "Видео: " + youtubeLink + "\n";
                    string[] VKLinks = await GetLink.VKlink(youtubeLink);
                    if (VKLinks.Length > 0)
                    {
                        foreach (string vkLink in VKLinks)
                        {
                            LinkArr.Text += "\tВК автора: " + vkLink + "\n";
                        }
                    }
                    else
                    {
                        LinkArr.Text += "\tВК автора: Не найдено\n";
                    }
                    if (i >= maxVideos)
                    {
                        break;
                    }
                }
            }
            else
            {
                LinkArr.Text += "ЗАПРОС НЕ ДОЛЖЕН БЫТЬ ПУСТЫМ!";
            }
        }


        private void ReadMyText_Enter(object sender, EventArgs e)
        {
            // Если текст является текстом по умолчанию, очистить его при получении фокуса
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Введи свой запрос")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void ReadMyText_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = "Введи свой запрос";
                tb.ForeColor = Color.Gray;
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            switch (trackBar.Value)
            {
                case 1:
                    Filtr.Text = "Все";
                    break;
                case 2:
                    Filtr.Text = "Неделя";
                    break;
                case 3:
                    Filtr.Text = "Месяц";
                    break;
                case 4:
                    Filtr.Text = "Год";
                    break;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "количество видео")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = "количество видео";
                tb.ForeColor = Color.Gray;
            }
        }
    }
}
