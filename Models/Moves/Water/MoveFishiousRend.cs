using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveFishiousRend : Move
	{
#nullable enable
		private static MoveFishiousRend? _instance = null;
#nullable restore
        public static MoveFishiousRend Instance => _instance ?? (_instance = new MoveFishiousRend());

		public MoveFishiousRend() : base(
			"Fishious-Rend",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 85,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}