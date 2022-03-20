using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Graveler Species to store common natural stats of all Gravelers
	#region GravelerSpecies
	public class GravelerSpecies : PokemonSpecies
	{
#nullable enable
		private static GravelerSpecies? _instance = null;
#nullable restore
        public static GravelerSpecies Instance => _instance ?? (_instance = new GravelerSpecies());

		#region GravelerSpecies Constructor
		public GravelerSpecies() : base(
			75,
			"Graveler",
			Rock.Instance, Ground.Instance,
			1.0,
			105.0,
			new PokemonStats(
				55, // HPs
				95, 115, // Attack & Defense
				45, 45, // Spacial Attack & Defense
				35 // Speed
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