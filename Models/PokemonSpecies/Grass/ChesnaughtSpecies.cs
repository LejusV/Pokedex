using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Chesnaught Species to store common natural stats of all Chesnaughts
	#region ChesnaughtSpecies
	public class ChesnaughtSpecies : PokemonSpecies
	{
#nullable enable
		private static ChesnaughtSpecies? _instance = null;
#nullable restore
        public static ChesnaughtSpecies Instance => _instance ?? (_instance = new ChesnaughtSpecies());

		#region ChesnaughtSpecies Constructor
		public ChesnaughtSpecies() : base(
			652,
			"Chesnaught",
			Grass.Instance, Fighting.Instance,
			1.6,
			90.0,
			new PokemonStats(
				88, // HPs
				107, 122, // Attack & Defense
				74, 75, // Spacial Attack & Defense
				64 // Speed
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
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Vine-Whip",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Pin-Missile",
				"Bite",
				"Growl",
				"Roar",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Leech-Seed",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Reflect",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Protect",
				"Belly-Drum",
				"Sludge-Bomb",
				"Giga-Drain",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Needle-Arm",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Dragon-Claw",
				"Frenzy-Plant",
				"Bulk-Up",
				"Mud-Shot",
				"Hammer-Arm",
				"Gyro-Ball",
				"Feint",
				"Payback",
				"Fling",
				"Worry-Seed",
				"Poison-Jab",
				"Seed-Bomb",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Wood-Hammer",
				"Hone-Claws",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Retaliate",
				"Grass-Pledge",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Spiky-Shield",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}