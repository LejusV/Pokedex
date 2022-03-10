using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Foongus Species to store common natural stats of all Foonguss
	#region SpeciesFoongus
	public class SpeciesFoongus : PokemonSpecies
	{
#nullable enable
		private static SpeciesFoongus? _instance = null;
#nullable restore
        public static SpeciesFoongus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFoongus();
                }
                return _instance;
            }
        }

		#region SpeciesFoongus Constructor
		public SpeciesFoongus() : base(
			"Foongus",
			0.2,
			1.0,
			69, // HPs
			55, 45, // Attack & Defense
			55, 55, // Special Attack & Defense
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
				"Body-Slam",
				"Absorb",
				"Mega-Drain",
				"Growth",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Spore",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Secret-Power",
				"Astonish",
				"Payback",
				"Gastro-Acid",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Grass-Knot",
				"Venoshock",
				"Rage-Powder",
				"Foul-Play",
				"After-You",
				"Round",
				"Clear-Smog",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Foongus PokemonInstance Class
	#region Foongus
	public class FoongusInstance : PokemonInstance
	{
		#region Foongus Constructors
		/// <summary>
		/// Foongus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FoongusInstance(string nickname, int level)
		: base(
				590,
				SpeciesFoongus.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Foongus Builder only waiting for a Level
		/// </summary>
		public FoongusInstance(int level)
		: base(
				590,
				SpeciesFoongus.Instance, // PokemonInstance Species
				"Foongus", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Foongus Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Foongus() : base(
			590,
			SpeciesFoongus.Instance, // PokemonInstance Species
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}