using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to paralyze the target.
	public class MoveSpark : Move
	{
#nullable enable
		private static MoveSpark? _instance = null;
#nullable restore
        public static MoveSpark Instance => _instance ?? (_instance = new MoveSpark());

		public MoveSpark() : base(
			"Spark",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}