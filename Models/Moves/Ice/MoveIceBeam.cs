using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to freeze the target.
	public class MoveIceBeam : Move
	{
#nullable enable
		private static MoveIceBeam? _instance = null;
#nullable restore
        public static MoveIceBeam Instance => _instance ?? (_instance = new MoveIceBeam());

		public MoveIceBeam() : base(
			"Ice-Beam",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}