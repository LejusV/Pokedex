using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Takes the target's item.
	public class MoveCovet : Move
	{
#nullable enable
		private static MoveCovet? _instance = null;
#nullable restore
        public static MoveCovet Instance => _instance ?? (_instance = new MoveCovet());

		public MoveCovet() : base(
			"Covet",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}