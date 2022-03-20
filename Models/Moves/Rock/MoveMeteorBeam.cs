using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMeteorBeam : Move
	{
#nullable enable
		private static MoveMeteorBeam? _instance = null;
#nullable restore
        public static MoveMeteorBeam Instance => _instance ?? (_instance = new MoveMeteorBeam());

		public MoveMeteorBeam() : base(
			"Meteor-Beam",
			Rock.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 120,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}