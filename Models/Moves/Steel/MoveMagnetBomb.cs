using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveMagnetBomb : Move
	{
#nullable enable
		private static MoveMagnetBomb? _instance = null;
#nullable restore
        public static MoveMagnetBomb Instance => _instance ?? (_instance = new MoveMagnetBomb());

		public MoveMagnetBomb() : base(
			"Magnet-Bomb",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}