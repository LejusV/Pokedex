using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts damage based on the target's Defense, not Special Defense.
	public class MoveSecretSword : Move
	{
		public MoveSecretSword() : base(
			"Secret-Sword",
			Fighting.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 85,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}