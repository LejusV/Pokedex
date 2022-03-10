using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Cannot be disrupted by abilities.
	public class MoveSearingSunrazeSmash : Move
	{
		public MoveSearingSunrazeSmash() : base(
			"Searing-Sunraze-Smash",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, 200,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}