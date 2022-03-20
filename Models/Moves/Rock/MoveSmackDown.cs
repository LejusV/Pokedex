using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Removes any immunity to Ground damage.
	public class MoveSmackDown : Move
	{
#nullable enable
		private static MoveSmackDown? _instance = null;
#nullable restore
        public static MoveSmackDown Instance => _instance ?? (_instance = new MoveSmackDown());

		public MoveSmackDown() : base(
			"Smack-Down",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}