using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User's type changes to the type of one of its moves at random.
	public class MoveConversion : Move
	{
#nullable enable
		private static MoveConversion? _instance = null;
#nullable restore
        public static MoveConversion Instance => _instance ?? (_instance = new MoveConversion());

		public MoveConversion() : base(
			"Conversion",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}