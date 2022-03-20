using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Scatters money on the ground worth five times the user's level.
	public class MovePayDay : Move
	{
#nullable enable
		private static MovePayDay? _instance = null;
#nullable restore
        public static MovePayDay Instance => _instance ?? (_instance = new MovePayDay());

		public MovePayDay() : base(
			"Pay-Day",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}