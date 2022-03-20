using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User recovers the item it last used up.
	public class MoveRecycle : Move
	{
#nullable enable
		private static MoveRecycle? _instance = null;
#nullable restore
        public static MoveRecycle Instance => _instance ?? (_instance = new MoveRecycle());

		public MoveRecycle() : base(
			"Recycle",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}