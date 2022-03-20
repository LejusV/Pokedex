using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the user's Defense, Special Defense, and Speed by one stage each.
	public class MoveVCreate : Move
	{
#nullable enable
		private static MoveVCreate? _instance = null;
#nullable restore
        public static MoveVCreate Instance => _instance ?? (_instance = new MoveVCreate());

		public MoveVCreate() : base(
			"V-Create",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 180,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}