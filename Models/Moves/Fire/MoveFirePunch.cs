using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to burn the target.
	public class MoveFirePunch : Move
	{
#nullable enable
		private static MoveFirePunch? _instance = null;
#nullable restore
        public static MoveFirePunch Instance => _instance ?? (_instance = new MoveFirePunch());

		public MoveFirePunch() : base(
			"Fire-Punch",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 75,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}