using System;
using System.Linq.Expressions;
using FakeItEasy;
using Microsoft.Xna.Framework.Input;
using Rotation.Controls;
using Rotation.Controls.Input;
using SubSpec;

namespace Rotation.GameObjects.sTests.GameSpecs
{
    public class KeyboardInputCollectorSpecs
    {
        [Specification]
        public void CanCorrectlyDetectAMoveDownKeyPress()
        {
            var keyboardInputCollector = default(KeyboardInputCollector);
            var result = default(ICommand);

            "Given I have pressed the key to move down on the keyboard".Context(() =>
                        {
                            var fakeKeyboardStateCollector = A.Fake<IKeyboardStateCollector>();
                            A.CallTo(() => fakeKeyboardStateCollector.GetKeyboardState())
                                .Returns(new KeyboardState(new[] { Keys.Down}));
                            keyboardInputCollector = new KeyboardInputCollector(fakeKeyboardStateCollector, A.Fake<IGameController>());
                        });

            "When I get the controller action".Do(() => result = keyboardInputCollector.Collect());

            "Then the action to call move down command should be returned".Observation(
                () => result.ShouldBeOfType<MoveDownCommand>());

        }

        [Specification]
        public void CanCorrectlyDetectAMoveUpKeyPress()
        {
			var keyboardInputCollector = default(KeyboardInputCollector);
			var result = default(ICommand); ;

            "Given I have pressed the key to move up on the keyboard".Context(() =>
            {
                var fakeKeyboardStateCollector = A.Fake<IKeyboardStateCollector>();
                A.CallTo(() => fakeKeyboardStateCollector.GetKeyboardState())
                    .Returns(new KeyboardState(new Keys[] { Keys.Up }));
				keyboardInputCollector = new KeyboardInputCollector(fakeKeyboardStateCollector, A.Fake<IGameController>());
            });

            "When I get the controller action".Do(() => result = keyboardInputCollector.Collect());

			"Then the action to call move up command should be returned".Observation(
				() => result.ShouldBeOfType<MoveUpCommand>());

        }

        [Specification]
        public void CanCorrectlyDetectAMoveLeftKeyPress()
        {
			var keyboardInputCollector = default(KeyboardInputCollector);
			var result = default(ICommand);

            "Given I have pressed the key to move left on the keyboard".Context(() =>
            {
                var fakeKeyboardStateCollector = A.Fake<IKeyboardStateCollector>();
                A.CallTo(() => fakeKeyboardStateCollector.GetKeyboardState())
                    .Returns(new KeyboardState(new Keys[] { Keys.Left }));
				keyboardInputCollector = new KeyboardInputCollector(fakeKeyboardStateCollector, A.Fake<IGameController>());
            });

            "When I get the controller action".Do(() => result = keyboardInputCollector.Collect());

			"Then the action to call move left command should be returned".Observation(
				() => result.ShouldBeOfType<MoveLeftCommand>());

        }

        [Specification]
        public void CanCorrectlyDetectAMoveRightKeyPress()
        {
			var keyboardInputCollector = default(KeyboardInputCollector);
			var result = default(ICommand);

            "Given I have pressed the key to move right on the keyboard".Context(() =>
            {
                var fakeKeyboardStateCollector = A.Fake<IKeyboardStateCollector>();
                A.CallTo(() => fakeKeyboardStateCollector.GetKeyboardState())
                    .Returns(new KeyboardState(new Keys[] { Keys.Right }));
				keyboardInputCollector = new KeyboardInputCollector(fakeKeyboardStateCollector, A.Fake<IGameController>());
            });

            "When I get the controller action".Do(() => result = keyboardInputCollector.Collect());

			"Then the action to call move right command should be returned".Observation(
				() => result.ShouldBeOfType<MoveRightCommand>());

        }

        [Specification]
        public void CanCorrectlyDetectARotateRightPress()
        {
			var keyboardInputCollector = default(KeyboardInputCollector);
			var result = default(ICommand);

            "Given I have pressed the key to rotate right on the keyboard".Context(() =>
            {
                var fakeKeyboardStateCollector = A.Fake<IKeyboardStateCollector>();
                A.CallTo(() => fakeKeyboardStateCollector.GetKeyboardState())
                    .Returns(new KeyboardState(new Keys[] { Keys.S }));
				keyboardInputCollector = new KeyboardInputCollector(fakeKeyboardStateCollector, A.Fake<IGameController>());
            });

            "When I get the controller action".Do(() => result = keyboardInputCollector.Collect());

			"Then the action to call rotate right command should be returned".Observation(
				() => result.ShouldBeOfType<RotateRightCommand>());

        }

        [Specification]
        public void CanCorrectlyDetectARotateLeftPress()
        {
			var keyboardInputCollector = default(KeyboardInputCollector);
			var result = default(ICommand);

            "Given I have pressed the key to rotate left on the keyboard".Context(() =>
            {
                var fakeKeyboardStateCollector = A.Fake<IKeyboardStateCollector>();
                A.CallTo(() => fakeKeyboardStateCollector.GetKeyboardState())
                    .Returns(new KeyboardState(new Keys[] { Keys.A }));
				keyboardInputCollector = new KeyboardInputCollector(fakeKeyboardStateCollector, A.Fake<IGameController>());
            });

            "When I get the controller action".Do(() => result = keyboardInputCollector.Collect());

			"Then the action to call rotate left command should be returned".Observation(
				() => result.ShouldBeOfType<RotateLeftCommand>());

        }

        [Specification]
        public void CanCorrectlyDetectNoKeysPressed()
        {
			var keyboardInputCollector = default(KeyboardInputCollector);
			var result = default(ICommand);

            "Given I have pressed the key to rotate left on the keyboard".Context(() =>
            {
                var fakeKeyboardStateCollector = A.Fake<IKeyboardStateCollector>();
                KeyboardState keyboardState = new KeyboardState(new Keys[] {});
                A.CallTo(() => fakeKeyboardStateCollector.GetKeyboardState()).Returns(keyboardState);
				keyboardInputCollector = new KeyboardInputCollector(fakeKeyboardStateCollector, A.Fake<IGameController>());
            });

            "When I get the controller action".Do(() => result = keyboardInputCollector.Collect());

            "Then null should be returned".Observation(
                () => result.ShouldBeNull());

        }
    }
}