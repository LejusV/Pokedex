using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Drains 75% of the damage inflicted to heal the user.
	public class MoveOblivionWing : Move
	{
#nullable enable
		private static MoveOblivionWing? _instance = null;
#nullable restore
        public static MoveOblivionWing Instance => _instance ?? (_instance = new MoveOblivionWing());

		public MoveOblivionWing() : base(
			"Oblivion-Wing",
			Flying.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}