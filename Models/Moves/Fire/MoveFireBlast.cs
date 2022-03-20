using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to burn the target.
	public class MoveFireBlast : Move
	{
#nullable enable
		private static MoveFireBlast? _instance = null;
#nullable restore
        public static MoveFireBlast Instance => _instance ?? (_instance = new MoveFireBlast());

		public MoveFireBlast() : base(
			"Fire-Blast",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 110,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}