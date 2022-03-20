using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveMagicalLeaf : Move
	{
#nullable enable
		private static MoveMagicalLeaf? _instance = null;
#nullable restore
        public static MoveMagicalLeaf Instance => _instance ?? (_instance = new MoveMagicalLeaf());

		public MoveMagicalLeaf() : base(
			"Magical-Leaf",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 60,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}