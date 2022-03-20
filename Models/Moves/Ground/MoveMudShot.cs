using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to lower the target's Speed by one stage.
	public class MoveMudShot : Move
	{
#nullable enable
		private static MoveMudShot? _instance = null;
#nullable restore
        public static MoveMudShot Instance => _instance ?? (_instance = new MoveMudShot());

		public MoveMudShot() : base(
			"Mud-Shot",
			Ground.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 55,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}