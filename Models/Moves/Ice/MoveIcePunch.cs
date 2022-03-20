using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to freeze the target.
	public class MoveIcePunch : Move
	{
#nullable enable
		private static MoveIcePunch? _instance = null;
#nullable restore
        public static MoveIcePunch Instance => _instance ?? (_instance = new MoveIcePunch());

		public MoveIcePunch() : base(
			"Ice-Punch",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 75,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}