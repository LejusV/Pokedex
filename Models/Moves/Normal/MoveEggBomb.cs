using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveEggBomb : Move
	{
#nullable enable
		private static MoveEggBomb? _instance = null;
#nullable restore
        public static MoveEggBomb Instance => _instance ?? (_instance = new MoveEggBomb());

		public MoveEggBomb() : base(
			"Egg-Bomb",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			75, 0 // Acc & Priority
		) {}
	}
}