using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Drains half the damage inflicted to heal the user.
	public class MoveLeechLife : Move
	{
#nullable enable
		private static MoveLeechLife? _instance = null;
#nullable restore
        public static MoveLeechLife Instance => _instance ?? (_instance = new MoveLeechLife());

		public MoveLeechLife() : base(
			"Leech-Life",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}