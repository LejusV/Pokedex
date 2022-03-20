using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Wartortle Species to store common natural stats of all Wartortles
	#region WartortleSpecies
	public class WartortleSpecies : PokemonSpecies
	{
#nullable enable
		private static WartortleSpecies? _instance = null;
#nullable restore
        public static WartortleSpecies Instance => _instance ?? (_instance = new WartortleSpecies());

		#region WartortleSpecies Constructor
		public WartortleSpecies() : base(
			8,
			"Wartortle",
			Water.Instance,
			1.0,
			22.5,
			new PokemonStats(
				59, // HPs
				63, 80, // Attack & Defense
				65, 80, // Spacial Attack & Defense
				58 // Speed
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
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
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
				"Substitute",
				"Snore",
				"Curse",
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
				"Rock-Tomb",
				"Iron-Defense",
				"Water-Pulse",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Zen-Headbutt",
				"Captivate",
				"Round",
				"Scald",
				"Water-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}