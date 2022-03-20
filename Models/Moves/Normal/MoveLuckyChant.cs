using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from scoring critical hits for five turns.
	public class MoveLuckyChant : Move
	{
#nullable enable
		private static MoveLuckyChant? _instance = null;
#nullable restore
        public static MoveLuckyChant Instance => _instance ?? (_instance = new MoveLuckyChant());

		public MoveLuckyChant() : base(
			"Lucky-Chant",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}