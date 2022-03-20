using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Speed by two stages.
	public class MoveScaryFace : Move
	{
#nullable enable
		private static MoveScaryFace? _instance = null;
#nullable restore
        public static MoveScaryFace Instance => _instance ?? (_instance = new MoveScaryFace());

		public MoveScaryFace() : base(
			"Scary-Face",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}