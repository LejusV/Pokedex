using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveHyperVoice : Move
	{
#nullable enable
		private static MoveHyperVoice? _instance = null;
#nullable restore
        public static MoveHyperVoice Instance => _instance ?? (_instance = new MoveHyperVoice());

		public MoveHyperVoice() : base(
			"Hyper-Voice",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}