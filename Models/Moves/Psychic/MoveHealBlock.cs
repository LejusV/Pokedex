using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents target from restoring its HP for five turns.
	public class MoveHealBlock : Move
	{
#nullable enable
		private static MoveHealBlock? _instance = null;
#nullable restore
        public static MoveHealBlock Instance => _instance ?? (_instance = new MoveHealBlock());

		public MoveHealBlock() : base(
			"Heal-Block",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}