using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Chespin Species to store common natural stats of all Chespins
	#region ChespinSpecies
	public class ChespinSpecies : PokemonSpecies
	{
#nullable enable
		private static ChespinSpecies? _instance = null;
#nullable restore
        public static ChespinSpecies Instance => _instance ?? (_instance = new ChespinSpecies());

		#region ChespinSpecies Constructor
		public ChespinSpecies() : base(
			650,
			"Chespin",
			Grass.Instance,
			0.4,
			9.0,
			new PokemonStats(
				56, // HPs
				61, 65, // Attack & Defense
				48, 45, // Spacial Attack & Defense
				38 // Speed
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
				"Low-Kick",
				"Strength",
				"Leech-Seed",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
				"Reflect",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Belly-Drum",
				"Sludge-Bomb",
				"Spikes",
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
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Bulk-Up",
				"Mud-Shot",
				"Gyro-Ball",
				"Payback",
				"Fling",
				"Worry-Seed",
				"Poison-Jab",
				"Seed-Bomb",
				"Drain-Punch",
				"Energy-Ball",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Wood-Hammer",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Retaliate",
				"Grass-Pledge",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}