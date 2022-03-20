using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has double power if the target has a major status ailment.
	public class MoveHex : Move
	{
#nullable enable
		private static MoveHex? _instance = null;
#nullable restore
        public static MoveHex Instance => _instance ?? (_instance = new MoveHex());

		public MoveHex() : base(
			"Hex",
			Ghost.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}