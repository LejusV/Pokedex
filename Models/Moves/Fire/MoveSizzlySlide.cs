using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSizzlySlide : Move
	{
#nullable enable
		private static MoveSizzlySlide? _instance = null;
#nullable restore
        public static MoveSizzlySlide Instance => _instance ?? (_instance = new MoveSizzlySlide());

		public MoveSizzlySlide() : base(
			"Sizzly-Slide",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}