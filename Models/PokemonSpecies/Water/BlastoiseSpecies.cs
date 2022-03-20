using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Blastoise Species to store common natural stats of all Blastoises
	#region BlastoiseSpecies
	public class BlastoiseSpecies : PokemonSpecies
	{
#nullable enable
		private static BlastoiseSpecies? _instance = null;
#nullable restore
        public static BlastoiseSpecies Instance => _instance ?? (_instance = new BlastoiseSpecies());

		#region BlastoiseSpecies Constructor
		public BlastoiseSpecies() : base(
			9,
			"Blastoise",
			Water.Instance,
			1.6,
			85.5,
			new PokemonStats(
				79, // HPs
				83, 100, // Attack & Defense
				85, 105, // Spacial Attack & Defense
				78 // Speed
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
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Bite",
				"Roar",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Withdraw",
				"Defense-Curl",
				"Reflect",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Bubble",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Outrage",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Rapid-Spin",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Hydro-Cannon",
				"Rock-Tomb",
				"Signal-Beam",
				"Iron-Defense",
				"Water-Pulse",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Rock-Climb",
				"Captivate",
				"Smack-Down",
				"Round",
				"Scald",
				"Water-Pledge",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}