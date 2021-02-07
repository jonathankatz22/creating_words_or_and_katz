using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creating_words
{
    public partial class form1 : Form
    {
        private char[] Letters = new char[26]; // מערך האותיות 
        private Random random_Letters = new Random(); 
        private int num_of_letters = 0; // מבטא את מספר המילים בבנק המילים
        private string word = " "; // המחרוזת בה נשתמש על מנת לבנות את המילים 
        private bool IsFirstPlayer;// משתנה המבטא של מי התור
        
        public form1()
        {
            InitializeComponent();
        }
        private void setvisible() //המציגה את כפתורי המשחק
        {
            listBox_letters.Visible = true;
            listBox_player1.Visible = true;
            listBox_player2.Visible = true;
            Easy_button.Visible = false;
            Medium_button.Visible = false;
            Hard_button.Visible = false;
            pictureBox1.Visible = false;
            Add_Word.Visible = true;
            start_button.Visible = true;
            textBox1.Visible = true;
        }


        private void setarray() // פעולה המאתחלת את מערך האותיות ומשתמשת בקוד "ASCII"
        {
            for (int i = 0; i < 26; i++)
            {
                Letters[i] = (char)(97 + i);
            }
        }

        private void setletters() // פעולה המאתחלת את בנק האותיות באופן רנדומלי לפי רמת השלב שהשחקן בחר
        {
            while (listBox_letters.Items.Count < num_of_letters)
            {
                int x = random_Letters.Next(0, 26);
                char c = Letters[x];
                listBox_letters.Items.Add(c);

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_button_Click(object sender, EventArgs e) // פעולה המתחילה את המשחק
        {
            setarray();
            setletters();
            IsFirstPlayer = true;
            start_button.Visible = false;
            Next_Turn.Visible = true;
            listBox_player2.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e) // מאתחלת את בנק האותיות לרמת שלב בינונית והיא 7 אותיות
        {
            num_of_letters = 7;
            setvisible();
            
        }

        private void button3_Click(object sender, EventArgs e)// מאתחלת את בנק האותיות לרמת שלב קשה והיא 5 אותיות
        {
            num_of_letters = 5;
            setvisible();
            

        }

        private void button1_Click_1(object sender, EventArgs e)// מאתחלת את בנק האותיות לרמת שלב קלה והיא 10 אותיות
        {
            num_of_letters = 10;
            setvisible();
            

        }

        private void Add_Word_Click_1(object sender, EventArgs e) // פעולה המוסיפה את המילה שהשחקן בנה לרשימה של השחקן
        {
            if (IsFirstPlayer == true)
            {
                listBox_player1.Items.Add(word);
            }
            else
            {
                listBox_player2.Items.Add(word);
            }
            word = " ";
            textBox1.Text = " ";
        
            
        }

        private void listBox_letters_SelectedIndexChanged(object sender, EventArgs e) // פעולה המוסיפה את האות שהשחקן בחר למילה אותה הוא מרכיב
        {
            word += listBox_letters.SelectedItem.ToString();
            textBox1.Text = word;
        }

        private void Next_Turn_Click(object sender, EventArgs e) // פעולה המתחילה את התור של השחקן השני
        {
            IsFirstPlayer = false;
            Next_Turn.Visible = false;
            Who_Won.Visible = true;
            listBox_player1.Visible = false;
            listBox_player2.Visible = true;
        }

        private void Who_Won_Click(object sender, EventArgs e) // פעולה הבודקת מי מהשחקנים ניצח לפי כמות המילים אותם הם בנו
        {
            listBox_player1.Visible = true;
            if (listBox_player1.Items.Count > listBox_player2.Items.Count)
            {
                MessageBox.Show("player 1 won!");
            }
            else if (listBox_player2.Items.Count < listBox_player2.Items.Count)
            {
                MessageBox.Show("player 2 won!");
            }
            else
            {
                MessageBox.Show("its a tie!");
            }
            
           
            

            
        }
    }
}
