using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Speed by one stage.
	public class MoveGlaciate : Move
	{
#nullable enable
		private static MoveGlaciate? _instance = null;
#nullable restore
        public static MoveGlaciate Instance => _instance ?? (_instance = new MoveGlaciate());

		public MoveGlaciate() : base(
			"Glaciate",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 65,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}