using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Heals the user by half its max HP.
	public class MoveRecover : Move
	{
#nullable enable
		private static MoveRecover? _instance = null;
#nullable restore
        public static MoveRecover Instance => _instance ?? (_instance = new MoveRecover());

		public MoveRecover() : base(
			"Recover",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}