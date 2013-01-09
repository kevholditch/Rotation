using System.Collections.Generic;
using Rotation.Blocks;
using Rotation.Constants;
using System.Linq;

namespace Rotation.GameControl
{
    public class RotationManager : IRotationManager
    {

        private IRotationInformation _rotationInformation;

        public RotationManager(IGameStartConditions gameStartConditions)
        {
            _rotationInformation = new RotationInformation(gameStartConditions.StartRotations);
        }

        public void RotationMade()
        {
            _rotationInformation = new RotationInformation(_rotationInformation.RotationsLeft - 1);
        }

        public void BlocksFound(IEnumerable<Block> blocks)
        {
            var squaresFound = blocks.SelectMany(b => b.BoardCoordinates).Count();

            _rotationInformation = new RotationInformation(_rotationInformation.RotationsLeft + squaresFound);
        }

        public IRotationInformation GetRotationInformation()
        {
            return _rotationInformation;
        }
    }
}