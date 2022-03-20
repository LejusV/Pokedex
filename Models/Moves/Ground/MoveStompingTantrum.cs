using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has double power if the user's last move failed.
	public class MoveStompingTantrum : Move
	{
#nullable enable
		private static MoveStompingTantrum? _instance = null;
#nullable restore
        public static MoveStompingTantrum Instance => _instance ?? (_instance = new MoveStompingTantrum());

		public MoveStompingTantrum() : base(
			"Stomping-Tantrum",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 75,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}