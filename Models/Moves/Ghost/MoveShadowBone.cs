using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to lower the target's Defense by one stage.
	public class MoveShadowBone : Move
	{
#nullable enable
		private static MoveShadowBone? _instance = null;
#nullable restore
        public static MoveShadowBone Instance => _instance ?? (_instance = new MoveShadowBone());

		public MoveShadowBone() : base(
			"Shadow-Bone",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 85,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}