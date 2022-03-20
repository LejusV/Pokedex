using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveLifeDew : Move
	{
#nullable enable
		private static MoveLifeDew? _instance = null;
#nullable restore
        public static MoveLifeDew Instance => _instance ?? (_instance = new MoveLifeDew());

		public MoveLifeDew() : base(
			"Life-Dew",
			Water.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}