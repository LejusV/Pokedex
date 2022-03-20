using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePeck : Move
	{
#nullable enable
		private static MovePeck? _instance = null;
#nullable restore
        public static MovePeck Instance => _instance ?? (_instance = new MovePeck());

		public MovePeck() : base(
			"Peck",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			35, 35,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}