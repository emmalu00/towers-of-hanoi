using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace KSU.CIS300.TowersOfHanoi
{
    /// <summary>
    /// A GUI for a class that creates the Towers of Hanoi.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Property that keeps track of the number of moves
        /// made for the current puzzle.
        /// </summary>
        public int Moves
        {
            get;
            private set;
        }

        /// <summary>
        /// A property tha indicates if the program is in
        /// test mode or not. This is used by unit tests. 
        /// </summary>
        public bool TestMode
        {
            get;
            set;
        }

        /// <summary>
        /// The stack that stores discs in the first peg.
        /// </summary>
        public Stack<int> PegA
        {
            get;
            set;
        }

        /// <summary>
        /// The stack that stores discs in the second peg.
        /// </summary>
        public Stack<int> PegB
        {
            get;
            set;
        }

        /// <summary>
        /// The stack that stores discs in the third peg.
        /// </summary>
        public Stack<int> PegC
        {
            get;
            set;
        }

        /// <summary>
        /// The number of discs being used for the current puzzle.
        /// </summary>
        private int _discCount;

        /// <summary>
        /// Default constructor that itilizaties the interface.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
            _discCount = Convert.ToInt32(uxNumDiscs.Text);
            NewPuzzle(_discCount);
        }

        /// <summary>
        /// Draws a disc and adds it to the corresponding panel.
        /// </summary>
        /// <param name="number"> Number of discs. </param>
        /// <param name="panel"> Panel to which the discs are 
        /// added. </param>
        private void DrawDisc(int number, FlowLayoutPanel panel)
        {
            Label newLabel = new Label();
            newLabel.Width = (int)(panel.Width / (_discCount - number + 1.25));
            Padding p = new Padding();
            p = newLabel.Margin;
            newLabel.Height = 30;
            p.Left = ((panel.Width - newLabel.Width) / 2);
            p.Right = ((panel.Width - newLabel.Width) / 2);
            newLabel.Margin = p;
            if (number % 2 == 1)
            {
                newLabel.BackColor = Color.Green;
            }
            else if (number % 2 == 0)
            {
                newLabel.BackColor = Color.YellowGreen;
            }
            newLabel.Text = number.ToString();
            newLabel.BorderStyle = BorderStyle.FixedSingle;
            newLabel.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(newLabel);
        }

        /// <summary>
        /// Removes all the controls in a given panel.
        /// </summary>
        /// <param name="panel"> Panel that controls are removed 
        /// from. </param>
        private void CleanPanel(FlowLayoutPanel panel)
        {
            Stack<Control> stack = new Stack<Control>();
             foreach (Control c in panel.Controls)
             {
                 stack.Push(c);
             }
             while (stack.Count > 0)
             {
                 Control c = stack.Pop();
                 panel.Controls.Remove(c);
                 c.Dispose();
             }
        }

        /// <summary>
        /// Initializes a new puzzle.
        /// </summary>
        /// <param name="count"> Disc count. </param>
        public void NewPuzzle(int count)
        {
            _discCount = count;
            Moves = 0;
            uxMoves.Text = Moves.ToString();
            uxMoves.Update();
            PegA = new Stack<int>();
            PegB = new Stack<int>();
            PegC = new Stack<int>();
            CleanPanel(uxFlowLayoutPanelPegA);
            CleanPanel(uxFlowLayoutPanelPegB);
            CleanPanel(uxFlowLayoutPanelPegC);
            for (int i = count; i > 0; i--)
            {
                PegA.Push(i);
                DrawDisc(i, uxFlowLayoutPanelPegA);
            }
            uxFlowLayoutPanelPegA.Update();
            uxFlowLayoutPanelPegB.Update();
            uxFlowLayoutPanelPegC.Update();
        }

        /// <summary>
        /// Compares the number of discs in a given panel with the 
        /// the number of discs in the corresponding source stack.
        /// </summary>
        /// <param name="source"> Source panel. </param>
        /// <param name="sourceStack"> Source stack. </param>
        /// <param name="dest"> Destination panel. </param>
        /// <param name="destStack"> Destination stack. </param>
        /// <param name="alt"> Alternative panel. </param>
        /// <param name="altStack"> lternative stack. </param>
        /// <returns></returns>
        private bool UpdatePanelHelper(FlowLayoutPanel source, Stack<int> sourceStack, FlowLayoutPanel dest, Stack<int> destStack, FlowLayoutPanel alt, Stack<int> altStack)
        {
            Control disc = new Control();
            if (source.Controls.Count < 1)
            {
                return false;
            }
            if (source.Controls.Count > sourceStack.Count)
            {
                disc = source.Controls[source.Controls.Count - 1];
                source.Controls.RemoveAt(source.Controls.Count - 1);
                source.Update();
                if (dest.Controls.Count < destStack.Count)
                {
                    dest.Controls.Add(disc);
                    dest.Update();
                }
                else if (alt.Controls.Count < altStack.Count)
                {
                    alt.Controls.Add(disc);
                    alt.Update();
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Calls the UpdatePanelHelper method in order to make sure all panels are updated. 
        /// </summary>
        private void UpdatePanels()
        {
            UpdatePanelHelper(uxFlowLayoutPanelPegA, PegA, uxFlowLayoutPanelPegB, PegB, uxFlowLayoutPanelPegC, PegC);
            UpdatePanelHelper(uxFlowLayoutPanelPegB, PegB, uxFlowLayoutPanelPegC, PegC, uxFlowLayoutPanelPegA, PegA);
            UpdatePanelHelper(uxFlowLayoutPanelPegC, PegC, uxFlowLayoutPanelPegA, PegA, uxFlowLayoutPanelPegB, PegB);
        }

        /// <summary>
        /// Checks if there is a legal move from 'from' to 'to'.
        /// </summary>
        /// <param name="from"> The from stack. </param>
        /// <param name="to"> The to stack. </param>
        /// <returns></returns>
        public bool CheckMove(Stack<int> from, Stack<int> to)
        {
            if (from.Count == 0)
            {
                return false;
            }
            else if (to.Count == 0)
            {
                return true;
            }
            else if (from.Peek() > to.Peek())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Checks if there is a legal move between stacks. 
        /// If so, the move is made.
        /// </summary>
        /// <param name="from"> The from stack. </param>
        /// <param name="to"> The to stack. </param>
        /// <returns></returns>
        public bool MoveDisc(Stack<int> from, Stack<int> to)
        {
            bool checkMove = CheckMove(from, to);
            if (checkMove)
            {
                int pop = from.Pop();
                to.Push(pop);
                Moves++;
                uxMoves.Text = Moves.ToString();
                uxMoves.Update();
                UpdatePanels();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Tries to move a disc from stack x to y, and if unsuccessful, 
        /// tries to move a disc from y to x.
        /// </summary>
        /// <param name="x"> The from stack. </param>
        /// <param name="y"> The to stack. </param>
        public void MoveEither(Stack<int> x, Stack<int> y)
        {
            bool move = MoveDisc(x, y);
            if (!move)
            {
                MoveDisc(y, x);
            }
        }

        /// <summary>
        /// Click event handler for the solve button.
        /// This method only works with new puzzles. 
        /// </summary>
        /// <param name="x"> The from stack. </param>
        /// <param name="y"> The to stack. </param>
        /// <param name="delay"> Number of milliseconds. </param>
        public void Solve(Stack<int> x, Stack<int> y, int delay)
        {
            delay = Convert.ToInt32(uxNumSeconds.Text);
            while (uxFlowLayoutPanelPegC.Controls.Count != _discCount)
            {
                MoveEither(PegA, x);
                if (uxFlowLayoutPanelPegC.Controls.Count == _discCount)
                {
                    break;
                }
                Thread.Sleep(delay);
                MoveEither(PegA, y);
                if (uxFlowLayoutPanelPegC.Controls.Count == _discCount)
                {
                    break;
                }
                Thread.Sleep(delay);
                MoveEither(PegB, PegC);
                if (uxFlowLayoutPanelPegC.Controls.Count == _discCount)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Button click event handler for the "New" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButtonNewPuzzle_Click(object sender, EventArgs e)
        {
            NewPuzzle((Convert.ToInt32(uxNumDiscs.Text)));
        }

        /// <summary>
        /// Control added event handler for the right-most panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFlowLayoutPanelPegC_ControlAdded(object sender, ControlEventArgs e)
        {
            double optimalMoves = (Math.Pow(2.0, _discCount)) - 1;
            if ((uxFlowLayoutPanelPegC.Controls.Count == _discCount)) // && (uxFlowLayoutPanelPegA.Controls.Count == 0) && (uxFlowLayoutPanelPegB.Controls.Count == 0))
            {
                if (optimalMoves >= Moves)
                {
                    MessageBox.Show("Congratulations! You have won the game! **You won the game in an optimal number of moves.**");
                }
                else
                {
                    MessageBox.Show("Congratulations! You have won the game!");
                }
            }
        }

        /// <summary>
        /// Button click event handler for the "Solve" button. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButtonSolve_Click(object sender, EventArgs e)
        {
            int delay = Convert.ToInt32(uxNumSeconds.Text);
            if (_discCount % 2 == 0)
            {
                Solve(PegB, PegC, delay);
            }
            else if (_discCount % 2 == 1)
            {
                Solve(PegC, PegB, delay);
            }
        }

        /// <summary>
        /// Button click event handler for "Move Left" on Peg A. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMoveLeft1_Click(object sender, EventArgs e)
        {
            MoveDisc(PegA, PegC);
        }

        /// <summary>
        /// Button click event handler for "Move Right" on Peg A. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMoveRight1_Click(object sender, EventArgs e)
        {
            MoveDisc(PegA, PegB);
        }

        /// <summary>
        /// Button click event handler for "Move Left" on Peg B.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMoveLeft2_Click(object sender, EventArgs e)
        {
            MoveDisc(PegB, PegA);
        }

        /// <summary>
        /// Button click event handler for "Move Right" on Peg B.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMoveRight2_Click(object sender, EventArgs e)
        {
            MoveDisc(PegB, PegC);
        }

        /// <summary>
        /// Button click event handler for "Move Left" on Peg C.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMoveLeft3_Click(object sender, EventArgs e)
        {
            MoveDisc(PegC, PegB);
        }

        /// <summary>
        /// Button click event handler for "Move Right" on Peg C. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMoveRight3_Click(object sender, EventArgs e)
        {
            MoveDisc(PegC, PegA);
        }

    }
}