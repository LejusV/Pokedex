using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Heals the user by half its max HP.
	public class MoveSlackOff : Move
	{
#nullable enable
		private static MoveSlackOff? _instance = null;
#nullable restore
        public static MoveSlackOff Instance => _instance ?? (_instance = new MoveSlackOff());

		public MoveSlackOff() : base(
			"Slack-Off",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}