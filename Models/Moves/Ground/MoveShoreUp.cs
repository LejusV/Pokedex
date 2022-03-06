using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Heals the user for ½ its max HP, or ⅔ during a sandstorm.
	public class MoveShoreUp : Move
	{
		public MoveShoreUp() : base(
			"Shore-Up",
			Ground.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}