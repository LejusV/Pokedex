using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Chesnaught Species to store common natural stats of all Chesnaughts
	#region SpeciesChesnaught
	public class SpeciesChesnaught : PokemonSpecies
	{
#nullable enable
		private static SpeciesChesnaught? _instance = null;
#nullable restore
        public static SpeciesChesnaught Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesChesnaught();
                }
                return _instance;
            }
        }

		#region SpeciesChesnaught Constructor
		public SpeciesChesnaught() : base(
			652,
			"Chesnaught",
			1.6,
			90.0,
			88, // HPs
			107, 122, // Attack & Defense
			74, 75, // Special Attack & Defense
			64		
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

	//Chesnaught PokemonInstance Class
	#region Chesnaught
	public class ChesnaughtInstance : PokemonInstance
	{
		#region Chesnaught Constructors
		/// <summary>
		/// Chesnaught Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ChesnaughtInstance(string nickname, int level)
		: base(
				SpeciesChesnaught.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chesnaught Builder only waiting for a Level
		/// </summary>
		public ChesnaughtInstance(int level)
		: base(
				SpeciesChesnaught.Instance, // PokemonInstance Species
				"Chesnaught", level,
				Grass.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chesnaught Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ChesnaughtInstance() : base(
			SpeciesChesnaught.Instance, // PokemonInstance Species
			Grass.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}