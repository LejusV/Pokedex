using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveZingZap : Move
	{
#nullable enable
		private static MoveZingZap? _instance = null;
#nullable restore
        public static MoveZingZap Instance => _instance ?? (_instance = new MoveZingZap());

		public MoveZingZap() : base(
			"Zing-Zap",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}