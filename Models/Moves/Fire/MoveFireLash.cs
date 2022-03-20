using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Defense by one stage after inflicting damage.
	public class MoveFireLash : Move
	{
#nullable enable
		private static MoveFireLash? _instance = null;
#nullable restore
        public static MoveFireLash Instance => _instance ?? (_instance = new MoveFireLash());

		public MoveFireLash() : base(
			"Fire-Lash",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}