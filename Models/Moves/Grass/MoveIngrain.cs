using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the user from leaving battle.  User regains 1/16 of its max HP every turn.
	public class MoveIngrain : Move
	{
		public MoveIngrain() : base(
			"Ingrain",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}