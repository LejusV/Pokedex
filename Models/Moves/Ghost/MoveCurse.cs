using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Ghosts pay half their max HP to hurt the target every turn.  Others decrease Speed but raise Attack and Defense.
	public class MoveCurse : Move
	{
#nullable enable
		private static MoveCurse? _instance = null;
#nullable restore
        public static MoveCurse Instance => _instance ?? (_instance = new MoveCurse());

		public MoveCurse() : base(
			"Curse",
			Ghost.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}