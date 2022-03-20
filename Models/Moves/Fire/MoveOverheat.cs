using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the user's Special Attack by two stages after inflicting damage.
	public class MoveOverheat : Move
	{
#nullable enable
		private static MoveOverheat? _instance = null;
#nullable restore
        public static MoveOverheat Instance => _instance ?? (_instance = new MoveOverheat());

		public MoveOverheat() : base(
			"Overheat",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 130,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}