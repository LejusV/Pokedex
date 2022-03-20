using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Steals the target's stat increases, then inflicts damage.
	public class MoveSpectralThief : Move
	{
#nullable enable
		private static MoveSpectralThief? _instance = null;
#nullable restore
        public static MoveSpectralThief Instance => _instance ?? (_instance = new MoveSpectralThief());

		public MoveSpectralThief() : base(
			"Spectral-Thief",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}