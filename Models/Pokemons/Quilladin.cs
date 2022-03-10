using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Quilladin Species to store common natural stats of all Quilladins
	#region SpeciesQuilladin
	public class SpeciesQuilladin : PokemonSpecies
	{
#nullable enable
		private static SpeciesQuilladin? _instance = null;
#nullable restore
        public static SpeciesQuilladin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesQuilladin();
                }
                return _instance;
            }
        }

		#region SpeciesQuilladin Constructor
		public SpeciesQuilladin() : base(
			"Quilladin",
			0.7,
			29.0,
			61, // HPs
			78, 95, // Attack & Defense
			56, 58, // Special Attack & Defense
			57		
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

	//Quilladin PokemonInstance Class
	#region Quilladin
	public class QuilladinInstance : PokemonInstance
	{
		#region Quilladin Constructors
		/// <summary>
		/// Quilladin Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public QuilladinInstance(string nickname, int level)
		: base(
				651,
				SpeciesQuilladin.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quilladin Builder only waiting for a Level
		/// </summary>
		public QuilladinInstance(int level)
		: base(
				651,
				SpeciesQuilladin.Instance, // PokemonInstance Species
				"Quilladin", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quilladin Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Quilladin() : base(
			651,
			SpeciesQuilladin.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}