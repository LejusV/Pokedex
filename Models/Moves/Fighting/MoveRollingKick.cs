using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveRollingKick : Move
	{
#nullable enable
		private static MoveRollingKick? _instance = null;
#nullable restore
        public static MoveRollingKick Instance => _instance ?? (_instance = new MoveRollingKick());

		public MoveRollingKick() : base(
			"Rolling-Kick",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 60,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}