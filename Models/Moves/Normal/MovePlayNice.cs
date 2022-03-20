using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack by one stage.
	public class MovePlayNice : Move
	{
#nullable enable
		private static MovePlayNice? _instance = null;
#nullable restore
        public static MovePlayNice Instance => _instance ?? (_instance = new MovePlayNice());

		public MovePlayNice() : base(
			"Play-Nice",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}