using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Chespin Species to store common natural stats of all Chespins
	#region SpeciesChespin
	public class SpeciesChespin : PokemonSpecies
	{
#nullable enable
		private static SpeciesChespin? _instance = null;
#nullable restore
        public static SpeciesChespin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesChespin();
                }
                return _instance;
            }
        }

		#region SpeciesChespin Constructor
		public SpeciesChespin() : base(
			"Chespin",
			0.4,
			9.0,
			56, // HPs
			61, 65, // Attack & Defense
			48, 45, // Special Attack & Defense
			38		
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

	//Chespin PokemonInstance Class
	#region Chespin
	public class ChespinInstance : PokemonInstance
	{
		#region Chespin Constructors
		/// <summary>
		/// Chespin Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ChespinInstance(string nickname, int level)
		: base(
				650,
				SpeciesChespin.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chespin Builder only waiting for a Level
		/// </summary>
		public ChespinInstance(int level)
		: base(
				650,
				SpeciesChespin.Instance, // PokemonInstance Species
				"Chespin", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chespin Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Chespin() : base(
			650,
			SpeciesChespin.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}