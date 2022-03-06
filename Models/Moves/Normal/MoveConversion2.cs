using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Changes the user's type to a random type either resistant or immune to the last move used against it.
	public class MoveConversion2 : Move
	{
		public MoveConversion2() : base(
			"Conversion-2",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}