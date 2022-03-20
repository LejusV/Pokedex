using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to confuse the target.
	public class MoveConfusion : Move
	{
#nullable enable
		private static MoveConfusion? _instance = null;
#nullable restore
        public static MoveConfusion Instance => _instance ?? (_instance = new MoveConfusion());

		public MoveConfusion() : base(
			"Confusion",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			25, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}