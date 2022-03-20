using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to burn the target.
	public class MoveLavaPlume : Move
	{
#nullable enable
		private static MoveLavaPlume? _instance = null;
#nullable restore
        public static MoveLavaPlume Instance => _instance ?? (_instance = new MoveLavaPlume());

		public MoveLavaPlume() : base(
			"Lava-Plume",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}