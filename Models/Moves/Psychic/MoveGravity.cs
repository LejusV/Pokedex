using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Disables moves and immunities that involve flying or levitating for five turns.
	public class MoveGravity : Move
	{
#nullable enable
		private static MoveGravity? _instance = null;
#nullable restore
        public static MoveGravity Instance => _instance ?? (_instance = new MoveGravity());

		public MoveGravity() : base(
			"Gravity",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}