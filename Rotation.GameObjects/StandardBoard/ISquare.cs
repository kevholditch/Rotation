using Rotation.GameObjects.Letters;

namespace Rotation.GameObjects.StandardBoard
{
    public interface ISquare
    {
        int XPos { get; }
        int YPos { get; }
        bool HasTile { get; }
        Letter Letter { get; }
    }
}