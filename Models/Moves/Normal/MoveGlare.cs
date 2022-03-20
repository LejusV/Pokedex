using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Paralyzes the target.
	public class MoveGlare : Move
	{
#nullable enable
		private static MoveGlare? _instance = null;
#nullable restore
        public static MoveGlare Instance => _instance ?? (_instance = new MoveGlare());

		public MoveGlare() : base(
			"Glare",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}