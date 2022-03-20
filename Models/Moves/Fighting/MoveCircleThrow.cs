using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Ends wild battles.  Forces trainers to switch Pokémon.
	public class MoveCircleThrow : Move
	{
#nullable enable
		private static MoveCircleThrow? _instance = null;
#nullable restore
        public static MoveCircleThrow Instance => _instance ?? (_instance = new MoveCircleThrow());

		public MoveCircleThrow() : base(
			"Circle-Throw",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 60,// PP & Pow
			90, -6 // Acc & Priority
		) {}
	}
}