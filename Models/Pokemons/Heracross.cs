using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Heracross Species to store common natural stats of all Heracrosss
	#region SpeciesHeracross
	public class SpeciesHeracross : PokemonSpecies
	{
#nullable enable
		private static SpeciesHeracross? _instance = null;
#nullable restore
        public static SpeciesHeracross Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHeracross();
                }
                return _instance;
            }
        }

		#region SpeciesHeracross Constructor
		public SpeciesHeracross() : base(
			"Heracross",
			1.5,
			54.0,
			80, // HPs
			125, 75, // Attack & Defense
			40, 95, // Special Attack & Defense
			85		
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
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Horn-Attack",
				"Fury-Attack",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Pin-Missile",
				"Leer",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Reversal",
				"Protect",
				"Detect",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Arm-Thrust",
				"Rock-Tomb",
				"Bullet-Seed",
				"Aerial-Ace",
				"Iron-Defense",
				"Bulk-Up",
				"Rock-Blast",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Fling",
				"Night-Slash",
				"Vacuum-Wave",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Stone-Edge",
				"Captivate",
				"Bug-Bite",
				"Venoshock",
				"Smack-Down",
				"Round",
				"Chip-Away",
				"Retaliate",
				"Struggle-Bug",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Heracross PokemonInstance Class
	#region Heracross
	public class HeracrossInstance : PokemonInstance
	{
		#region Heracross Constructors
		/// <summary>
		/// Heracross Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HeracrossInstance(string nickname, int level)
		: base(
				214,
				SpeciesHeracross.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heracross Builder only waiting for a Level
		/// </summary>
		public HeracrossInstance(int level)
		: base(
				214,
				SpeciesHeracross.Instance, // PokemonInstance Species
				"Heracross", level,
				Bug.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heracross Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Heracross() : base(
			214,
			SpeciesHeracross.Instance, // PokemonInstance Species
			Bug.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}