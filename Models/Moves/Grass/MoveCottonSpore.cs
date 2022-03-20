using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Speed by two stages.
	public class MoveCottonSpore : Move
	{
#nullable enable
		private static MoveCottonSpore? _instance = null;
#nullable restore
        public static MoveCottonSpore Instance => _instance ?? (_instance = new MoveCottonSpore());

		public MoveCottonSpore() : base(
			"Cotton-Spore",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}