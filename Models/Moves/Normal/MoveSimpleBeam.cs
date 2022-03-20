using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Changes the target's ability to Simple.
	public class MoveSimpleBeam : Move
	{
#nullable enable
		private static MoveSimpleBeam? _instance = null;
#nullable restore
        public static MoveSimpleBeam Instance => _instance ?? (_instance = new MoveSimpleBeam());

		public MoveSimpleBeam() : base(
			"Simple-Beam",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}