using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 50% chance to burn the target.  Lets frozen Pokémon thaw themselves.
	public class MoveSacredFire : Move
	{
#nullable enable
		private static MoveSacredFire? _instance = null;
#nullable restore
        public static MoveSacredFire Instance => _instance ?? (_instance = new MoveSacredFire());

		public MoveSacredFire() : base(
			"Sacred-Fire",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}