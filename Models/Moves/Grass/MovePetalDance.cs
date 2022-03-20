using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits every turn for 2-3 turns, then confuses the user.
	public class MovePetalDance : Move
	{
#nullable enable
		private static MovePetalDance? _instance = null;
#nullable restore
        public static MovePetalDance Instance => _instance ?? (_instance = new MovePetalDance());

		public MovePetalDance() : base(
			"Petal-Dance",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}