using Rotation.Constants;

namespace Rotation.GameControl
{
    public class GameStartConditions : IGameStartConditions
    {
        public int StartRotations 
        {
            get { return GameConstants.GamePlay.START_ROTATIONS; }
        }

        public int StartLevel { get { return 1; } }
    }
}