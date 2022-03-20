using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBlackHoleEclipseSpecial : Move
	{
#nullable enable
		private static MoveBlackHoleEclipseSpecial? _instance = null;
#nullable restore
        public static MoveBlackHoleEclipseSpecial Instance => _instance ?? (_instance = new MoveBlackHoleEclipseSpecial());

		public MoveBlackHoleEclipseSpecial() : base(
			"Black-Hole-Eclipse--Special",
			Dark.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}