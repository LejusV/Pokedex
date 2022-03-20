using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Halves all Electric-type damage.
	public class MoveMudSport : Move
	{
#nullable enable
		private static MoveMudSport? _instance = null;
#nullable restore
        public static MoveMudSport Instance => _instance ?? (_instance = new MoveMudSport());

		public MoveMudSport() : base(
			"Mud-Sport",
			Ground.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}