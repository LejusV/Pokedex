using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveEternabeam : Move
	{
#nullable enable
		private static MoveEternabeam? _instance = null;
#nullable restore
        public static MoveEternabeam Instance => _instance ?? (_instance = new MoveEternabeam());

		public MoveEternabeam() : base(
			"Eternabeam",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 160,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}