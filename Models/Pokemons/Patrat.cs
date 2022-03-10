using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Patrat Species to store common natural stats of all Patrats
	#region SpeciesPatrat
	public class SpeciesPatrat : PokemonSpecies
	{
#nullable enable
		private static SpeciesPatrat? _instance = null;
#nullable restore
        public static SpeciesPatrat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPatrat();
                }
                return _instance;
            }
        }

		#region SpeciesPatrat Constructor
		public SpeciesPatrat() : base(
			"Patrat",
			0.5,
			11.6,
			45, // HPs
			55, 39, // Attack & Defense
			35, 39, // Special Attack & Defense
			42		
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
				"Slam",
				"Sand-Attack",
				"Tackle",
				"Leer",
				"Bite",
				"Low-Kick",
				"Thunderbolt",
				"Dig",
				"Toxic",
				"Hypnosis",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Foresight",
				"Detect",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Facade",
				"Helping-Hand",
				"Revenge",
				"Endeavor",
				"Secret-Power",
				"Bullet-Seed",
				"Covet",
				"Shock-Wave",
				"Assurance",
				"Fling",
				"Last-Resort",
				"Aqua-Tail",
				"Seed-Bomb",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Gunk-Shot",
				"Grass-Knot",
				"After-You",
				"Round",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Tearful-Look"
			};
		}
		#endregion
	}
	#endregion

	//Patrat PokemonInstance Class
	#region Patrat
	public class PatratInstance : PokemonInstance
	{
		#region Patrat Constructors
		/// <summary>
		/// Patrat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PatratInstance(string nickname, int level)
		: base(
				504,
				SpeciesPatrat.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Patrat Builder only waiting for a Level
		/// </summary>
		public PatratInstance(int level)
		: base(
				504,
				SpeciesPatrat.Instance, // PokemonInstance Species
				"Patrat", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Patrat Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Patrat() : base(
			504,
			SpeciesPatrat.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}