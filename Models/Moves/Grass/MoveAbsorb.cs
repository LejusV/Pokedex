using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Drains half the damage inflicted to heal the user.
	public class MoveAbsorb : Move
	{
#nullable enable
		private static MoveAbsorb? _instance = null;
#nullable restore
        public static MoveAbsorb Instance => _instance ?? (_instance = new MoveAbsorb());

		public MoveAbsorb() : base(
			"Absorb",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			25, 20,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}