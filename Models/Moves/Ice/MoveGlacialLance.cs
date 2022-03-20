using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveGlacialLance : Move
	{
#nullable enable
		private static MoveGlacialLance? _instance = null;
#nullable restore
        public static MoveGlacialLance Instance => _instance ?? (_instance = new MoveGlacialLance());

		public MoveGlacialLance() : base(
			"Glacial-Lance",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 130,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}