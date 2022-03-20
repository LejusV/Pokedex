using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Speed by two stages.
	public class MoveAgility : Move
	{
#nullable enable
		private static MoveAgility? _instance = null;
#nullable restore
        public static MoveAgility Instance => _instance ?? (_instance = new MoveAgility());

		public MoveAgility() : base(
			"Agility",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}