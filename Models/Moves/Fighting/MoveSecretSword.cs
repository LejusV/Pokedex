using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts damage based on the target's Defense, not Special Defense.
	public class MoveSecretSword : Move
	{
#nullable enable
		private static MoveSecretSword? _instance = null;
#nullable restore
        public static MoveSecretSword Instance => _instance ?? (_instance = new MoveSecretSword());

		public MoveSecretSword() : base(
			"Secret-Sword",
			Fighting.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 85,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}