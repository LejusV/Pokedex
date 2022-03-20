using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a higher chance to confuse the target when the recorded sound is louder.
	public class MoveChatter : Move
	{
#nullable enable
		private static MoveChatter? _instance = null;
#nullable restore
        public static MoveChatter Instance => _instance ?? (_instance = new MoveChatter());

		public MoveChatter() : base(
			"Chatter",
			Flying.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}