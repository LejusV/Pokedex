using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tropius Species to store common natural stats of all Tropiuss
	#region SpeciesTropius
	public class SpeciesTropius : PokemonSpecies
	{
#nullable enable
		private static SpeciesTropius? _instance = null;
#nullable restore
        public static SpeciesTropius Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTropius();
                }
                return _instance;
            }
        }

		#region SpeciesTropius Constructor
		public SpeciesTropius() : base(
			357,
			"Tropius",
			2.0,
			100.0,
			99, // HPs
			68, 83, // Attack & Defense
			72, 87, // Special Attack & Defense
			51		
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
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Gust",
				"Whirlwind",
				"Fly",
				"Slam",
				"Stomp",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Outrage",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Bullet-Seed",
				"Aerial-Ace",
				"Magical-Leaf",
				"Leaf-Blade",
				"Dragon-Dance",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"Worry-Seed",
				"Seed-Bomb",
				"Air-Slash",
				"Dragon-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Defog",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Ominous-Wind",
				"Round",
				"Bestow",
				"Bulldoze",
				"Leaf-Tornado",
				"Confide",
				"Dragon-Hammer",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Tropius PokemonInstance Class
	#region Tropius
	public class TropiusInstance : PokemonInstance
	{
		#region Tropius Constructors
		/// <summary>
		/// Tropius Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TropiusInstance(string nickname, int level)
		: base(
				SpeciesTropius.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tropius Builder only waiting for a Level
		/// </summary>
		public TropiusInstance(int level)
		: base(
				SpeciesTropius.Instance, // PokemonInstance Species
				"Tropius", level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tropius Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TropiusInstance() : base(
			SpeciesTropius.Instance, // PokemonInstance Species
			Grass.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}