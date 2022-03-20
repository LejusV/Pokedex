using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User and target swap abilities.
	public class MoveSkillSwap : Move
	{
#nullable enable
		private static MoveSkillSwap? _instance = null;
#nullable restore
        public static MoveSkillSwap Instance => _instance ?? (_instance = new MoveSkillSwap());

		public MoveSkillSwap() : base(
			"Skill-Swap",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}