using System.Drawing.Text;

namespace GADE
{
    public partial class Form1 : Form
    {
        private Game_Engine GameEngine;

        public Form1()
        {
            InitializeComponent();
            this.GameEngine = new Game_Engine(10);

            UpdateDisplay();
        }

        public void UpdateDisplay()
        {

            Game_Engine game_Engine = GameEngine;
            displayLabel.Text = game_Engine.ToString();
        }
        enum Direction { Up, Right, Down, Left }

        private void upButton_Click(object sender, EventArgs e)
        {
            GameEngine.TriggerMovement(Game_Engine.Direction.Up);
            UpdateDisplay() ;

        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            GameEngine.TriggerMovement(Game_Engine.Direction.Right);
            UpdateDisplay();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            GameEngine.TriggerMovement(Game_Engine.Direction.Down);
            UpdateDisplay();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            GameEngine.TriggerMovement(Game_Engine.Direction.Left);
            UpdateDisplay();
        }




        /*   private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { e.Handled = true; }

            Direction direction = Game_Engine.Direction;
            GameEngine.TriggerMovement(Direction direction);

        }   */


    }
}
