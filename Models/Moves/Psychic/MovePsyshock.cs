using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts damage based on the target's Defense, not Special Defense.
	public class MovePsyshock : Move
	{
#nullable enable
		private static MovePsyshock? _instance = null;
#nullable restore
        public static MovePsyshock Instance => _instance ?? (_instance = new MovePsyshock());

		public MovePsyshock() : base(
			"Psyshock",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}