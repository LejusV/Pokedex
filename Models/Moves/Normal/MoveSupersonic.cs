using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Confuses the target.
	public class MoveSupersonic : Move
	{
#nullable enable
		private static MoveSupersonic? _instance = null;
#nullable restore
        public static MoveSupersonic Instance => _instance ?? (_instance = new MoveSupersonic());

		public MoveSupersonic() : base(
			"Supersonic",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			55, 0 // Acc & Priority
		) {}
	}
}