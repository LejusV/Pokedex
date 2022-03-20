using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Target cannot use held items.
	public class MoveEmbargo : Move
	{
#nullable enable
		private static MoveEmbargo? _instance = null;
#nullable restore
        public static MoveEmbargo Instance => _instance ?? (_instance = new MoveEmbargo());

		public MoveEmbargo() : base(
			"Embargo",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}