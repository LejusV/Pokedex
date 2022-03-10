using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveMeteorAssault : Move
	{
		public MoveMeteorAssault() : base(
			"Meteor-Assault",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 150,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}