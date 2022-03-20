using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Defense by two stages.
	public class MoveBarrier : Move
	{
#nullable enable
		private static MoveBarrier? _instance = null;
#nullable restore
        public static MoveBarrier Instance => _instance ?? (_instance = new MoveBarrier());

		public MoveBarrier() : base(
			"Barrier",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}