using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's evasion by one stage.
	public class MoveDoubleTeam : Move
	{
#nullable enable
		private static MoveDoubleTeam? _instance = null;
#nullable restore
        public static MoveDoubleTeam Instance => _instance ?? (_instance = new MoveDoubleTeam());

		public MoveDoubleTeam() : base(
			"Double-Team",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}