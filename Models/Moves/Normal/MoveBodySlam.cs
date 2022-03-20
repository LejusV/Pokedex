using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to paralyze the target.
	public class MoveBodySlam : Move
	{
#nullable enable
		private static MoveBodySlam? _instance = null;
#nullable restore
        public static MoveBodySlam Instance => _instance ?? (_instance = new MoveBodySlam());

		public MoveBodySlam() : base(
			"Body-Slam",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 85,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}