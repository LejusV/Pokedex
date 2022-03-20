using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Speed by two stages.
	public class MoveStringShot : Move
	{
#nullable enable
		private static MoveStringShot? _instance = null;
#nullable restore
        public static MoveStringShot Instance => _instance ?? (_instance = new MoveStringShot());

		public MoveStringShot() : base(
			"String-Shot",
			Bug.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}