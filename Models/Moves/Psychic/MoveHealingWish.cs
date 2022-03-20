using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User faints.  Its replacement has its HP fully restored and any major status effect removed.
	public class MoveHealingWish : Move
	{
#nullable enable
		private static MoveHealingWish? _instance = null;
#nullable restore
        public static MoveHealingWish Instance => _instance ?? (_instance = new MoveHealingWish());

		public MoveHealingWish() : base(
			"Healing-Wish",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}