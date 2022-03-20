using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveCatastropika : Move
	{
#nullable enable
		private static MoveCatastropika? _instance = null;
#nullable restore
        public static MoveCatastropika Instance => _instance ?? (_instance = new MoveCatastropika());

		public MoveCatastropika() : base(
			"Catastropika",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, 210,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}