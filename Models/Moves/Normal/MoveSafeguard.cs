using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Protects the user's field from major status ailments and confusion for five turns.
	public class MoveSafeguard : Move
	{
#nullable enable
		private static MoveSafeguard? _instance = null;
#nullable restore
        public static MoveSafeguard Instance => _instance ?? (_instance = new MoveSafeguard());

		public MoveSafeguard() : base(
			"Safeguard",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			25, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}