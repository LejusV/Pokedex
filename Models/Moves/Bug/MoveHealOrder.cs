using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Heals the user by half its max HP.
	public class MoveHealOrder : Move
	{
#nullable enable
		private static MoveHealOrder? _instance = null;
#nullable restore
        public static MoveHealOrder Instance => _instance ?? (_instance = new MoveHealOrder());

		public MoveHealOrder() : base(
			"Heal-Order",
			Bug.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}