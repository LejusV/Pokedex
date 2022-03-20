using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Puts the target to sleep.
	public class MoveLovelyKiss : Move
	{
#nullable enable
		private static MoveLovelyKiss? _instance = null;
#nullable restore
        public static MoveLovelyKiss Instance => _instance ?? (_instance = new MoveLovelyKiss());

		public MoveLovelyKiss() : base(
			"Lovely-Kiss",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			75, 0 // Acc & Priority
		) {}
	}
}