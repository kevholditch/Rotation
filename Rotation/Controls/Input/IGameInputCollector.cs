using System;

namespace Rotation.Controls.Input
{
    public interface IGameInputCollector
    {
        Action<IGameController> PrimeControllerAction();
    }

    public class KeyboardInputCollector : IGameInputCollector
    {
        public Action<IGameController> PrimeControllerAction()
        {
            return c => c.MoveSelectionDown();
        }
    }

    public class test
    {
        public void Check()
        {
            KeyboardInputCollector k = new KeyboardInputCollector();

            var act = k.PrimeControllerAction();

            
        }
    }
}