using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Target loses 1/4 its max HP every turn as long as it's asleep.
	public class MoveNightmare : Move
	{
#nullable enable
		private static MoveNightmare? _instance = null;
#nullable restore
        public static MoveNightmare Instance => _instance ?? (_instance = new MoveNightmare());

		public MoveNightmare() : base(
			"Nightmare",
			Ghost.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}