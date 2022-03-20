using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Special Defense by two stages.
	public class MoveFakeTears : Move
	{
#nullable enable
		private static MoveFakeTears? _instance = null;
#nullable restore
        public static MoveFakeTears Instance => _instance ?? (_instance = new MoveFakeTears());

		public MoveFakeTears() : base(
			"Fake-Tears",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}