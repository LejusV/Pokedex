using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveHyperBeam : Move
	{
#nullable enable
		private static MoveHyperBeam? _instance = null;
#nullable restore
        public static MoveHyperBeam Instance => _instance ?? (_instance = new MoveHyperBeam());

		public MoveHyperBeam() : base(
			"Hyper-Beam",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}