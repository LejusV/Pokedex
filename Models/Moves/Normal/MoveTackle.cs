using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveTackle : Move
	{
#nullable enable
		private static MoveTackle? _instance = null;
#nullable restore
        public static MoveTackle Instance => _instance ?? (_instance = new MoveTackle());

		public MoveTackle() : base(
			"Tackle",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			35, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}