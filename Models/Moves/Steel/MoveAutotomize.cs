using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Speed by two stages and halves the user's weight.
	public class MoveAutotomize : Move
	{
#nullable enable
		private static MoveAutotomize? _instance = null;
#nullable restore
        public static MoveAutotomize Instance => _instance ?? (_instance = new MoveAutotomize());

		public MoveAutotomize() : base(
			"Autotomize",
			Steel.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}