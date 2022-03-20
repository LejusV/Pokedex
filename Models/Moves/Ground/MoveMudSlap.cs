using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to lower the target's accuracy by one stage.
	public class MoveMudSlap : Move
	{
#nullable enable
		private static MoveMudSlap? _instance = null;
#nullable restore
        public static MoveMudSlap Instance => _instance ?? (_instance = new MoveMudSlap());

		public MoveMudSlap() : base(
			"Mud-Slap",
			Ground.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 20,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}