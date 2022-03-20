using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Defense and Special Defense by one stage.
	public class MoveDefendOrder : Move
	{
#nullable enable
		private static MoveDefendOrder? _instance = null;
#nullable restore
        public static MoveDefendOrder Instance => _instance ?? (_instance = new MoveDefendOrder());

		public MoveDefendOrder() : base(
			"Defend-Order",
			Bug.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}