using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveAirCutter : Move
	{
		public MoveAirCutter() : base(
			"Air-Cutter",
			Flying.Instance, // Move Type
			MoveCategory.Special, // Move Category
			25, 60,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}