using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSeedBomb : Move
	{
#nullable enable
		private static MoveSeedBomb? _instance = null;
#nullable restore
        public static MoveSeedBomb Instance => _instance ?? (_instance = new MoveSeedBomb());

		public MoveSeedBomb() : base(
			"Seed-Bomb",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}