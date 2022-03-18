using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Emboar Species to store common natural stats of all Emboars
	#region SpeciesEmboar
	public class SpeciesEmboar : PokemonSpecies
	{
#nullable enable
		private static SpeciesEmboar? _instance = null;
#nullable restore
        public static SpeciesEmboar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesEmboar();
                }
                return _instance;
            }
        }

		#region SpeciesEmboar Constructor
		public SpeciesEmboar() : base(
			500,
			"Emboar",
			1.6,
			150.0,
			110, // HPs
			123, 65, // Attack & Defense
			100, 65, // Special Attack & Defense
			65		
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
				"Fire-Punch",
				"Thunder-Punch",
				"Tackle",
				"Take-Down",
				"Tail-Whip",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
				"Smog",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Arm-Thrust",
				"Blast-Burn",
				"Overheat",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Block",
				"Bulk-Up",
				"Covet",
				"Hammer-Arm",
				"Gyro-Ball",
				"Assurance",
				"Fling",
				"Flare-Blitz",
				"Poison-Jab",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Head-Smash",
				"Smack-Down",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Incinerate",
				"Fire-Pledge",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Heat-Crash",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Emboar PokemonInstance Class
	#region Emboar
	public class EmboarInstance : PokemonInstance
	{
		#region Emboar Constructors
		/// <summary>
		/// Emboar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public EmboarInstance(string nickname, int level)
		: base(
				SpeciesEmboar.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Emboar Builder only waiting for a Level
		/// </summary>
		public EmboarInstance(int level)
		: base(
				SpeciesEmboar.Instance, // PokemonInstance Species
				"Emboar", level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Emboar Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public EmboarInstance() : base(
			SpeciesEmboar.Instance, // PokemonInstance Species
			Fire.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}