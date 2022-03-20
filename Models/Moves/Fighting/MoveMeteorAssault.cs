using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveMeteorAssault : Move
	{
#nullable enable
		private static MoveMeteorAssault? _instance = null;
#nullable restore
        public static MoveMeteorAssault Instance => _instance ?? (_instance = new MoveMeteorAssault());

		public MoveMeteorAssault() : base(
			"Meteor-Assault",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 150,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}