using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to poison the target.
	public class MoveGunkShot : Move
	{
#nullable enable
		private static MoveGunkShot? _instance = null;
#nullable restore
        public static MoveGunkShot Instance => _instance ?? (_instance = new MoveGunkShot());

		public MoveGunkShot() : base(
			"Gunk-Shot",
			Poison.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 120,// PP & Pow
			80, 0 // Acc & Priority
		) {}
	}
}