using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User switches places with the friendly Pokémon opposite it.
	public class MoveAllySwitch : Move
	{
		public MoveAllySwitch() : base(
			"Ally-Switch",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 2 // Acc & Priority
			
		) {}
	}
}