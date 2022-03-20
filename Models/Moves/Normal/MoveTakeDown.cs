using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User receives 1/4 the damage it inflicts in recoil.
	public class MoveTakeDown : Move
	{
#nullable enable
		private static MoveTakeDown? _instance = null;
#nullable restore
        public static MoveTakeDown Instance => _instance ?? (_instance = new MoveTakeDown());

		public MoveTakeDown() : base(
			"Take-Down",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 90,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}