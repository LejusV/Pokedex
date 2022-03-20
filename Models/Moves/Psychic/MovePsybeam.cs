using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to confuse the target.
	public class MovePsybeam : Move
	{
#nullable enable
		private static MovePsybeam? _instance = null;
#nullable restore
        public static MovePsybeam Instance => _instance ?? (_instance = new MovePsybeam());

		public MovePsybeam() : base(
			"Psybeam",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}