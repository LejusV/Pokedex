using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from using any moves that the user also knows.
	public class MoveImprison : Move
	{
#nullable enable
		private static MoveImprison? _instance = null;
#nullable restore
        public static MoveImprison Instance => _instance ?? (_instance = new MoveImprison());

		public MoveImprison() : base(
			"Imprison",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}