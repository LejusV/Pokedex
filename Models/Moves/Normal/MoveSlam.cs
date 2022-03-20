using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSlam : Move
	{
#nullable enable
		private static MoveSlam? _instance = null;
#nullable restore
        public static MoveSlam Instance => _instance ?? (_instance = new MoveSlam());

		public MoveSlam() : base(
			"Slam",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 80,// PP & Pow
			75, 0 // Acc & Priority
		) {}
	}
}