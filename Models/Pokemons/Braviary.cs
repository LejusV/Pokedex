using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Braviary Species to store common natural stats of all Braviarys
	#region SpeciesBraviary
	public class SpeciesBraviary : PokemonSpecies
	{
#nullable enable
		private static SpeciesBraviary? _instance = null;
#nullable restore
        public static SpeciesBraviary Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBraviary();
                }
                return _instance;
            }
        }

		#region SpeciesBraviary Constructor
		public SpeciesBraviary() : base(
			"Braviary",
			1.5,
			41.0,
			100, // HPs
			123, 75, // Attack & Defense
			57, 75, // Special Attack & Defense
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
				"Cut",
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Fury-Attack",
				"Thrash",
				"Leer",
				"Hyper-Beam",
				"Peck",
				"Strength",
				"Toxic",
				"Double-Team",
				"Sky-Attack",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Facade",
				"Superpower",
				"Secret-Power",
				"Crush-Claw",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
				"Brave-Bird",
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Defog",
				"Hone-Claws",
				"Round",
				"Sky-Drop",
				"Retaliate",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Braviary PokemonInstance Class
	#region Braviary
	public class BraviaryInstance : PokemonInstance
	{
		#region Braviary Constructors
		/// <summary>
		/// Braviary Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BraviaryInstance(string nickname, int level)
		: base(
				628,
				SpeciesBraviary.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Braviary Builder only waiting for a Level
		/// </summary>
		public BraviaryInstance(int level)
		: base(
				628,
				SpeciesBraviary.Instance, // PokemonInstance Species
				"Braviary", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Braviary Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Braviary() : base(
			628,
			SpeciesBraviary.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}