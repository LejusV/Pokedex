using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack and Special Attack by one stage each.
	public class MoveWorkUp : Move
	{
#nullable enable
		private static MoveWorkUp? _instance = null;
#nullable restore
        public static MoveWorkUp Instance => _instance ?? (_instance = new MoveWorkUp());

		public MoveWorkUp() : base(
			"Work-Up",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}