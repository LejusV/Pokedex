using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBloomDoomSpecial : Move
	{
#nullable enable
		private static MoveBloomDoomSpecial? _instance = null;
#nullable restore
        public static MoveBloomDoomSpecial Instance => _instance ?? (_instance = new MoveBloomDoomSpecial());

		public MoveBloomDoomSpecial() : base(
			"Bloom-Doom--Special",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}