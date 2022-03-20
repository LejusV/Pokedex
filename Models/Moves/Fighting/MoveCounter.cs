using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts twice the damage the user received from the last physical hit it took.
	public class MoveCounter : Move
	{
#nullable enable
		private static MoveCounter? _instance = null;
#nullable restore
        public static MoveCounter Instance => _instance ?? (_instance = new MoveCounter());

		public MoveCounter() : base(
			"Counter",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, null,// PP & Pow
			100, -5 // Acc & Priority
		) {}
	}
}