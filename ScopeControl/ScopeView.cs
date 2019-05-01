using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ScopeControl
{
    /// <summary>
    /// ScopeView Control for Signal Value Graph representation in real time
    /// Configurable Values: GridScale, TimeStep, Speed
    /// </summary>
    public partial class ScopeView : UserControl
    {
        /// <summary>
        /// Double value will be represented in the Graph Scope
        /// </summary>
        public double inputValue { get; set; }

        /// <summary>
        /// Grid scale in pixels
        /// </summary>
        public int GridScale { get; set; }

        /// <summary>
        /// TimeStep determines the precision of the wave analizer
        /// </summary>
        public int TimeStep { get; set; }

        /// <summary>
        /// Speed of analisis
        /// </summary>
        public int Speed { get; set; }

        private int RefreshTime;
        private int ScopeHeight, ScopeWidth;
        private int centerXScope;
        private int gridWidth;

        private Timer timer = new Timer();
        private Bitmap DrawArea = null;
        private Pen gridPen = new Pen(Color.Green);
        private Pen wavePen = new Pen(Color.Red);

        private static double[] waveArray = null;

        /// <summary>
        /// ScopeView Control for Signal Value Graph representation in real time
        /// Costructor doesn't need any parameters
        /// </summary>
        public ScopeView()
        {
            InitializeComponent();
            SetupInitView();
            ScopeScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.OnScopeScreenPaint);

            initQueue();

            timer.Interval = RefreshTime;
            timer.Tick += OnTick;
            timer.Start();
        }

        /// <summary>
        /// Every tick refresh the array and Draw it on the Screen 
        /// </summary>
        private void OnTick(Object timer, EventArgs tick)
        {
            var newArray = new double[waveArray.Length];
            newArray = Shift(waveArray, Speed, inputValue);
            newArray[newArray.Length - 1] = inputValue;
            waveArray = newArray;
            DrawWave(newArray, TimeStep);
        }

        /// <summary>
        /// Make shift of the array values Right to Left and add the new Value
        /// </summary>
        static double[] Shift(double[] myArray, int jumps, double input)
        {
            double[] tArray = new double[myArray.Length];

            for (int i = 0; i < myArray.Length; i++)
            {

                if (i < myArray.Length - jumps)
                {
                    tArray[i] = myArray[i + jumps];

                }
                else
                {
                    tArray[i] = input;
                }

            }

            return tArray;
        }

        /// <summary>
        /// Draw the array on the Bitmap and Refresh view
        /// </summary>
        private void DrawWave(double[] wave, int timeStep)
        {
            DrawArea = new Bitmap(ScopeScreen.Size.Width, ScopeScreen.Size.Height);
            ScopeScreen.Image = DrawArea;

            Graphics g = Graphics.FromImage(DrawArea);

            for (int time = 0; time < wave.Length - 1; time += timeStep)
            {
                g.DrawLine(wavePen, time, (int)wave[time] + centerXScope, time + timeStep, (int)wave[time + timeStep] + centerXScope);
            }
            ScopeScreen.Invalidate();
            ScopeScreen.Refresh();
        }


        /// <summary>
        /// Set Initial standard values 
        /// </summary>
        private void SetupInitView()
        {
            //Set initial configs
            ScopeScreen.BackColor = Color.White;
            DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.Dock = DockStyle.Fill;
            ScopeHeight = this.Height + 1;
            ScopeWidth = this.Width + 1;
            centerXScope = ScopeHeight / 2;

            //Set initial values
            GridScale = 20;
            RefreshTime = 10;
            TimeStep = 1;
            Speed = 1;
            inputValue = 0.0;
        }

        /// <summary>
        /// Set All Initial values of the array at 0.0
        /// </summary>
        private void initQueue()
        {
            waveArray = new double[ScopeWidth];
            for (int val = 0; val < ScopeWidth; val++)
            {
                waveArray[val] = 0;
            }
        }

        /// <summary>
        /// Every Paint event raised Draw the Grid in backGround
        /// </summary>
        private void OnScopeScreenPaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox Grid.
            gridWidth = ScopeWidth / GridScale;

            Graphics g = e.Graphics;

            for (int h = gridWidth; h < ScopeHeight; h += gridWidth)
            {
                g.DrawLine(gridPen, 0, h, ScopeWidth, h);
            }

            for (int w = gridWidth; w < ScopeWidth; w += gridWidth)
            {
                g.DrawLine(gridPen, w, 0, w, ScopeWidth);
            }
        }
    }
}
