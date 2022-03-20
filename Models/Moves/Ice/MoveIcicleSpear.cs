using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveIcicleSpear : Move
	{
#nullable enable
		private static MoveIcicleSpear? _instance = null;
#nullable restore
        public static MoveIcicleSpear Instance => _instance ?? (_instance = new MoveIcicleSpear());

		public MoveIcicleSpear() : base(
			"Icicle-Spear",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 25,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}