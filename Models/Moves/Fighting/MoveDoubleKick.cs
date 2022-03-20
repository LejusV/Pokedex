using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits twice in one turn.
	public class MoveDoubleKick : Move
	{
#nullable enable
		private static MoveDoubleKick? _instance = null;
#nullable restore
        public static MoveDoubleKick Instance => _instance ?? (_instance = new MoveDoubleKick());

		public MoveDoubleKick() : base(
			"Double-Kick",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 30,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}