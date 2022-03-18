using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sceptile Species to store common natural stats of all Sceptiles
	#region SpeciesSceptile
	public class SpeciesSceptile : PokemonSpecies
	{
#nullable enable
		private static SpeciesSceptile? _instance = null;
#nullable restore
        public static SpeciesSceptile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSceptile();
                }
                return _instance;
            }
        }

		#region SpeciesSceptile Constructor
		public SpeciesSceptile() : base(
			254,
			"Sceptile",
			1.7,
			52.2,
			70, // HPs
			85, 65, // Attack & Defense
			105, 85, // Special Attack & Defense
			120		
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
				"Swords-Dance",
				"Cut",
				"Slam",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Roar",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Absorb",
				"Mega-Drain",
				"Solar-Beam",
				"Earthquake",
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
				"Outrage",
				"Giga-Drain",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Pursuit",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Bullet-Seed",
				"Aerial-Ace",
				"Dragon-Claw",
				"Frenzy-Plant",
				"Leaf-Blade",
				"Natural-Gift",
				"Fling",
				"Worry-Seed",
				"Night-Slash",
				"Seed-Bomb",
				"X-Scissor",
				"Dragon-Pulse",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Rock-Climb",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Acrobatics",
				"Grass-Pledge",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Sceptile PokemonInstance Class
	#region Sceptile
	public class SceptileInstance : PokemonInstance
	{
		#region Sceptile Constructors
		/// <summary>
		/// Sceptile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SceptileInstance(string nickname, int level)
		: base(
				SpeciesSceptile.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sceptile Builder only waiting for a Level
		/// </summary>
		public SceptileInstance(int level)
		: base(
				SpeciesSceptile.Instance, // PokemonInstance Species
				"Sceptile", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sceptile Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SceptileInstance() : base(
			SpeciesSceptile.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}