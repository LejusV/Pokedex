using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Immediately ends wild battles.  Forces trainers to switch Pokémon.
	public class MoveRoar : Move
	{
		public MoveRoar() : base(
			"Roar",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, -6 // Acc & Priority
			
		) {}
	}
}