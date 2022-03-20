using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack and accuracy by one stage.
	public class MoveHoneClaws : Move
	{
#nullable enable
		private static MoveHoneClaws? _instance = null;
#nullable restore
        public static MoveHoneClaws Instance => _instance ?? (_instance = new MoveHoneClaws());

		public MoveHoneClaws() : base(
			"Hone-Claws",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}