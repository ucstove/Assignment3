namespace Assignment3
{
    public partial class MainForm : Form
    {
        int[] hand;
        List<int> cards;
        public MainForm()
        {
            InitializeComponent();
            cards = new List<int>(52);
            hand = new int[5];
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                hand[i] = Math.Abs((new Random()).Next() % 52);
                cards.Remove(hand[i]);
            }
            pb1.Image = imglstCards.Images[hand[0]];
            pb2.Image = imglstCards.Images[hand[1]];
            pb3.Image = imglstCards.Images[hand[2]];
            pb4.Image = imglstCards.Images[hand[3]];
            pb5.Image = imglstCards.Images[hand[4]];
        }
    }
}
