using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Venusaur Species to store common natural stats of all Venusaurs
	#region SpeciesVenusaur
	public class SpeciesVenusaur : PokemonSpecies
	{
#nullable enable
		private static SpeciesVenusaur? _instance = null;
#nullable restore
        public static SpeciesVenusaur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVenusaur();
                }
                return _instance;
            }
        }

		#region SpeciesVenusaur Constructor
		public SpeciesVenusaur() : base(
			"Venusaur",
			2.0,
			100.0,
			80, // HPs
			82, 83, // Attack & Defense
			100, 100, // Special Attack & Defense
			80		
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
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Sleep-Powder",
				"Petal-Dance",
				"String-Shot",
				"Earthquake",
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
				"Outrage",
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
				"Block",
				"Frenzy-Plant",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Rock-Climb",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Round",
				"Echoed-Voice",
				"Grass-Pledge",
				"Bulldoze",
				"Work-Up",
				"Petal-Blizzard",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Venusaur PokemonInstance Class
	#region Venusaur
	public class VenusaurInstance : PokemonInstance
	{
		#region Venusaur Constructors
		/// <summary>
		/// Venusaur Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VenusaurInstance(string nickname, int level)
		: base(
				3,
				SpeciesVenusaur.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venusaur Builder only waiting for a Level
		/// </summary>
		public VenusaurInstance(int level)
		: base(
				3,
				SpeciesVenusaur.Instance, // PokemonInstance Species
				"Venusaur", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venusaur Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Venusaur() : base(
			3,
			SpeciesVenusaur.Instance, // PokemonInstance Species
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}