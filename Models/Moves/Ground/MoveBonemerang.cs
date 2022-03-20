using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits twice in one turn.
	public class MoveBonemerang : Move
	{
#nullable enable
		private static MoveBonemerang? _instance = null;
#nullable restore
        public static MoveBonemerang Instance => _instance ?? (_instance = new MoveBonemerang());

		public MoveBonemerang() : base(
			"Bonemerang",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 50,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}