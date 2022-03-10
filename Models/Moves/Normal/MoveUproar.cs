using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Forced to use this move for several turns.  Pokémon cannot fall asleep in that time.
	public class MoveUproar : Move
	{
		public MoveUproar() : base(
			"Uproar",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}