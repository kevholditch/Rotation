using Rotation.GameObjects;
using Rotation.GameObjects.Factories;
using SubSpec;
using Xunit;

namespace Rotation.Tests.BoxFactorySpecs
{
	public class VowelBoxFactorySpecs
	{		
		public void GenerateAVowelBox()
		{
			VowelBoxFactory _vowelBoxFactory = null;
			Box _result = null;

			"Given I have a vowel box factory".Context(() => _vowelBoxFactory = new VowelBoxFactory());

			"When I create a new vowel box".Do(() => _result = _vowelBoxFactory.Create());

			"Then the vowel box factory should create a new vowel box".Observation(() => Assert.IsType<VowelBox>(_result));
		}
	}
}