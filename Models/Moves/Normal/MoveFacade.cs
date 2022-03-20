using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power doubles if user is burned, paralyzed, or poisoned.
	public class MoveFacade : Move
	{
#nullable enable
		private static MoveFacade? _instance = null;
#nullable restore
        public static MoveFacade Instance => _instance ?? (_instance = new MoveFacade());

		public MoveFacade() : base(
			"Facade",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}