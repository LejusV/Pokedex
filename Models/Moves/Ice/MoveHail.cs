using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Changes the weather to a hailstorm for five turns.
	public class MoveHail : Move
	{
#nullable enable
		private static MoveHail? _instance = null;
#nullable restore
        public static MoveHail Instance => _instance ?? (_instance = new MoveHail());

		public MoveHail() : base(
			"Hail",
			Ice.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}