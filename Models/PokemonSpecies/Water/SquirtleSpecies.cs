using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Squirtle Species to store common natural stats of all Squirtles
	#region SquirtleSpecies
	public class SquirtleSpecies : PokemonSpecies
	{
#nullable enable
		private static SquirtleSpecies? _instance = null;
#nullable restore
        public static SquirtleSpecies Instance => _instance ?? (_instance = new SquirtleSpecies());

		#region SquirtleSpecies Constructor
		public SquirtleSpecies() : base(
			7,
			"Squirtle",
			Water.Instance,
			0.5,
			9.0,
			new PokemonStats(
				44, // HPs
				48, 65, // Attack & Defense
				50, 64, // Spacial Attack & Defense
				43 // Speed
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
				"Mist",
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
				"Confusion",
				"Rage",
				"Mimic",
				"Double-Team",
				"Withdraw",
				"Defense-Curl",
				"Haze",
				"Reflect",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Foresight",
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
				"Mirror-Coat",
				"Rock-Smash",
				"Whirlpool",
				"Fake-Out",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Yawn",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Water-Spout",
				"Muddy-Water",
				"Iron-Defense",
				"Water-Pulse",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Aqua-Ring",
				"Aura-Sphere",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Zen-Headbutt",
				"Captivate",
				"Aqua-Jet",
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