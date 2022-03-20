using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 50% chance to lower the target's accuracy by one stage.
	public class MoveOctazooka : Move
	{
#nullable enable
		private static MoveOctazooka? _instance = null;
#nullable restore
        public static MoveOctazooka Instance => _instance ?? (_instance = new MoveOctazooka());

		public MoveOctazooka() : base(
			"Octazooka",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 65,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}