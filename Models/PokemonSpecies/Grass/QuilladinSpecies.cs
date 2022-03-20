using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Quilladin Species to store common natural stats of all Quilladins
	#region QuilladinSpecies
	public class QuilladinSpecies : PokemonSpecies
	{
#nullable enable
		private static QuilladinSpecies? _instance = null;
#nullable restore
        public static QuilladinSpecies Instance => _instance ?? (_instance = new QuilladinSpecies());

		#region QuilladinSpecies Constructor
		public QuilladinSpecies() : base(
			651,
			"Quilladin",
			Grass.Instance,
			0.7,
			29.0,
			new PokemonStats(
				61, // HPs
				78, 95, // Attack & Defense
				56, 58, // Spacial Attack & Defense
				57 // Speed
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
				"Reflect",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Protect",
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
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}