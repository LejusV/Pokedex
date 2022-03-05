using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to raise the user's Attack by one stage.
	public class MoveMeteorMash : Move
	{
		public MoveMeteorMash() : base(
			"Meteor-Mash",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 90,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}