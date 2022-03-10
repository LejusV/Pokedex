using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cherubi Species to store common natural stats of all Cherubis
	#region SpeciesCherubi
	public class SpeciesCherubi : PokemonSpecies
	{
#nullable enable
		private static SpeciesCherubi? _instance = null;
#nullable restore
        public static SpeciesCherubi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCherubi();
                }
                return _instance;
            }
        }

		#region SpeciesCherubi Constructor
		public SpeciesCherubi() : base(
			"Cherubi",
			0.4,
			3.3,
			45, // HPs
			35, 45, // Attack & Defense
			62, 53, // Special Attack & Defense
			35		
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
				"Tackle",
				"Take-Down",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Morning-Sun",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Secret-Power",
				"Weather-Ball",
				"Aromatherapy",
				"Grass-Whistle",
				"Tickle",
				"Bullet-Seed",
				"Magical-Leaf",
				"Healing-Wish",
				"Natural-Gift",
				"Lucky-Chant",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Heal-Pulse",
				"Petal-Blizzard",
				"Flower-Shield",
				"Grassy-Terrain",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Cherubi PokemonInstance Class
	#region Cherubi
	public class CherubiInstance : PokemonInstance
	{
		#region Cherubi Constructors
		/// <summary>
		/// Cherubi Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CherubiInstance(string nickname, int level)
		: base(
				420,
				SpeciesCherubi.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cherubi Builder only waiting for a Level
		/// </summary>
		public CherubiInstance(int level)
		: base(
				420,
				SpeciesCherubi.Instance, // PokemonInstance Species
				"Cherubi", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cherubi Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Cherubi() : base(
			420,
			SpeciesCherubi.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}