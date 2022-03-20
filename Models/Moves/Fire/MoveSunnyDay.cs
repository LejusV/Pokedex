using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Changes the weather to sunny for five turns.
	public class MoveSunnyDay : Move
	{
#nullable enable
		private static MoveSunnyDay? _instance = null;
#nullable restore
        public static MoveSunnyDay Instance => _instance ?? (_instance = new MoveSunnyDay());

		public MoveSunnyDay() : base(
			"Sunny-Day",
			Fire.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}