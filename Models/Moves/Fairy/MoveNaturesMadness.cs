using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts damage equal to half the target's HP.
	public class MoveNaturesMadness : Move
	{
#nullable enable
		private static MoveNaturesMadness? _instance = null;
#nullable restore
        public static MoveNaturesMadness Instance => _instance ?? (_instance = new MoveNaturesMadness());

		public MoveNaturesMadness() : base(
			"Natures-Madness",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, null,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}