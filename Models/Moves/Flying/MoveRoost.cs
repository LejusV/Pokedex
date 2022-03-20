using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Heals the user by half its max HP.
	public class MoveRoost : Move
	{
#nullable enable
		private static MoveRoost? _instance = null;
#nullable restore
        public static MoveRoost Instance => _instance ?? (_instance = new MoveRoost());

		public MoveRoost() : base(
			"Roost",
			Flying.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}