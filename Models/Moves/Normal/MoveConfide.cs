using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Special Attack by one stage.
	public class MoveConfide : Move
	{
#nullable enable
		private static MoveConfide? _instance = null;
#nullable restore
        public static MoveConfide Instance => _instance ?? (_instance = new MoveConfide());

		public MoveConfide() : base(
			"Confide",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}