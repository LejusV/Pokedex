using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to confuse the target.
	public class MoveHurricane : Move
	{
#nullable enable
		private static MoveHurricane? _instance = null;
#nullable restore
        public static MoveHurricane Instance => _instance ?? (_instance = new MoveHurricane());

		public MoveHurricane() : base(
			"Hurricane",
			Flying.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 110,// PP & Pow
			70, 0 // Acc & Priority
		) {}
	}
}