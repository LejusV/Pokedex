using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveTwinkleTacklePhysical : Move
	{
#nullable enable
		private static MoveTwinkleTacklePhysical? _instance = null;
#nullable restore
        public static MoveTwinkleTacklePhysical Instance => _instance ?? (_instance = new MoveTwinkleTacklePhysical());

		public MoveTwinkleTacklePhysical() : base(
			"Twinkle-Tackle--Physical",
			Fairy.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}