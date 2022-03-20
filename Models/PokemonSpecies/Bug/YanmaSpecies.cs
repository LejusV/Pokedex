using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Yanma Species to store common natural stats of all Yanmas
	#region YanmaSpecies
	public class YanmaSpecies : PokemonSpecies
	{
#nullable enable
		private static YanmaSpecies? _instance = null;
#nullable restore
        public static YanmaSpecies Instance => _instance ?? (_instance = new YanmaSpecies());

		#region YanmaSpecies Constructor
		public YanmaSpecies() : base(
			193,
			"Yanma",
			Bug.Instance, Flying.Instance,
			1.2,
			38.0,
			new PokemonStats(
				65, // HPs
				65, 45, // Attack & Defense
				75, 45, // Spacial Attack & Defense
				95 // Speed
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
				"Wing-Attack",
				"Whirlwind",
				"Headbutt",
				"Tackle",
				"Double-Edge",
				"Supersonic",
				"Sonic-Boom",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Quick-Attack",
				"Mimic",
				"Screech",
				"Double-Team",
				"Swift",
				"Dream-Eater",
				"Leech-Life",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Feint-Attack",
				"Foresight",
				"Detect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Feint",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
				"Bug-Buzz",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Round",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}