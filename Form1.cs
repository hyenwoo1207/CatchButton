namespace CatchButton1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void RunningButton1(object sender, EventArgs e)
        {
            // 1. 난수생성기준비
            Random rd = new Random();
            // 2. 가용영역계산(버튼이폼테두리에걸리지않게보호)
            // ClientSize는타이틀바와테두리를제외한실제흰도화지영역임
            int availX = this.ClientSize.Width - RunningButton.Width;
            int availY = this.ClientSize.Height - RunningButton.Height;
            // 3. 랜덤좌표추출(0 ~ 최대가용치사이). 버튼 크기를 고려해서 폼을 벗어나지 않도록 함
            int nextX = availX > 0 ? rd.Next(0, availX + 1) : 0;
            int nextY = availY > 0 ? rd.Next(0, availY + 1) : 0;
            // 4. 위치할당(새로운Point 객체생성)
            RunningButton.Location = new Point(nextX, nextY);
            // 5. 시각적피드백(폼제목표시줄에좌표출력)
            this.Text = $"버튼위치: ({nextX}, {nextY})";
        }
    }
}
