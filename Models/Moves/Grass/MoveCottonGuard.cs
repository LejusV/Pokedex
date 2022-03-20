using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Defense by three stages.
	public class MoveCottonGuard : Move
	{
#nullable enable
		private static MoveCottonGuard? _instance = null;
#nullable restore
        public static MoveCottonGuard Instance => _instance ?? (_instance = new MoveCottonGuard());

		public MoveCottonGuard() : base(
			"Cotton-Guard",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}