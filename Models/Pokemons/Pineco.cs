using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pineco Species to store common natural stats of all Pinecos
	#region SpeciesPineco
	public class SpeciesPineco : PokemonSpecies
	{
#nullable enable
		private static SpeciesPineco? _instance = null;
#nullable restore
        public static SpeciesPineco Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPineco();
                }
                return _instance;
            }
        }

		#region SpeciesPineco Constructor
		public SpeciesPineco() : base(
			204,
			"Pineco",
			0.6,
			7.2,
			50, // HPs
			65, 90, // Attack & Defense
			35, 35, // Special Attack & Defense
			15		
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
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Pin-Missile",
				"Counter",
				"Strength",
				"Solar-Beam",
				"String-Shot",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Self-Destruct",
				"Swift",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Spikes",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Rapid-Spin",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Revenge",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Iron-Defense",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Power-Trick",
				"Toxic-Spikes",
				"Captivate",
				"Stealth-Rock",
				"Bug-Bite",
				"Venoshock",
				"Round",
				"Struggle-Bug",
				"Bulldoze",
				"Drill-Run",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Pineco PokemonInstance Class
	#region Pineco
	public class PinecoInstance : PokemonInstance
	{
		#region Pineco Constructors
		/// <summary>
		/// Pineco Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PinecoInstance(string nickname, int level)
		: base(
				SpeciesPineco.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pineco Builder only waiting for a Level
		/// </summary>
		public PinecoInstance(int level)
		: base(
				SpeciesPineco.Instance, // PokemonInstance Species
				"Pineco", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pineco Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PinecoInstance() : base(
			SpeciesPineco.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}