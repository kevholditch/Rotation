namespace Rotation.Drawing.Animations
{
    public interface IAnimation
    {
        bool Finished();
        void Animate();
        void OnFinished();
    }
}
