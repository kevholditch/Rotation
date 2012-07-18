﻿using System;
using Rotation.GameObjects.Events;

namespace Rotation.GameObjects.sTests.TestClasses
{
    public class ActionEventDispatcher : IGameEventDispatcher
    {
        private Action<IGameEvent> _action;

        public ActionEventDispatcher(Action<IGameEvent> action)
        {
            _action = action;
        }


        public void Dispatch(IGameEvent gameEvent)
        {
            _action(gameEvent);
        }
    }

    
}
