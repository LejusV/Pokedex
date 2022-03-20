using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Guarantees a critical hit with the user's next move.
	public class MoveLaserFocus : Move
	{
#nullable enable
		private static MoveLaserFocus? _instance = null;
#nullable restore
        public static MoveLaserFocus Instance => _instance ?? (_instance = new MoveLaserFocus());

		public MoveLaserFocus() : base(
			"Laser-Focus",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}