using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Geodude Species to store common natural stats of all Geodudes
	#region GeodudeSpecies
	public class GeodudeSpecies : PokemonSpecies
	{
#nullable enable
		private static GeodudeSpecies? _instance = null;
#nullable restore
        public static GeodudeSpecies Instance => _instance ?? (_instance = new GeodudeSpecies());

		#region GeodudeSpecies Constructor
		public GeodudeSpecies() : base(
			74,
			"Geodude",
			Rock.Instance, Ground.Instance,
			0.4,
			20.0,
			new PokemonStats(
				40, // HPs
				80, 100, // Attack & Defense
				30, 30, // Spacial Attack & Defense
				20 // Speed
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
				"Mega-Punch",
				"Fire-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Flamethrower",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Rock-Throw",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Bide",
				"Metronome",
				"Self-Destruct",
				"Fire-Blast",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Dynamic-Punch",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Mud-Sport",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Rock-Blast",
				"Hammer-Arm",
				"Gyro-Ball",
				"Natural-Gift",
				"Fling",
				"Sucker-Punch",
				"Rock-Polish",
				"Earth-Power",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Wide-Guard",
				"Autotomize",
				"Smack-Down",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}