using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBrutalSwing : Move
	{
#nullable enable
		private static MoveBrutalSwing? _instance = null;
#nullable restore
        public static MoveBrutalSwing Instance => _instance ?? (_instance = new MoveBrutalSwing());

		public MoveBrutalSwing() : base(
			"Brutal-Swing",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}