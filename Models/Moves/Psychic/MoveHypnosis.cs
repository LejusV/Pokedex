using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Puts the target to sleep.
	public class MoveHypnosis : Move
	{
#nullable enable
		private static MoveHypnosis? _instance = null;
#nullable restore
        public static MoveHypnosis Instance => _instance ?? (_instance = new MoveHypnosis());

		public MoveHypnosis() : base(
			"Hypnosis",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			60, 0 // Acc & Priority
		) {}
	}
}