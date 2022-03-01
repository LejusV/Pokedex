using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Power varies randomly from 10 to 150.
	public class MoveMagnitude : Move
	{
		public MoveMagnitude() : base(
			"Magnitude",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}