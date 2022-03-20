using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Puts the target to sleep.
	public class MoveSpore : Move
	{
#nullable enable
		private static MoveSpore? _instance = null;
#nullable restore
        public static MoveSpore Instance => _instance ?? (_instance = new MoveSpore());

		public MoveSpore() : base(
			"Spore",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}