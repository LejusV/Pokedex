using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Whismur Species to store common natural stats of all Whismurs
	#region WhismurSpecies
	public class WhismurSpecies : PokemonSpecies
	{
#nullable enable
		private static WhismurSpecies? _instance = null;
#nullable restore
        public static WhismurSpecies Instance => _instance ?? (_instance = new WhismurSpecies());

		#region WhismurSpecies Constructor
		public WhismurSpecies() : base(
			293,
			"Whismur",
			Normal.Instance,
			0.6,
			16.3,
			new PokemonStats(
				64, // HPs
				51, 23, // Attack & Defense
				51, 23, // Spacial Attack & Defense
				28 // Speed
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
				"Pound",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Whirlwind",
				"Stomp",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Supersonic",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"Seismic-Toss",
				"Solar-Beam",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Smokescreen",
				"Defense-Curl",
				"Fire-Blast",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Smelling-Salts",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Fake-Tears",
				"Extrasensory",
				"Howl",
				"Shock-Wave",
				"Water-Pulse",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Zen-Headbutt",
				"Captivate",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Circle-Throw",
				"Incinerate",
				"Retaliate",
				"Work-Up",
				"Disarming-Voice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}