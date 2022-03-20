using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveCorkscrewCrashPhysical : Move
	{
#nullable enable
		private static MoveCorkscrewCrashPhysical? _instance = null;
#nullable restore
        public static MoveCorkscrewCrashPhysical Instance => _instance ?? (_instance = new MoveCorkscrewCrashPhysical());

		public MoveCorkscrewCrashPhysical() : base(
			"Corkscrew-Crash--Physical",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}