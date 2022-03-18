using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Hoppip Species to store common natural stats of all Hoppips
	#region SpeciesHoppip
	public class SpeciesHoppip : PokemonSpecies
	{
#nullable enable
		private static SpeciesHoppip? _instance = null;
#nullable restore
        public static SpeciesHoppip Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHoppip();
                }
                return _instance;
            }
        }

		#region SpeciesHoppip Constructor
		public SpeciesHoppip() : base(
			187,
			"Hoppip",
			0.4,
			0.5,
			35, // HPs
			35, 40, // Attack & Defense
			35, 55, // Special Attack & Defense
			50		
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
				"Pay-Day",
				"Swords-Dance",
				"Headbutt",
				"Tackle",
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Confusion",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Reflect",
				"Amnesia",
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
				"Encore",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Memento",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Aromatherapy",
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
				"Cotton-Guard",
				"Grassy-Terrain",
				"Fairy-Wind",
				"Confide",
				"Dazzling-Gleam",
				"Infestation",
				"Strength-Sap"
			};
		}
		#endregion
	}
	#endregion

	//Hoppip PokemonInstance Class
	#region Hoppip
	public class HoppipInstance : PokemonInstance
	{
		#region Hoppip Constructors
		/// <summary>
		/// Hoppip Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HoppipInstance(string nickname, int level)
		: base(
				SpeciesHoppip.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoppip Builder only waiting for a Level
		/// </summary>
		public HoppipInstance(int level)
		: base(
				SpeciesHoppip.Instance, // PokemonInstance Species
				"Hoppip", level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoppip Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HoppipInstance() : base(
			SpeciesHoppip.Instance, // PokemonInstance Species
			Grass.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}