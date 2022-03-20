using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to make the target flinch.
	public class MoveExtrasensory : Move
	{
#nullable enable
		private static MoveExtrasensory? _instance = null;
#nullable restore
        public static MoveExtrasensory Instance => _instance ?? (_instance = new MoveExtrasensory());

		public MoveExtrasensory() : base(
			"Extrasensory",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}