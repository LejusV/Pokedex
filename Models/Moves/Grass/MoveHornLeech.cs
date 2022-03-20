using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Drains half the damage inflicted to heal the user.
	public class MoveHornLeech : Move
	{
#nullable enable
		private static MoveHornLeech? _instance = null;
#nullable restore
        public static MoveHornLeech Instance => _instance ?? (_instance = new MoveHornLeech());

		public MoveHornLeech() : base(
			"Horn-Leech",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 75,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}