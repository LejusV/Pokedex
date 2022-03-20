using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBloomDoomPhysical : Move
	{
#nullable enable
		private static MoveBloomDoomPhysical? _instance = null;
#nullable restore
        public static MoveBloomDoomPhysical Instance => _instance ?? (_instance = new MoveBloomDoomPhysical());

		public MoveBloomDoomPhysical() : base(
			"Bloom-Doom--Physical",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}