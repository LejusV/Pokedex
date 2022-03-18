using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Skiploom Species to store common natural stats of all Skiplooms
	#region SpeciesSkiploom
	public class SpeciesSkiploom : PokemonSpecies
	{
#nullable enable
		private static SpeciesSkiploom? _instance = null;
#nullable restore
        public static SpeciesSkiploom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSkiploom();
                }
                return _instance;
            }
        }

		#region SpeciesSkiploom Constructor
		public SpeciesSkiploom() : base(
			188,
			"Skiploom",
			0.6,
			1.0,
			55, // HPs
			45, 50, // Attack & Defense
			45, 65, // Special Attack & Defense
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
				"Headbutt",
				"Tackle",
				"Double-Edge",
				"Tail-Whip",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Reflect",
				"Flash",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Cotton-Spore",
				"Protect",
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
				"Psych-Up",
				"Memento",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Silver-Wind",
				"Bullet-Seed",
				"Aerial-Ace",
				"Bounce",
				"Natural-Gift",
				"U-Turn",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Rage-Powder",
				"Round",
				"Acrobatics",
				"Fairy-Wind",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Skiploom PokemonInstance Class
	#region Skiploom
	public class SkiploomInstance : PokemonInstance
	{
		#region Skiploom Constructors
		/// <summary>
		/// Skiploom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SkiploomInstance(string nickname, int level)
		: base(
				SpeciesSkiploom.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skiploom Builder only waiting for a Level
		/// </summary>
		public SkiploomInstance(int level)
		: base(
				SpeciesSkiploom.Instance, // PokemonInstance Species
				"Skiploom", level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skiploom Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SkiploomInstance() : base(
			SpeciesSkiploom.Instance, // PokemonInstance Species
			Grass.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}