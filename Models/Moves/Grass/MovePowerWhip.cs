using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePowerWhip : Move
	{
#nullable enable
		private static MovePowerWhip? _instance = null;
#nullable restore
        public static MovePowerWhip Instance => _instance ?? (_instance = new MovePowerWhip());

		public MovePowerWhip() : base(
			"Power-Whip",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 120,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}