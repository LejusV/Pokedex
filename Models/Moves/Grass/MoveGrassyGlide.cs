using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveGrassyGlide : Move
	{
#nullable enable
		private static MoveGrassyGlide? _instance = null;
#nullable restore
        public static MoveGrassyGlide Instance => _instance ?? (_instance = new MoveGrassyGlide());

		public MoveGrassyGlide() : base(
			"Grassy-Glide",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}