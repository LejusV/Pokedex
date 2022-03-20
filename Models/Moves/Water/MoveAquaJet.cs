using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveAquaJet : Move
	{
#nullable enable
		private static MoveAquaJet? _instance = null;
#nullable restore
        public static MoveAquaJet Instance => _instance ?? (_instance = new MoveAquaJet());

		public MoveAquaJet() : base(
			"Aqua-Jet",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 40,// PP & Pow
			100, 1 // Acc & Priority
		) {}
	}
}