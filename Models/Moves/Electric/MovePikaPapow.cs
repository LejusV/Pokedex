using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePikaPapow : Move
	{
#nullable enable
		private static MovePikaPapow? _instance = null;
#nullable restore
        public static MovePikaPapow Instance => _instance ?? (_instance = new MovePikaPapow());

		public MovePikaPapow() : base(
			"Pika-Papow",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}