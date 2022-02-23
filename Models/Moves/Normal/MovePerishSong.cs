using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User and target both faint after three turns.
	public class MovePerishSong : Move
	{
		public MovePerishSong() : base(
			"Perish-Song",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}