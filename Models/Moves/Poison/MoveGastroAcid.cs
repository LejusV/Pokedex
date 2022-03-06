using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Nullifies target's ability until it leaves battle.
	public class MoveGastroAcid : Move
	{
		public MoveGastroAcid() : base(
			"Gastro-Acid",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}