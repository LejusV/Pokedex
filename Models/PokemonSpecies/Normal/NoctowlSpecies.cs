using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Noctowl Species to store common natural stats of all Noctowls
	#region NoctowlSpecies
	public class NoctowlSpecies : PokemonSpecies
	{
#nullable enable
		private static NoctowlSpecies? _instance = null;
#nullable restore
        public static NoctowlSpecies Instance => _instance ?? (_instance = new NoctowlSpecies());

		#region NoctowlSpecies Constructor
		public NoctowlSpecies() : base(
			164,
			"Noctowl",
			Normal.Instance, Flying.Instance,
			1.6,
			40.8,
			new PokemonStats(
				100, // HPs
				50, 50, // Attack & Defense
				86, 96, // Spacial Attack & Defense
				70 // Speed
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
				"Fly",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Hyper-Beam",
				"Peck",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Magic-Coat",
				"Recycle",
				"Secret-Power",
				"Hyper-Voice",
				"Air-Cutter",
				"Silver-Wind",
				"Extrasensory",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"Psycho-Shift",
				"Air-Slash",
				"Giga-Impact",
				"Zen-Headbutt",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Moonblast",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}