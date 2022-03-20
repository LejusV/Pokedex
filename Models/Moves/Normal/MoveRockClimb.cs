using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to confuse the target.
	public class MoveRockClimb : Move
	{
#nullable enable
		private static MoveRockClimb? _instance = null;
#nullable restore
        public static MoveRockClimb Instance => _instance ?? (_instance = new MoveRockClimb());

		public MoveRockClimb() : base(
			"Rock-Climb",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 90,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}