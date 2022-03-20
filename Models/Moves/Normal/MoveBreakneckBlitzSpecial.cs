using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBreakneckBlitzSpecial : Move
	{
#nullable enable
		private static MoveBreakneckBlitzSpecial? _instance = null;
#nullable restore
        public static MoveBreakneckBlitzSpecial Instance => _instance ?? (_instance = new MoveBreakneckBlitzSpecial());

		public MoveBreakneckBlitzSpecial() : base(
			"Breakneck-Blitz--Special",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}