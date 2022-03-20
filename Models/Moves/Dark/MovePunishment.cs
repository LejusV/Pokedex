using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power increases against targets with more raised stats, up to a maximum of 200.
	public class MovePunishment : Move
	{
#nullable enable
		private static MovePunishment? _instance = null;
#nullable restore
        public static MovePunishment Instance => _instance ?? (_instance = new MovePunishment());

		public MovePunishment() : base(
			"Punishment",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}