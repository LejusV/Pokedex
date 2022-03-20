using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 70% chance to raise the user's Special Attack by one stage.
	public class MoveChargeBeam : Move
	{
#nullable enable
		private static MoveChargeBeam? _instance = null;
#nullable restore
        public static MoveChargeBeam Instance => _instance ?? (_instance = new MoveChargeBeam());

		public MoveChargeBeam() : base(
			"Charge-Beam",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 50,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}