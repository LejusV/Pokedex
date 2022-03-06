using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack by one stage after inflicting damage.
	public class MoveTropKick : Move
	{
		public MoveTropKick() : base(
			"Trop-Kick",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}