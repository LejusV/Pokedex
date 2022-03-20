using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Defense by one stage.
	public class MoveTailWhip : Move
	{
#nullable enable
		private static MoveTailWhip? _instance = null;
#nullable restore
        public static MoveTailWhip Instance => _instance ?? (_instance = new MoveTailWhip());

		public MoveTailWhip() : base(
			"Tail-Whip",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}