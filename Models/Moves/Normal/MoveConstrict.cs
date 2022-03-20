using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to lower the target's Speed by one stage.
	public class MoveConstrict : Move
	{
#nullable enable
		private static MoveConstrict? _instance = null;
#nullable restore
        public static MoveConstrict Instance => _instance ?? (_instance = new MoveConstrict());

		public MoveConstrict() : base(
			"Constrict",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			35, 10,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}