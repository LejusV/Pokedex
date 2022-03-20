using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveAuraWheel : Move
	{
#nullable enable
		private static MoveAuraWheel? _instance = null;
#nullable restore
        public static MoveAuraWheel Instance => _instance ?? (_instance = new MoveAuraWheel());

		public MoveAuraWheel() : base(
			"Aura-Wheel",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 110,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}