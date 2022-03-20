using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Larvesta Species to store common natural stats of all Larvestas
	#region LarvestaSpecies
	public class LarvestaSpecies : PokemonSpecies
	{
#nullable enable
		private static LarvestaSpecies? _instance = null;
#nullable restore
        public static LarvestaSpecies Instance => _instance ?? (_instance = new LarvestaSpecies());

		#region LarvestaSpecies Constructor
		public LarvestaSpecies() : base(
			636,
			"Larvesta",
			Bug.Instance, Fire.Instance,
			1.1,
			28.8,
			new PokemonStats(
				55, // HPs
				85, 55, // Attack & Defense
				50, 55, // Spacial Attack & Defense
				60 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Ember",
				"Flamethrower",
				"Absorb",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Harden",
				"Light-Screen",
				"Fire-Blast",
				"Amnesia",
				"Leech-Life",
				"Rest",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Protect",
				"Foresight",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Morning-Sun",
				"Hidden-Power",
				"Sunny-Day",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Secret-Power",
				"Overheat",
				"Signal-Beam",
				"Calm-Mind",
				"U-Turn",
				"Magnet-Rise",
				"Flare-Blitz",
				"Bug-Buzz",
				"Zen-Headbutt",
				"Bug-Bite",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Acrobatics",
				"Struggle-Bug",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}