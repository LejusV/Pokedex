using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit and a 10% chance to burn the target.
	public class MoveBlazeKick : Move
	{
#nullable enable
		private static MoveBlazeKick? _instance = null;
#nullable restore
        public static MoveBlazeKick Instance => _instance ?? (_instance = new MoveBlazeKick());

		public MoveBlazeKick() : base(
			"Blaze-Kick",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 85,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}