using System.Runtime.ExceptionServices;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        int[] hand;
        List<int> cards;
        int rand;
        public MainForm()
        {
            cards = new List<int>(52);
            hand = new int[5];
            for (int i = 0; i < 52; i++)
            {
                cards.Add(i);
            }
            InitializeComponent();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 5)
            {
                rand = Math.Abs((new Random()).Next() % 52);
                if (cards.Contains(rand))
                {
                    hand[i] = rand;
                    cards.Remove(hand[i]);
                    i++;
                }
            }
            pb1.Image = imglstCards.Images[hand[0]];
            pb2.Image = imglstCards.Images[hand[1]];
            pb3.Image = imglstCards.Images[hand[2]];
            pb4.Image = imglstCards.Images[hand[3]];
            pb5.Image = imglstCards.Images[hand[4]];
        }

        public void btnDeal_Click(object sender, EventArgs e)
        {
            if (!chkKeep1.Checked)
            {
                cards.Add(hand[0]);
                Boolean loop = true;
                while (loop)
                {
                    rand = (new Random()).Next() % cards.Count;
                    if (cards.Contains(rand))
                    {
                        loop = false;
                        hand[0] = cards[rand];
                    }
                }
                cards.Remove(hand[0]);
            }
            if (!chkKeep2.Checked)
            {
                cards.Add(hand[1]);
                Boolean loop = true;
                while (loop)
                {
                    rand = (new Random()).Next() % cards.Count;
                    if (cards.Contains(rand))
                    {
                        loop = false;
                        hand[1] = cards[rand];
                    }
                }
                cards.Remove(hand[1]);
            }
            if (!chkKeep3.Checked)
            {
                cards.Add(hand[2]);
                Boolean loop = true;
                while (loop)
                {
                    rand = (new Random()).Next() % cards.Count;
                    if (cards.Contains(rand))
                    {
                        loop = false;
                        hand[2] = cards[rand];
                    }
                }
                cards.Remove(hand[2]);
            }
            if (!chkKeep4.Checked)
            {
                cards.Add(hand[3]);
                Boolean loop = true;
                while (loop)
                {
                    rand = (new Random()).Next() % cards.Count;
                    if (cards.Contains(rand))
                    {
                        loop = false;
                        hand[3] = cards[rand];
                    }
                }
                cards.Remove(hand[3]);
            }
            if (!chkKeep5.Checked)
            {
                cards.Add(hand[4]);
                Boolean loop = true;
                while (loop)
                {
                    rand = (new Random()).Next() % cards.Count;
                    if (cards.Contains(rand))
                    {
                        loop = false;
                        hand[4] = cards[rand];
                    }
                }
                cards.Remove(hand[4]);
            }
            pb1.Image = imglstCards.Images[hand[0]];
            pb2.Image = imglstCards.Images[hand[1]];
            pb3.Image = imglstCards.Images[hand[2]];
            pb4.Image = imglstCards.Images[hand[3]];
            pb5.Image = imglstCards.Images[hand[4]];
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.InitialDirectory = @"C:\Users\uriah\ISYS325\Assignment3";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (int card in hand)
                    {
                        sw.WriteLine(card);
                    }
                }
            }
        }

        public void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.InitialDirectory = @"C:\Users\uriah\ISYS325\Assignment3";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Array.Clear(hand, 0, hand.Length);
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        hand[i] = int.Parse(sr.ReadLine());
                        cards.Remove(hand[i]);
                    }
                }
                pb1.Image = imglstCards.Images[hand[0]];
                pb2.Image = imglstCards.Images[hand[1]];
                pb3.Image = imglstCards.Images[hand[2]];
                pb4.Image = imglstCards.Images[hand[3]];
                pb5.Image = imglstCards.Images[hand[4]];
            }
        }
    }
}
