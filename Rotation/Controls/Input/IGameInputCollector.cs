using System;
using System.Linq.Expressions;

namespace Rotation.Controls.Input
{
    public interface IGameInputCollector
    {
       Expression<Action<IGameController>> Collect();
    }

}