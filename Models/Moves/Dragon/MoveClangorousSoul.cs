using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveClangorousSoul : Move
	{
#nullable enable
		private static MoveClangorousSoul? _instance = null;
#nullable restore
        public static MoveClangorousSoul Instance => _instance ?? (_instance = new MoveClangorousSoul());

		public MoveClangorousSoul() : base(
			"Clangorous-Soul",
			Dragon.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}