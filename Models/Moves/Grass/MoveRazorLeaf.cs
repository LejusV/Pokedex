using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveRazorLeaf : Move
	{
#nullable enable
		private static MoveRazorLeaf? _instance = null;
#nullable restore
        public static MoveRazorLeaf Instance => _instance ?? (_instance = new MoveRazorLeaf());

		public MoveRazorLeaf() : base(
			"Razor-Leaf",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 55,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}