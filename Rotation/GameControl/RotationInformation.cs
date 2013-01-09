namespace Rotation.GameControl
{
    public class RotationInformation : IRotationInformation
    {
        public int RotationsLeft { get; private set; }

        public RotationInformation(int rotationsLeft)
        {
            RotationsLeft = rotationsLeft;
        }
    }
}