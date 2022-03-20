using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power is higher the more the user's stats have been raised, to a maximum of 31×.
	public class MovePowerTrip : Move
	{
#nullable enable
		private static MovePowerTrip? _instance = null;
#nullable restore
        public static MovePowerTrip Instance => _instance ?? (_instance = new MovePowerTrip());

		public MovePowerTrip() : base(
			"Power-Trip",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 20,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}