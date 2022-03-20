using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts a burn on any Pokémon that makes contact before the attack.
	public class MoveBeakBlast : Move
	{
#nullable enable
		private static MoveBeakBlast? _instance = null;
#nullable restore
        public static MoveBeakBlast Instance => _instance ?? (_instance = new MoveBeakBlast());

		public MoveBeakBlast() : base(
			"Beak-Blast",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 100,// PP & Pow
			100, -3 // Acc & Priority
		) {}
	}
}