using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts more damage to heavier targets, with a maximum of 120 power.
	public class MoveLowKick : Move
	{
		public MoveLowKick() : base(
			"Low-Kick",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}