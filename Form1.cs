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
            int maxX = this.ClientSize.Width;
            int maxY = this.ClientSize.Height;
            // 3. 랜덤좌표추출(버튼이 폼에서 완전히 보이도록 좌표 범위 조정)
            // 버튼의 우측/하단이 폼을 벗어나지 않도록 최대 좌표를 버튼 크기만큼 줄임
            int boundX = Math.Max(1, maxX - RunningButton.Width + 1);
            int boundY = Math.Max(1, maxY - RunningButton.Height + 1);
            int nextX = rd.Next(0, boundX);
            int nextY = rd.Next(0, boundY);
            // 4. 위치할당(새로운Point 객체생성)
            RunningButton.Location = new Point(nextX, nextY);
            // 5. 시각적피드백(폼제목표시줄에좌표출력)
            this.Text = $"버튼위치: ({nextX}, {nextY})";
        }
    }
}
