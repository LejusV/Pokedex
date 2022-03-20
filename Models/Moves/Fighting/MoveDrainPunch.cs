using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Drains half the damage inflicted to heal the user.
	public class MoveDrainPunch : Move
	{
#nullable enable
		private static MoveDrainPunch? _instance = null;
#nullable restore
        public static MoveDrainPunch Instance => _instance ?? (_instance = new MoveDrainPunch());

		public MoveDrainPunch() : base(
			"Drain-Punch",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 75,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}