using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Special Defense by two stages.
	public class MoveMetalSound : Move
	{
#nullable enable
		private static MoveMetalSound? _instance = null;
#nullable restore
        public static MoveMetalSound Instance => _instance ?? (_instance = new MoveMetalSound());

		public MoveMetalSound() : base(
			"Metal-Sound",
			Steel.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}