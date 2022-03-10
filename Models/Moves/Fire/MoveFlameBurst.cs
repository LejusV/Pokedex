using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Deals splash damage to Pokémon next to the target.
	public class MoveFlameBurst : Move
	{
		public MoveFlameBurst() : base(
			"Flame-Burst",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}