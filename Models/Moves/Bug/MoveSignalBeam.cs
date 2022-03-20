using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to confuse the target.
	public class MoveSignalBeam : Move
	{
#nullable enable
		private static MoveSignalBeam? _instance = null;
#nullable restore
        public static MoveSignalBeam Instance => _instance ?? (_instance = new MoveSignalBeam());

		public MoveSignalBeam() : base(
			"Signal-Beam",
			Bug.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 75,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}