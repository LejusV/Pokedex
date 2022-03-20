using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//If the user misses, it takes half the damage it would have inflicted in recoil.
	public class MoveJumpKick : Move
	{
#nullable enable
		private static MoveJumpKick? _instance = null;
#nullable restore
        public static MoveJumpKick Instance => _instance ?? (_instance = new MoveJumpKick());

		public MoveJumpKick() : base(
			"Jump-Kick",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}