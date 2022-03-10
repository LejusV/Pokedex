using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Reduces damage five turns, but must be used during hail.
	public class MoveAuroraVeil : Move
	{
		public MoveAuroraVeil() : base(
			"Aurora-Veil",
			Ice.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}