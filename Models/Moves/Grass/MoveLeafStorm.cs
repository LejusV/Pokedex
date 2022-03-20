using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the user's Special Attack by two stages after inflicting damage.
	public class MoveLeafStorm : Move
	{
#nullable enable
		private static MoveLeafStorm? _instance = null;
#nullable restore
        public static MoveLeafStorm Instance => _instance ?? (_instance = new MoveLeafStorm());

		public MoveLeafStorm() : base(
			"Leaf-Storm",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 130,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}