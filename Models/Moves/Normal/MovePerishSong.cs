using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User and target both faint after three turns.
	public class MovePerishSong : Move
	{
#nullable enable
		private static MovePerishSong? _instance = null;
#nullable restore
        public static MovePerishSong Instance => _instance ?? (_instance = new MovePerishSong());

		public MovePerishSong() : base(
			"Perish-Song",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}