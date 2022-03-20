using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the user's Special Attack by two stages after inflicting damage.
	public class MovePsychoBoost : Move
	{
#nullable enable
		private static MovePsychoBoost? _instance = null;
#nullable restore
        public static MovePsychoBoost Instance => _instance ?? (_instance = new MovePsychoBoost());

		public MovePsychoBoost() : base(
			"Psycho-Boost",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 140,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}