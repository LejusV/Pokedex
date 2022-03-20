using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has double power if a friendly Pokémon fainted last turn.
	public class MoveRetaliate : Move
	{
#nullable enable
		private static MoveRetaliate? _instance = null;
#nullable restore
        public static MoveRetaliate Instance => _instance ?? (_instance = new MoveRetaliate());

		public MoveRetaliate() : base(
			"Retaliate",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}