using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to paralyze the target.
	public class MoveNuzzle : Move
	{
#nullable enable
		private static MoveNuzzle? _instance = null;
#nullable restore
        public static MoveNuzzle Instance => _instance ?? (_instance = new MoveNuzzle());

		public MoveNuzzle() : base(
			"Nuzzle",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 20,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}