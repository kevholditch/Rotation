using Rotation.GameControl;

namespace Rotation.GameObjects.sTests.GameControlSpecs
{
    public class TestGameStartConditions : IGameStartConditions
    {
        public int StartRotations { get; set; }
        public int StartLevel { get; set; }
    }
}