using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the target's Special Attack by one stage and confuses the target.
	public class MoveFlatter : Move
	{
#nullable enable
		private static MoveFlatter? _instance = null;
#nullable restore
        public static MoveFlatter Instance => _instance ?? (_instance = new MoveFlatter());

		public MoveFlatter() : base(
			"Flatter",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}