using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bunnelby Species to store common natural stats of all Bunnelbys
	#region SpeciesBunnelby
	public class SpeciesBunnelby : PokemonSpecies
	{
#nullable enable
		private static SpeciesBunnelby? _instance = null;
#nullable restore
        public static SpeciesBunnelby Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBunnelby();
                }
                return _instance;
            }
        }

		#region SpeciesBunnelby Constructor
		public SpeciesBunnelby() : base(
			659,
			"Bunnelby",
			0.4,
			5.0,
			38, // HPs
			36, 38, // Attack & Defense
			32, 36, // Special Attack & Defense
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
				"Double-Slap",
				"Cut",
				"Double-Kick",
				"Tackle",
				"Take-Down",
				"Leer",
				"Surf",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Defense-Curl",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Spikes",
				"Sandstorm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Nature-Power",
				"Recycle",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Bulk-Up",
				"Bounce",
				"Mud-Shot",
				"U-Turn",
				"Payback",
				"Fling",
				"Last-Resort",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Smack-Down",
				"Round",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Bunnelby PokemonInstance Class
	#region Bunnelby
	public class BunnelbyInstance : PokemonInstance
	{
		#region Bunnelby Constructors
		/// <summary>
		/// Bunnelby Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BunnelbyInstance(string nickname, int level)
		: base(
				SpeciesBunnelby.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bunnelby Builder only waiting for a Level
		/// </summary>
		public BunnelbyInstance(int level)
		: base(
				SpeciesBunnelby.Instance, // PokemonInstance Species
				"Bunnelby", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bunnelby Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BunnelbyInstance() : base(
			SpeciesBunnelby.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}