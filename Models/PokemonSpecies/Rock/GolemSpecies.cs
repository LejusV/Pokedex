using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Golem Species to store common natural stats of all Golems
	#region GolemSpecies
	public class GolemSpecies : PokemonSpecies
	{
#nullable enable
		private static GolemSpecies? _instance = null;
#nullable restore
        public static GolemSpecies Instance => _instance ?? (_instance = new GolemSpecies());

		#region GolemSpecies Constructor
		public GolemSpecies() : base(
			76,
			"Golem",
			Rock.Instance, Ground.Instance,
			1.4,
			300.0,
			new PokemonStats(
				80, // HPs
				120, 130, // Attack & Defense
				55, 65, // Spacial Attack & Defense
				45 // Speed
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
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Flamethrower",
				"Hyper-Beam",
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
				"Fury-Cutter",
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
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Heavy-Slam",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Steamroller",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}