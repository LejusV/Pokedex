using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage and can hit Pokémon in the air.
	public class MoveGust : Move
	{
		public MoveGust() : base(
			"Gust",
			Flying.Instance, // Move Type
			MoveCategory.Special, // Move Category
			35, 40,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}