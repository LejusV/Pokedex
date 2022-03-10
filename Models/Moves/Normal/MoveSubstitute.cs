using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Transfers 1/4 of the user's max HP into a doll, protecting the user from further damage or status changes until it breaks.
	public class MoveSubstitute : Move
	{
		public MoveSubstitute() : base(
			"Substitute",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}