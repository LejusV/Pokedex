using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveSpacialRend : Move
	{
#nullable enable
		private static MoveSpacialRend? _instance = null;
#nullable restore
        public static MoveSpacialRend Instance => _instance ?? (_instance = new MoveSpacialRend());

		public MoveSpacialRend() : base(
			"Spacial-Rend",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 100,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}