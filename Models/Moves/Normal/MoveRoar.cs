using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Immediately ends wild battles.  Forces trainers to switch Pokémon.
	public class MoveRoar : Move
	{
#nullable enable
		private static MoveRoar? _instance = null;
#nullable restore
        public static MoveRoar Instance => _instance ?? (_instance = new MoveRoar());

		public MoveRoar() : base(
			"Roar",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, -6 // Acc & Priority
		) {}
	}
}