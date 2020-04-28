using System;
using System.Drawing;
using System.Windows.Forms;




namespace Snake
{
    public partial class Form1 : Form
    {
        private int SnakeX, SnakeY;
        private int SnakeDirectionX = 1, SnakeDirectionY = 1;
        private const int CellSize = 40;
        private Point[] Tail = new Point[3];
        private Point[] FoodPosition = new Point[3];
     
        private bool isStepLocked;
        private Bitmap SnakeHeadImage, SnakeTailImage, BackGroundImage, FoodImage, LiveXImage, LiveImage;
        private Random random = new Random();
        private void gameUpdate_Tick(object sender, EventArgs e)
        {
            PushToTail(new Point(SnakeX, SnakeY));

            SnakeX += SnakeDirectionX;
            SnakeY += SnakeDirectionY;
            if (SnakeX > 16)
            {
                SnakeX = 1;
            }
            if (SnakeX < 1)
            {
                SnakeX = 16;
            }

            if (SnakeY > 16)
            {
                SnakeY = 1;
            }
            if (SnakeY < 1)
            {
                SnakeY = 16;
            }
            isStepLocked = false;


            
               
            
            

            for (int j = 0; j < FoodPosition.Length; j++)
            {

                

                for (int i = 0; i < Tail.Length; i++)
                {
                    if (SnakeX == FoodPosition[j].X && SnakeY == FoodPosition[j].Y)
                    {
                       
                        FoodPosition[j].X = random.Next(1, 17);
                        FoodPosition[j].Y = random.Next(1, 17);
                        
                        Array.Resize(ref Tail, Tail.Length + 1);

                        TailMeter.Text = " " + Tail.Length;

                    }

                    if (Tail[i] == FoodPosition[j])
                    {
                        FoodPosition[j].X = random.Next(1, 17);
                        FoodPosition[j].Y = random.Next(1, 17);
                    }

                    
                }

                   
                     for (int i = 0; i < Tail.Length; i++)
                     {
                        if (SnakeX == Tail[i].X && SnakeY == Tail[i].Y)
                        {
                        
                            Array.Resize(ref Tail, Tail.Length + i - Tail.Length);
                            TailMeter.Text = " " + Tail.Length;
                            
                            

                            if (LiveOne.Image == LiveXImage && LiveTwo.Image == LiveXImage)
                            {
                                LiveThree.Image = LiveXImage;
                            }

                            if (LiveOne.Image == LiveXImage)
                            {
                                LiveTwo.Image = LiveXImage;
                            }

                            if (LiveOne.Image != LiveXImage)
                            {
                                LiveOne.Image = LiveXImage;
                            }

                            if (LiveOne.Image == LiveXImage && LiveTwo.Image == LiveXImage && LiveThree.Image == LiveXImage)
                            {
                                PauseLabel.Visible = true;
                                PauseLabel.ForeColor = Color.Red;
                                PauseLabel.Text = "       GAME OVER!!!";
                                gameUpdate.Interval = 100000;
                                
                            }
                            
                        }
                        
                     }
                     

                Refresh();
                if (Convert.ToInt32(TailMeter.Text) >= Convert.ToInt32(TailMax.Text))
                {
                    TailMax.Text = " " + Tail.Length;
                }
            }
                   
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (gameUpdate.Enabled == true)
            {
                

                     switch (e.KeyCode)
                     {
                        case Keys.A:
                            SetDirection(-1, 0);
                                                   
                            break;
                        case Keys.D:
                            SetDirection(1, 0);
                        
                            break;
                        case Keys.W:
                            SetDirection(0, -1);
                        
                            break;
                        case Keys.S:
                            SetDirection(0, 1);
                        
                            break;
                        case Keys.Space:
                            gameUpdate.Enabled = false;
                            PauseLabel.Visible = true;
                            break;
                     
                     }
                
            }
            else
            {
                PauseLabel.Visible = false;
                gameUpdate.Enabled = true;
            }



        }

        private void SetDirection(int x, int y)
        {
            
            if ((SnakeDirectionX * -1 == x && SnakeDirectionY * -1 == y) || isStepLocked)
            {
                return;
            }


            SnakeDirectionX = x;
            SnakeDirectionY = y;

            isStepLocked = true;
        }

        public Form1()
        {
            
            CreateFood();
            LiveXImage = WindowsFormsApp1.Images.LiveX;
            LiveImage = WindowsFormsApp1.Images.Live;
            BackGroundImage = WindowsFormsApp1.Images.BackGround;
            FoodImage = WindowsFormsApp1.Images.Food;
            SnakeHeadImage = WindowsFormsApp1.Images.SnakeHead;
            SnakeTailImage = WindowsFormsApp1.Images.SnakeTail;
            this.SetStyle(ControlStyles.UserPaint |
                            ControlStyles.AllPaintingInWmPaint |
                            ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawImage(BackGroundImage, CellSize, CellSize);
            
            graphics.DrawImage(SnakeHeadImage, new Rectangle(SnakeX * CellSize, SnakeY * CellSize, CellSize, CellSize));

            for (int j = 0; j < FoodPosition.Length; j++)
            {
                
                graphics.DrawImage(FoodImage, new Rectangle(FoodPosition[j].X * CellSize, FoodPosition[j].Y * CellSize, CellSize, CellSize)); graphics.DrawImage(FoodImage, new Rectangle(FoodPosition[j].X * CellSize, FoodPosition[j].Y * CellSize, CellSize, CellSize));
            }

            for (int i = 0; i < Tail.Length; i++)
            {
                
                graphics.DrawImage(SnakeTailImage, new Rectangle(Tail[i].X * CellSize, Tail[i].Y * CellSize, CellSize, CellSize));
                
            }
        }

  
       
        private void CreateFood()
        {
            
                for (int j = 0; j < FoodPosition.Length; j++)
                {
                
                FoodPosition[0].X = random.Next(1, 17);
                FoodPosition[0].Y = random.Next(1, 17);

                FoodPosition[1].X = random.Next(1, 17);
                FoodPosition[1].Y = random.Next(1, 17);

                FoodPosition[2].X = random.Next(1, 17);
                FoodPosition[2].Y = random.Next(1, 17);
                
                }
            
        }

        private void PushToTail(Point point)
        {

          
            for (int i = Tail.Length - 1; i > 0; i--)
              {
                  Tail[i] = Tail[i - 1];
              }

            Tail[0] = point;



        }

        
           
        

    }
}
