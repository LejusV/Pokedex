using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts damage, and the user takes damage equal to half of its max HP, rounded up.
	public class MoveMindBlown : Move
	{
		public MoveMindBlown() : base(
			"Mind-Blown",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}