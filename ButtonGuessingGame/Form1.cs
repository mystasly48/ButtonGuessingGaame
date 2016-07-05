using System;
using System.Drawing;
using System.Windows.Forms;

namespace ButtonGuessingGame {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        
        Button correct;
        Int32 count;
        Button[] buttons;
        Int32 btnCount;
        String name = "Button Guessing Game";
        private void Form1_Load(object sender, EventArgs e) {
            buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10 };
            btnCount = buttons.Length;
            setForm();
            setText();
            setSize();
            setLocation();
            setCorrect();
        }

        private void setForm() {
            this.Text = name;
            this.ShowInTaskbar = false;
            this.ShowIcon = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void setSize() {
            for (int i = 0; i < btnCount; i++) {
                buttons[i].Size = new Size(100, 20);
            }
        }

        private void setText() {
            for (int i = 0; i < btnCount; i++) {
                buttons[i].Text = "俺を押さないか♂";
            }
        }
        
        private void setLocation() {
            var rand = new Random();
            var btnCount = 10;
            var points = new Point[btnCount];
            for (int i = 0; i < btnCount; i++) {
                int x = rand.Next(0, 200);
                var y = rand.Next(0, 200);
                var point = new Point(x, y);
                points[i] = point;
            }
            for (int i = 0; i < btnCount; i++) {
                buttons[i].Location = points[i];
            }
        }

        private void setCorrect() {
            var rand = new Random().Next(0, buttons.Length);
            correct = buttons[rand];
        }
        
        private void IsCorrect(Button btn) {
            count++;
            if (correct == btn) {
                MessageBox.Show(String.Format("当たりだゾ！！！おめでとうゾ！\n{0}回試したゾ！！！", count));
            } else {
                btn.Enabled = false;
                btn.Visible = false;
            }
        }

        #region Button
        private void button1_Click(object sender, EventArgs e) {
            IsCorrect(button1);
        }

        private void button2_Click(object sender, EventArgs e) {
            IsCorrect(button2);
        }

        private void button3_Click(object sender, EventArgs e) {
            IsCorrect(button3);
        }

        private void button4_Click(object sender, EventArgs e) {
            IsCorrect(button4);
        }

        private void button5_Click(object sender, EventArgs e) {
            IsCorrect(button5);
        }

        private void button6_Click(object sender, EventArgs e) {
            IsCorrect(button6);
        }
        
        private void button7_Click(object sender, EventArgs e) {
            IsCorrect(button7);
        }
        
        private void button8_Click(object sender, EventArgs e) {
            IsCorrect(button8);
        }
        
        private void button9_Click(object sender, EventArgs e) {
            IsCorrect(button9);
        }

        private void button10_Click(object sender, EventArgs e) {
            IsCorrect(button10);
        }
        #endregion
    }
}
