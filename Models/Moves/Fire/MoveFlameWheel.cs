using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to burn the target.  Lets frozen Pokémon thaw themselves.
	public class MoveFlameWheel : Move
	{
#nullable enable
		private static MoveFlameWheel? _instance = null;
#nullable restore
        public static MoveFlameWheel Instance => _instance ?? (_instance = new MoveFlameWheel());

		public MoveFlameWheel() : base(
			"Flame-Wheel",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}