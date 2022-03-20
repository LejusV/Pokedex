using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the user from leaving battle.  User regains 1/16 of its max HP every turn.
	public class MoveIngrain : Move
	{
#nullable enable
		private static MoveIngrain? _instance = null;
#nullable restore
        public static MoveIngrain Instance => _instance ?? (_instance = new MoveIngrain());

		public MoveIngrain() : base(
			"Ingrain",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}