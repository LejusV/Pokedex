using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's HP to equal the user's.
	public class MoveEndeavor : Move
	{
#nullable enable
		private static MoveEndeavor? _instance = null;
#nullable restore
        public static MoveEndeavor Instance => _instance ?? (_instance = new MoveEndeavor());

		public MoveEndeavor() : base(
			"Endeavor",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}