using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Special Defense by two stages.
	public class MoveAmnesia : Move
	{
#nullable enable
		private static MoveAmnesia? _instance = null;
#nullable restore
        public static MoveAmnesia Instance => _instance ?? (_instance = new MoveAmnesia());

		public MoveAmnesia() : base(
			"Amnesia",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}