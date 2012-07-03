using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FakeItEasy;
using Rotation.GameObjects.Drawing;
using Rotation.GameObjects.Drawing.ItemAnimators;
using SubSpec;
using Rotation.Tests.Common;

namespace Rotation.Drawing.Tests.FactorySpecs
{
    public class ItemAnimatorFactorySpecs
    {
        [Specification]
        public void CanCorrectlyGetARotationAnimator()
        {
            var itemAnimatorFactory = default(ItemAnimatorFactory);
            var result = default(IEnumerable<IItemAnimator>);


            "Given that I have an item animator factory that can animate items of IRotationAnimationItem".Context(
                () => itemAnimatorFactory = new ItemAnimatorFactory(new List<IItemAnimator> {new RotationAnimator()}));


            "When I call create with a rotation animation item".Do(() => result = itemAnimatorFactory.Create(A.Fake<IRotationAnimationItem>()));

            "Then one item should be returned".Observation(() => result.Count().ShouldEqual(1));

            "Then the returned item should be of type RotationAnimator".Observation(
                () => result.First().ShouldBeOfType<RotationAnimator>());

        }


        
       
    }
}
