using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveScratch : Move
	{
#nullable enable
		private static MoveScratch? _instance = null;
#nullable restore
        public static MoveScratch Instance => _instance ?? (_instance = new MoveScratch());

		public MoveScratch() : base(
			"Scratch",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			35, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}