using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBreakneckBlitzPhysical : Move
	{
#nullable enable
		private static MoveBreakneckBlitzPhysical? _instance = null;
#nullable restore
        public static MoveBreakneckBlitzPhysical Instance => _instance ?? (_instance = new MoveBreakneckBlitzPhysical());

		public MoveBreakneckBlitzPhysical() : base(
			"Breakneck-Blitz--Physical",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}