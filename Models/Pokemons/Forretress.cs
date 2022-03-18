using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Forretress Species to store common natural stats of all Forretresss
	#region SpeciesForretress
	public class SpeciesForretress : PokemonSpecies
	{
#nullable enable
		private static SpeciesForretress? _instance = null;
#nullable restore
        public static SpeciesForretress Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesForretress();
                }
                return _instance;
            }
        }

		#region SpeciesForretress Constructor
		public SpeciesForretress() : base(
			205,
			"Forretress",
			1.2,
			125.8,
			75, // HPs
			90, 140, // Attack & Defense
			60, 60, // Special Attack & Defense
			40		
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
				"Hyper-Beam",
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
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Spikes",
				"Zap-Cannon",
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
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Iron-Defense",
				"Block",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Toxic-Spikes",
				"Magnet-Rise",
				"Rock-Polish",
				"Giga-Impact",
				"Mirror-Shot",
				"Flash-Cannon",
				"Captivate",
				"Stealth-Rock",
				"Bug-Bite",
				"Venoshock",
				"Autotomize",
				"Heavy-Slam",
				"Round",
				"Volt-Switch",
				"Struggle-Bug",
				"Bulldoze",
				"Drill-Run",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Forretress PokemonInstance Class
	#region Forretress
	public class ForretressInstance : PokemonInstance
	{
		#region Forretress Constructors
		/// <summary>
		/// Forretress Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ForretressInstance(string nickname, int level)
		: base(
				SpeciesForretress.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Forretress Builder only waiting for a Level
		/// </summary>
		public ForretressInstance(int level)
		: base(
				SpeciesForretress.Instance, // PokemonInstance Species
				"Forretress", level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Forretress Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ForretressInstance() : base(
			SpeciesForretress.Instance, // PokemonInstance Species
			Bug.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}