using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Hoothoot Species to store common natural stats of all Hoothoots
	#region HoothootSpecies
	public class HoothootSpecies : PokemonSpecies
	{
#nullable enable
		private static HoothootSpecies? _instance = null;
#nullable restore
        public static HoothootSpecies Instance => _instance ?? (_instance = new HoothootSpecies());

		#region HoothootSpecies Constructor
		public HoothootSpecies() : base(
			163,
			"Hoothoot",
			Normal.Instance, Flying.Instance,
			0.7,
			21.2,
			new PokemonStats(
				60, // HPs
				30, 30, // Attack & Defense
				36, 56, // Spacial Attack & Defense
				50 // Speed
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
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Supersonic",
				"Peck",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Agility",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Mirror-Move",
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
				"Feint-Attack",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Mean-Look",
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
				"Feather-Dance",
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
				"Zen-Headbutt",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Hurricane",
				"Moonblast",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}