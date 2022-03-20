using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveNeverEndingNightmarePhysical : Move
	{
#nullable enable
		private static MoveNeverEndingNightmarePhysical? _instance = null;
#nullable restore
        public static MoveNeverEndingNightmarePhysical Instance => _instance ?? (_instance = new MoveNeverEndingNightmarePhysical());

		public MoveNeverEndingNightmarePhysical() : base(
			"Never-Ending-Nightmare--Physical",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}