using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Weepinbell Species to store common natural stats of all Weepinbells
	#region SpeciesWeepinbell
	public class SpeciesWeepinbell : PokemonSpecies
	{
#nullable enable
		private static SpeciesWeepinbell? _instance = null;
#nullable restore
        public static SpeciesWeepinbell Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWeepinbell();
                }
                return _instance;
            }
        }

		#region SpeciesWeepinbell Constructor
		public SpeciesWeepinbell() : base(
			70,
			"Weepinbell",
			1.0,
			6.4,
			65, // HPs
			90, 50, // Attack & Defense
			85, 45, // Special Attack & Defense
			55		
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
				"Bind",
				"Slam",
				"Vine-Whip",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Acid",
				"Mega-Drain",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Knock-Off",
				"Secret-Power",
				"Bullet-Seed",
				"Natural-Gift",
				"Wring-Out",
				"Gastro-Acid",
				"Worry-Seed",
				"Sucker-Punch",
				"Poison-Jab",
				"Seed-Bomb",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Bug-Bite",
				"Venoshock",
				"Round",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Weepinbell PokemonInstance Class
	#region Weepinbell
	public class WeepinbellInstance : PokemonInstance
	{
		#region Weepinbell Constructors
		/// <summary>
		/// Weepinbell Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WeepinbellInstance(string nickname, int level)
		: base(
				SpeciesWeepinbell.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weepinbell Builder only waiting for a Level
		/// </summary>
		public WeepinbellInstance(int level)
		: base(
				SpeciesWeepinbell.Instance, // PokemonInstance Species
				"Weepinbell", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weepinbell Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public WeepinbellInstance() : base(
			SpeciesWeepinbell.Instance, // PokemonInstance Species
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}