using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ivysaur Species to store common natural stats of all Ivysaurs
	#region SpeciesIvysaur
	public class SpeciesIvysaur : PokemonSpecies
	{
#nullable enable
		private static SpeciesIvysaur? _instance = null;
#nullable restore
        public static SpeciesIvysaur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesIvysaur();
                }
                return _instance;
            }
        }

		#region SpeciesIvysaur Constructor
		public SpeciesIvysaur() : base(
			2,
			"Ivysaur",
			1.0,
			13.0,
			60, // HPs
			62, 63, // Attack & Defense
			80, 80, // Special Attack & Defense
			60		
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
				"Vine-Whip",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Strength",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Sleep-Powder",
				"String-Shot",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Knock-Off",
				"Secret-Power",
				"Bullet-Seed",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Round",
				"Echoed-Voice",
				"Grass-Pledge",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Ivysaur PokemonInstance Class
	#region Ivysaur
	public class IvysaurInstance : PokemonInstance
	{
		#region Ivysaur Constructors
		/// <summary>
		/// Ivysaur Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public IvysaurInstance(string nickname, int level)
		: base(
				SpeciesIvysaur.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ivysaur Builder only waiting for a Level
		/// </summary>
		public IvysaurInstance(int level)
		: base(
				SpeciesIvysaur.Instance, // PokemonInstance Species
				"Ivysaur", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ivysaur Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public IvysaurInstance() : base(
			SpeciesIvysaur.Instance, // PokemonInstance Species
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}