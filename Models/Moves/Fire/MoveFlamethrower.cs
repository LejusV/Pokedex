using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to burn the target.
	public class MoveFlamethrower : Move
	{
#nullable enable
		private static MoveFlamethrower? _instance = null;
#nullable restore
        public static MoveFlamethrower Instance => _instance ?? (_instance = new MoveFlamethrower());

		public MoveFlamethrower() : base(
			"Flamethrower",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}