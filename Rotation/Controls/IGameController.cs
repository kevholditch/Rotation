namespace Rotation.Controls
{
    public interface IGameController
    {
        void SelectSquare(int x, int y);
        void MoveSelectionUp();
        void MoveSelectionDown();
        void MoveSelectionLeft();
        void MoveSelectionRight();
        void RotateRight();
        void RotateLeft();
        void Initialise();
    }

}