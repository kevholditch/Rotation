using System;
using System.Linq.Expressions;

namespace Rotation.Controls.Input
{
    public interface IGameInputCollector
    {
       ICommand Collect();
    }

}