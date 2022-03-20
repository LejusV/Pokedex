using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveLeafage : Move
	{
#nullable enable
		private static MoveLeafage? _instance = null;
#nullable restore
        public static MoveLeafage Instance => _instance ?? (_instance = new MoveLeafage());

		public MoveLeafage() : base(
			"Leafage",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			40, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}