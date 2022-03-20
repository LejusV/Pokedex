using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the user's Special Attack by two stages after inflicting damage.
	public class MoveFleurCannon : Move
	{
#nullable enable
		private static MoveFleurCannon? _instance = null;
#nullable restore
        public static MoveFleurCannon Instance => _instance ?? (_instance = new MoveFleurCannon());

		public MoveFleurCannon() : base(
			"Fleur-Cannon",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 130,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}