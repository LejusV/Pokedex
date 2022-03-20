using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack and Speed by one stage.
	public class MoveDragonDance : Move
	{
#nullable enable
		private static MoveDragonDance? _instance = null;
#nullable restore
        public static MoveDragonDance Instance => _instance ?? (_instance = new MoveDragonDance());

		public MoveDragonDance() : base(
			"Dragon-Dance",
			Dragon.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}