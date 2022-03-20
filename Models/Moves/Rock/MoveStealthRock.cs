using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Causes damage when opposing Pokémon switch in.
	public class MoveStealthRock : Move
	{
#nullable enable
		private static MoveStealthRock? _instance = null;
#nullable restore
        public static MoveStealthRock Instance => _instance ?? (_instance = new MoveStealthRock());

		public MoveStealthRock() : base(
			"Stealth-Rock",
			Rock.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}