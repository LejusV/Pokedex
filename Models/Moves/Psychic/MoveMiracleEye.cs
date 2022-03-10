using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Forces the target to have no evasion, and allows it to be hit by Psychic moves even if it's Dark.
	public class MoveMiracleEye : Move
	{
		public MoveMiracleEye() : base(
			"Miracle-Eye",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}