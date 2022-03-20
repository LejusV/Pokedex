using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Sets Reflect on the user's side of the field after inflicting damage.
	public class MoveSnipeShot : Move
	{
#nullable enable
		private static MoveSnipeShot? _instance = null;
#nullable restore
        public static MoveSnipeShot Instance => _instance ?? (_instance = new MoveSnipeShot());

		public MoveSnipeShot() : base(
			"Snipe-Shot",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}