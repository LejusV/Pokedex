using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Murkrow Species to store common natural stats of all Murkrows
	#region MurkrowSpecies
	public class MurkrowSpecies : PokemonSpecies
	{
#nullable enable
		private static MurkrowSpecies? _instance = null;
#nullable restore
        public static MurkrowSpecies Instance => _instance ?? (_instance = new MurkrowSpecies());

		#region MurkrowSpecies Constructor
		public MurkrowSpecies() : base(
			198,
			"Murkrow",
			Dark.Instance, Flying.Instance,
			0.5,
			2.1,
			new PokemonStats(
				60, // HPs
				85, 42, // Attack & Defense
				85, 42, // Spacial Attack & Defense
				91 // Speed
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
				"Fly",
				"Double-Edge",
				"Peck",
				"Drill-Peck",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Quick-Attack",
				"Night-Shade",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Haze",
				"Mirror-Move",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Perish-Song",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Flatter",
				"Facade",
				"Taunt",
				"Snatch",
				"Secret-Power",
				"Feather-Dance",
				"Astonish",
				"Air-Cutter",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"Payback",
				"Assurance",
				"Embargo",
				"Psycho-Shift",
				"Punishment",
				"Sucker-Punch",
				"Dark-Pulse",
				"Brave-Bird",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Foul-Play",
				"Round",
				"Quash",
				"Retaliate",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}