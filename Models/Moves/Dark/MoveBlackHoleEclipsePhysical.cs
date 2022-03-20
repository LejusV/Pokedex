using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBlackHoleEclipsePhysical : Move
	{
#nullable enable
		private static MoveBlackHoleEclipsePhysical? _instance = null;
#nullable restore
        public static MoveBlackHoleEclipsePhysical Instance => _instance ?? (_instance = new MoveBlackHoleEclipsePhysical());

		public MoveBlackHoleEclipsePhysical() : base(
			"Black-Hole-Eclipse--Physical",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}