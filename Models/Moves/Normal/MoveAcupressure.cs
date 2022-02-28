using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Raises one of a friendly Pokémon's stats at random by two stages.
	public class MoveAcupressure : Move
	{
		public MoveAcupressure() : base(
			"Acupressure",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}