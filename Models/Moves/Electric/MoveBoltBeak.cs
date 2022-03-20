using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveBoltBeak : Move
	{
#nullable enable
		private static MoveBoltBeak? _instance = null;
#nullable restore
        public static MoveBoltBeak Instance => _instance ?? (_instance = new MoveBoltBeak());

		public MoveBoltBeak() : base(
			"Bolt-Beak",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 85,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}