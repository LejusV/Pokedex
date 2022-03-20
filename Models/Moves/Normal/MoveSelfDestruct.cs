using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User faints.
	public class MoveSelfDestruct : Move
	{
#nullable enable
		private static MoveSelfDestruct? _instance = null;
#nullable restore
        public static MoveSelfDestruct Instance => _instance ?? (_instance = new MoveSelfDestruct());

		public MoveSelfDestruct() : base(
			"Self-Destruct",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 200,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}