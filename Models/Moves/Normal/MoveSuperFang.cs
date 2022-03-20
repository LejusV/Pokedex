using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts damage equal to half the target's HP.
	public class MoveSuperFang : Move
	{
#nullable enable
		private static MoveSuperFang? _instance = null;
#nullable restore
        public static MoveSuperFang Instance => _instance ?? (_instance = new MoveSuperFang());

		public MoveSuperFang() : base(
			"Super-Fang",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, null,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}