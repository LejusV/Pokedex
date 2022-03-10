using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Power and type depend on the held berry.
	public class MoveNaturalGift : Move
	{
		public MoveNaturalGift() : base(
			"Natural-Gift",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}