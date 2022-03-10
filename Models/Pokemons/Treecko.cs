using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Treecko Species to store common natural stats of all Treeckos
	#region SpeciesTreecko
	public class SpeciesTreecko : PokemonSpecies
	{
#nullable enable
		private static SpeciesTreecko? _instance = null;
#nullable restore
        public static SpeciesTreecko Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTreecko();
                }
                return _instance;
            }
        }

		#region SpeciesTreecko Constructor
		public SpeciesTreecko() : base(
			"Treecko",
			0.5,
			5.0,
			40, // HPs
			45, 35, // Attack & Defense
			65, 55, // Special Attack & Defense
			70		
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
				"Pound",
				"Mega-Punch",
				"Thunder-Punch",
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Slam",
				"Double-Kick",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Screech",
				"Double-Team",
				"Swift",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Dragon-Breath",
				"Pursuit",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Mud-Sport",
				"Crush-Claw",
				"Rock-Tomb",
				"Grass-Whistle",
				"Bullet-Seed",
				"Aerial-Ace",
				"Magical-Leaf",
				"Natural-Gift",
				"Fling",
				"Worry-Seed",
				"Seed-Bomb",
				"Drain-Punch",
				"Energy-Ball",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Quick-Guard",
				"Acrobatics",
				"Grass-Pledge",
				"Work-Up",
				"Grassy-Terrain",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Treecko PokemonInstance Class
	#region Treecko
	public class TreeckoInstance : PokemonInstance
	{
		#region Treecko Constructors
		/// <summary>
		/// Treecko Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TreeckoInstance(string nickname, int level)
		: base(
				252,
				SpeciesTreecko.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Treecko Builder only waiting for a Level
		/// </summary>
		public TreeckoInstance(int level)
		: base(
				252,
				SpeciesTreecko.Instance, // PokemonInstance Species
				"Treecko", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Treecko Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Treecko() : base(
			252,
			SpeciesTreecko.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}