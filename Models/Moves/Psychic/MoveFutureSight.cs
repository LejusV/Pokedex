using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Hits the target two turns later.
	public class MoveFutureSight : Move
	{
		public MoveFutureSight() : base(
			"Future-Sight",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 120,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}