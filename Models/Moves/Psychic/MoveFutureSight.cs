using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits the target two turns later.
	public class MoveFutureSight : Move
	{
#nullable enable
		private static MoveFutureSight? _instance = null;
#nullable restore
        public static MoveFutureSight Instance => _instance ?? (_instance = new MoveFutureSight());

		public MoveFutureSight() : base(
			"Future-Sight",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}