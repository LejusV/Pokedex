using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to raise the user's Attack by one stage.
	public class MoveMeteorMash : Move
	{
#nullable enable
		private static MoveMeteorMash? _instance = null;
#nullable restore
        public static MoveMeteorMash Instance => _instance ?? (_instance = new MoveMeteorMash());

		public MoveMeteorMash() : base(
			"Meteor-Mash",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 90,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}