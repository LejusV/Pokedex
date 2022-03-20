using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveBulletSeed : Move
	{
#nullable enable
		private static MoveBulletSeed? _instance = null;
#nullable restore
        public static MoveBulletSeed Instance => _instance ?? (_instance = new MoveBulletSeed());

		public MoveBulletSeed() : base(
			"Bullet-Seed",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 25,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}