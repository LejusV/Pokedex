using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Protects the user's stats from being changed by enemy moves.
	public class MoveMist : Move
	{
		public MoveMist() : base(
			"Mist",
			Ice.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}