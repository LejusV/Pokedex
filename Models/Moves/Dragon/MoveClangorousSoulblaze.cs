using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts damage to all opposing Pokémon and increases the user's Attack, Defense, Special Attack, Special Defense, and Speed by one stage each.
	public class MoveClangorousSoulblaze : Move
	{
#nullable enable
		private static MoveClangorousSoulblaze? _instance = null;
#nullable restore
        public static MoveClangorousSoulblaze Instance => _instance ?? (_instance = new MoveClangorousSoulblaze());

		public MoveClangorousSoulblaze() : base(
			"Clangorous-Soulblaze",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, 185,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}