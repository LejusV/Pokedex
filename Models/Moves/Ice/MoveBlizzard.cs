using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to freeze the target.
	public class MoveBlizzard : Move
	{
#nullable enable
		private static MoveBlizzard? _instance = null;
#nullable restore
        public static MoveBlizzard Instance => _instance ?? (_instance = new MoveBlizzard());

		public MoveBlizzard() : base(
			"Blizzard",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 110,// PP & Pow
			70, 0 // Acc & Priority
		) {}
	}
}