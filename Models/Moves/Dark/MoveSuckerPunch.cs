using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Only works if the target is about to use a damaging move.
	public class MoveSuckerPunch : Move
	{
#nullable enable
		private static MoveSuckerPunch? _instance = null;
#nullable restore
        public static MoveSuckerPunch Instance => _instance ?? (_instance = new MoveSuckerPunch());

		public MoveSuckerPunch() : base(
			"Sucker-Punch",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 70,// PP & Pow
			100, 1 // Acc & Priority
		) {}
	}
}