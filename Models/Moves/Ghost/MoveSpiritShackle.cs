using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Traps the target.
	public class MoveSpiritShackle : Move
	{
#nullable enable
		private static MoveSpiritShackle? _instance = null;
#nullable restore
        public static MoveSpiritShackle Instance => _instance ?? (_instance = new MoveSpiritShackle());

		public MoveSpiritShackle() : base(
			"Spirit-Shackle",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}