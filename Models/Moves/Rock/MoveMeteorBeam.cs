using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMeteorBeam : Move
	{
		public MoveMeteorBeam() : base(
			"Meteor-Beam",
			Rock.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 120,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}